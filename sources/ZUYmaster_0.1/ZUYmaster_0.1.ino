#include "RigUtil.h"

#define UNO

/*
	ZUYmaster
 	- a two radio band controller -
 
 	A band controller designed for use with two radio HF contesting environment such as SO2R, M/S and M/2.
 
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
const int iDelay = 500;

// Exciters I/F
// Communication: Serial/L, Serial3/R
const byte bMakeSW[2] = {    // Kenwood/ICOM selection L,R
  12,A1};
const byte bExcLED[2] = {    // status LEDs L,R
  5,4};
const int iExcSpeed[2] = {   // COM speed L,R
  9600, 9600};

// IC-PW1 I/F
// Communication: Serial1/L, Serial2/R
const byte bAmpLED[2] = {    // status LEDs L,R
  2,3};
const int iAmpSpeed[2] = {   // COM speed L,R
  9600, 9600};

// ICE-419 I/F
const byte bBPFPWR[2] = {    // powering relay L,R
  6,A0};
const byte bBPF[2][6] = {    // band control
  {
    7,8,9,10,11,13      }      // 160,80,40,20,15,10m/L
  ,
  {
    A2,A3,A4,A5,A6,A7      }   // 160,80,40,20,15,10m/R
};

///////////////////////////////
// Variables
///////////////////////////////

// Exciters
byte bMake[2];    // Make: Kenwood = 0, ICOM = 1, Yaesu = 2
long lFreq[2];    // Frequency

int i, j, k;

RigUtil *pExc[2], *pAmp[2];

///////////////////////////////
// Setup 
///////////////////////////////

void setup() {
  // pin modes
  for (i = 0; i < 2; i++) {
    pinMode(bMakeSW[i], INPUT_PULLUP);
    pinMode(bExcLED[i], OUTPUT);
    pinMode(bAmpLED[i], OUTPUT);
    pinMode(bBPFPWR[i], OUTPUT);
    for (j = 0; j < 6; j++)
      pinMode(bBPF[i][j], OUTPUT);
  }

  // put LEDs OFF, BPF PWR off
  for (i = 0; i < 2; i++) {
    digitalWrite(bExcLED[i], LOW);
    digitalWrite(bAmpLED[i], LOW);
    digitalWrite(bBPFPWR[i], LOW);
  }

  // read Make DIPSW
  for (i = 0; i < 2; i++)
    if (digitalRead(bMakeSW[i]) == HIGH)
      bMake[i] = KENWOOD;
    else
      bMake[i] = ICOM;

  // creating rig objects
  RigUtil excL(&Serial, bMake[0]);
#ifndef UNO
  RigUtil excR(&Serial3, bMake[1]);
  RigUtil ampL(&Serial1, ICOM);
  RigUtil ampR(&Serial2, ICOM);
  pExc[0] = &excL;
  pExc[1] = &excR;
  pAmp[0] = &ampL;
  pAmp[1] = &ampR;
#else
  pExc[0] = &excL;
  pExc[1] = &excL;
  pAmp[0] = &excL;
  pAmp[1] = &excL;
#endif

  // initializing communication
  Serial.begin(iExcSpeed[0]);
#ifndef UNO
  Serial1.begin(iExcSpeed[1]);
  Serial2.begin(iAmpSpeed[0]);
  Serial3.begin(iAmpSpeed[1]);
#endif
}

///////////////////////////////
// Loop 
///////////////////////////////

void loop() {

  // for each side of radio sets
  for (i = 0; i < 2; i++) {
    // reading exciter frequency
    lFreq[i] = pExc[i]->getFreq();
    
    Serial.println(lFreq[i]);

    // HF contest band?

    // put LEDs
    // set BPF

    // set Amp

  }

  // check band clashing

  delay(iDelay);
}

///////////////////////////////
// Functions 
///////////////////////////////









