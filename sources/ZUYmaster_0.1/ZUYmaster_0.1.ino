#include "RigUtil.h"

// switch environment, test @MEGURO or real
//#define MEGURO
/*
	ZUYmaster
 	- a two radio band controller -
 
 	A band controller designed for use with two radio HF contesting environment such as SO2R, M/S and M/2.
 
 	Please set Transceive OFF for your ICOM radios.
 
 	Limitations:
 	This implimentation only works for a combination of two each of newer Kenwood/ICOM exciters, ICE-419B band pass filters and ICOM IC-PW1 amplifiers.
 	
 	The circuit consists of three boards:
 	1 - Arduino Mega 2560 board
 	1 - A Mega shield PCB with BPF I/F and IC-PW1 I/O
 	1 - Another PCB for exciter (Kenwood/ICOM) I/O
 
 	Arduino Mega I/O pins used:
 	* Digital Input (2)
 	  12 - DIP switch - L Exciter Kenwood/ICOM selection
 	  A1 - DIP switch - R Exciter Kenwood/ICOM selection
 	* Digital Output (18)
 	   5 - LED(green) - L Exciter status
 	   4 - LED(green) - R Exciter status
 	   2 - LED(red) - L IC-PW1 status
 	   3 - LED(red) - R IC-PW1 status
 	   7 - Tr array - L ICE-419 160m
 	   8 - Tr array - L ICE-419 80m
 	   9 - Tr array - L ICE-419 40m
 	  10 - Tr array - L ICE-419 20m
 	  11 - Tr array - L ICE-419 15m
 	  13 - Tr array - L ICE-419 10m
 	  A2 - Tr array - R ICE-419 160m
 	  A3 - Tr array - R ICE-419 80m
 	  A4 - Tr array - R ICE-419 40m
 	  A5 - Tr array - R ICE-419 20m
 	  A6 - Tr array - R ICE-419 15m
 	  A7 - Tr array - R ICE-419 10m
 	   6 - reed relay - L ICE-419 power control
 	  A0 - reed relay - R ICE-419 power control
 	* Communications (4x2)
 	   0/Rx, 1/Tx - Serial  - L Exciter
 	  15/Rx,14/Tx - Serial3 - R Exciter
 	  19/Rx,18/Tx - Serial1 - L IC-PW1
 	  17/Rx,16/Tx - Serial2 - R IC-PW1
 
 	Created 4 Feb 2015
 	rin JG1VGX (jg1vgx@jarl.com)
 
 	http://github.com/rin3/ZUYmaster
 */

///////////////////////////////
// Constants
///////////////////////////////

// loop iteration delay time (msec)
const int DELAY = 100;    // 20 is way too short, 50 is ok, 200 seems clumsy

// Exciters I/F
// Communication: Serial/L, Serial3/R
const byte MAKE_PIN[2] = {    // Kenwood/ICOM selection L,R pins
  12, A1};
const byte EXC_LED[2] = {    // status LEDs L,R pins
  5, 4};
const byte EXC_HEX[2] = { 
#ifdef MEGURO
  0x7C, 0x7C      // test w/IC-9100
#else
  0x7A, 0x7A      // real IC-7600
#endif
};
const int EXC_SPEED[2] = {   // COM speed L,R
  9600, 9600};
const int KENWOOD_PARAM = SERIAL_8N1;  // serial communcation parameters
const int ICOM_PARAM = SERIAL_8N1;
const int YAESU_PARAM = SERIAL_8N2;

// IC-PW1 I/F
// Communication: Serial1/L, Serial2/R
const byte AMP_LED[2] = {    // status LEDs L,R pins
  2, 3};
const byte AMP_HEX[2] = { 
  //  0x54, 0x54};               // default
  0x00, 0x00};               // better to use broadcast to inhibit PW1's Asynchronous 10 sec polls
const int AMP_SPEED[2] = {   // COM speed L,R
  9600, 9600};

// ICE-419 I/F
const byte BPF_PWR[2] = {    // powering relay L,R pins
  6, A0};
const byte BPF[2][6] = {    // band control pins
  {
    7, 8, 9, 10, 11, 13                                                        }      // 160,80,40,20,15,10m/L
  ,
  {
    A2, A3, A4, A5, A6, A7                                                        }   // 160,80,40,20,15,10m/R
};
const int BPF_BANDS[10] = {
  // corresponding the array index above, NO_MATCH is for WARC, 6m
  0, 1, 2, NO_MATCH, 3, NO_MATCH, 4, NO_MATCH, 5, NO_MATCH};

