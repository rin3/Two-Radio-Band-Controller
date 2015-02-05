/*
	ZUYmaster
	- a two radio band controller -
 
 	A band controller designed for use with two radio HF contesting environment such as SO2R, M/S and M/2.
 
 	Limitatoins:
  	This implimentation only for a combination of a pair of newer Kenwood/ICOM exciters, ICE-419B band pass filters and ICOM IC-PW1 amplifiers.
 	
  	The circuit consists of three boards:
   	1 - Arduino Mega 2560 board
    	1 - A Mega shield PCB with BPF I/F and IC-PW1 I/O
     	1 - Another PCB for exciter (Kenwood/ICOM) I/O

 	Arduino pin I/O used:
  	* Input
	  (none)
 	* Output
 	   4* - LED(green) - L Exciter status
 	   5* - LED(green) - R Exciter status
 	   2* - LED(red) - L IC-PW1 status
 	   3* - LED(red) - R IC-PW1 status
	   7* - Tr array - L ICE-419 160m
	   8* - Tr array - L ICE-419 80m
	   9* - Tr array - L ICE-419 40m
	  10* - Tr array - L ICE-419 20m
	  11* - Tr array - L ICE-419 15m
	  12* - Tr array - L ICE-419 10m
	  A2* - Tr array - R ICE-419 160m
	  A3* - Tr array - R ICE-419 80m
	  A4* - Tr array - R ICE-419 40m
	  A5* - Tr array - R ICE-419 20m
	  A6* - Tr array - R ICE-419 15m
	  A7* - Tr array - R ICE-419 10m
 	   6* - reed relay - L ICE-419 power control
 	  A0* - reed relay - R ICE-419 power control
	  13* - DIP switch - L Exciter Kenwood/ICOM selection
	  A1* - DIP switch - R Exciter Kenwood/ICOM selection
 	* Communications
 	   0/Rx, 1/Tx - Serial  - L Exciter
 	  15/Rx,14/Tx - Serial3 - R Exciter
 	  19/Rx,18/Tx - Serial1 - L IC-PW1
 	  17/Rx,16/Tx - Serial2 - R IC-PW1
 
 	Created 4 Feb 2015
 	rin JG1VGX (jg1vgx@jarl.com)
 
 	http://github.com/rin3/ZUYmaster
  */

const int pinRx[] = {
  0, 19, 17, 15};
const int pinTx[] = {
  1, 18, 16, 14};

byte bRX;  // received byte

void setup() {
  // turn L(13) off
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  
  // initialize serial
//  Serial3.begin(9600);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    bRX = Serial.read();
    Serial.println(bRX, HEX); 
  }
}


