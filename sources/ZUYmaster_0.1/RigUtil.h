#ifndef RigUtil_h
#define RigUtil_h

#include <Arduino.h>

#define KENWOOD 0
#define ICOM 1
#define YAESU 2

class RigUtil { 
	public:
		RigUtil(HardwareSerial *serial, byte bMake);
		long getFreq();
		void setFreq(long lFreq);
		int getBand();
		void setBand();
	private:
		HardwareSerial* _serial;
		byte _bMake;
};

#endif