// ICOM HEX code for ZUYmaster
//const byte ZUY_HEX = 0xE0;  // PC
const byte ZUY_HEX = 0x7A;    // IC-7600 for compatibility reasons

///////////////////////////////
// Variables
///////////////////////////////

// Exciters
byte bMake[2];    // make: Kenwood = 0, ICOM = 1, Yaesu = 2
long lFreq[2];    // frequency
int iBand[2];     // band

// Pointers
HardwareSerial *pExcSer[2], *pAmpSer[2];
RigUtil *pExc[2], *pAmp[2];

///////////////////////////////
// Setup 
///////////////////////////////

void setup() {
  // pin modes
  for (int i = 0; i < 2; i++) {
    pinMode(MAKE_PIN[i], INPUT_PULLUP);
    pinMode(EXC_LED[i], OUTPUT);
    pinMode(AMP_LED[i], OUTPUT);
    pinMode(BPF_PWR[i], OUTPUT);
    for (int j = 0; j < 6; j++)
      pinMode(BPF[i][j], OUTPUT);
  }

  // put LEDs OFF, BPF PWR on
  for (int i = 0; i < 2; i++) {
    digitalWrite(EXC_LED[i], LOW);
    digitalWrite(AMP_LED[i], LOW);
    digitalWrite(BPF_PWR[i], HIGH);
  }

  // read Make DIPSW
  for (int i = 0; i < 2; i++)
    if (digitalRead(MAKE_PIN[i]) == HIGH)
      bMake[i] = KENWOOD;
    else
      bMake[i] = ICOM;

  // set HardwareSerial pointers
  pExcSer[0] = &Serial;
  pExcSer[1] = &Serial3;
  pAmpSer[0] = &Serial1;
  pAmpSer[1] = &Serial2;

  // create rig objects and start communication
  for (int i = 0; i < 2; i++) {
    // exciter
    if (bMake[i] != ICOM) {
      // Kenwood or Yaesu
      pExc[i] = new RigUtil(pExcSer[i], bMake[i]);
      pExcSer[i]->begin(EXC_SPEED[i], KENWOOD_PARAM);    // Yaesu yet unsupported
    } 
    else {
      // ICOM
      pExc[i] = new RigUtil(pExcSer[i], bMake[i], EXC_HEX[i], ZUY_HEX);
      pExcSer[i]->begin(EXC_SPEED[i], ICOM_PARAM);
    }

    // amplifier
    pAmp[i] = new RigUtil(pAmpSer[i], ICOM, AMP_HEX[i], ZUY_HEX);
    pAmpSer[i]->begin(AMP_SPEED[i], ICOM_PARAM);
  }
}

///////////////////////////////
// Loop 
///////////////////////////////

void loop() {
  // for each side of radios, BPFs and amplifiers
  for (int i = 0; i < 2; i++) {
    // read exciter frequency
    lFreq[i] = pExc[i]->getFreq();

    // put exciter LED
    if (lFreq[i] != NOFREQ)
      digitalWrite(EXC_LED[i], HIGH);
    else
      digitalWrite(EXC_LED[i], LOW);

    // get band index (0..9), cf.BANDS[10][3] array in RigUtil.h
    iBand[i] = pExc[i]->getBand(lFreq[i]);

    // control BPF
    int iPosit;
    if (iBand[i] != NO_MATCH) {
      // HF or 6m (incl. WARC) band
      iPosit = BPF_BANDS[iBand[i]];
    } 
    else {
      iPosit = NO_MATCH; 
    }
    setBPFRelays(i, iPosit);

    // set amplifier band and put LED
    if (pAmp[i]->setFreq(lFreq[i]) == true) {
      digitalWrite(AMP_LED[i], HIGH);
    }    
    else {
      digitalWrite(AMP_LED[i], LOW);
    }
  }

  // check band clashing

  delay(DELAY);
}

///////////////////////////////
// Functions 
///////////////////////////////

// set BPF band relays
void setBPFRelays(int iSide, int iPosit) {
  if (iPosit != NO_MATCH) {
    // HF contest band
    for (int j = 0; j < 6; j++) {
      if (j == iPosit)
        digitalWrite(BPF[iSide][j], HIGH);  // switch on the band at BPF
      else
        digitalWrite(BPF[iSide][j], LOW);   // switch off other bands
    } 
  } 
  else {
    // outside HF contest bands (incl. WARC, 6m)
    for (int j = 0; j < 6; j++) {
      digitalWrite(BPF[iSide][j], LOW);     // switch off all relays
    }
  }
}

