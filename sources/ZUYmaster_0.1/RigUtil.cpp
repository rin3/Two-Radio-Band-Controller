#include <Arduino.h>
#include "RigUtil.h"

RigUtil::RigUtil(HardwareSerial *serial, byte bMake) {
	_serial = serial;
	_bMake = bMake;
}

long RigUtil::getFreq() {
}

void setFreq(long lFreq) { }
void setBand() { }
int getBand() { }
