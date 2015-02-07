#ifndef RigUtil_h
#define RigUtil_h

#include <Arduino.h>

///////////////////////////////
// Constants
///////////////////////////////

// OEM identifier
const byte KENWOOD = 0;
const byte ICOM = 1;
const byte YAESU = 2;

// Length of commands and responses in bytes
const int KENWOOD_REPLY_LEN = 38;
const int ICOM_QUERY_LEN = 6;       // frequency query
const int ICOM_REPLY_LEN = 11;      // frequency reply
const int ICOM_TRANSFER_LEN = 11;   // frequency transfer
const int ICOM_RESPONSE_LEN = 6;    // OK(0xFB) or NG(0xFA) response

// Band boundaries
const long BANDS[10][3] = {
  {  // in meters, lower, upper
    160, 1800000,  2000000  }
  ,{
    80,  3500000,  4000000  }
  ,{
    40,  7000000,  7300000  }
  ,{
    30, 10100000, 10150000  }
  ,{
    20, 14000000, 14350000  }
  ,{
    17, 18068000, 18168000  }
  ,{
    15, 21000000, 21450000  }
  ,{
    12, 24890000, 24990000  }
  ,{
    10, 28000000, 29700000  }
  ,{
    6,  50000000, 54000000  }
};
const byte METERS = 0;
const byte EDGE_L = 1;
const byte EDGE_H = 2;

// ICOM CI-V dialect
const byte ACK_OK = 0xFB;
const byte ACK_NG = 0xFA;

// other
const long NOFREQ = 0;
const int NO_MATCH = -1;

///////////////////////////////
// Class
///////////////////////////////

class RigUtil { 
public:
  // rig objects
  RigUtil(HardwareSerial *pSerial, byte bMake);  // Kenwood, Yaesu
  RigUtil(HardwareSerial *pSerial, byte bMake, byte bToHex, byte bFromHex);  // ICOM
  // functions
  long getFreq();
  boolean setFreq(long lFreq);
  int getBand(long lFreq);
private:
  // functions
  void flushRxBuffer();
  void chopRxBuffer(int iLen);
  // Kenwood radios
  void queryFreqKenwood();
  long retrieveFreqKenwood();
  boolean checkFreqPreambleKenwood();
  long decodeFreqKenwood();
  // ICOM radios
  void queryFreqICOM();
  long retrieveFreqICOM();
  boolean checkAddrPreambleICOM();
  boolean checkFreqPreambleICOM();
  long decodeFreqICOM();
  void transferFreqICOM(long lFreq);
  void encodeFreqICOM(byte* bBuf, long lFreq);
  boolean retrieveResponseICOM();
  // variables
  HardwareSerial* _pSerial;
  byte _bMake, _bToHex, _bFromHex;

  // misc
  long lFreq;
  char cBuf[11];
};

#endif







