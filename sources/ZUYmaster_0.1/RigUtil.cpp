#include <Arduino.h>
#include "RigUtil.h"

///////////////////////////////
// Constructors
///////////////////////////////

// Kenwood, Yaesu
RigUtil::RigUtil(HardwareSerial *pSerial, byte bMake) {
  _pSerial = pSerial;
  _bMake = bMake;
}

// ICOM
RigUtil::RigUtil(HardwareSerial *pSerial, byte bMake, byte bToHex, byte bFromHex) {
  _pSerial = pSerial;
  _bMake = bMake;
  _bToHex = bToHex;
  _bFromHex = bFromHex;
}

///////////////////////////////
// Public functions
///////////////////////////////

// get frequency
long RigUtil::getFreq() {
  switch (_bMake) {
  case KENWOOD:
    queryFreqKenwood();
    delay(100);    // shall we wait here?
    retrieveFreqKenwood();
    break;
  case ICOM:
    queryFreqICOM();
    delay(100);    // shall we wait here?
    retrieveFreqICOM();
    break;
  case YAESU:
    // unimplemented
    return NOFREQ;
    break;
  }
}

// set frequency
boolean RigUtil::setFreq(long lFreq) {
  switch (_bMake) {
  case KENWOOD:
    // unimplemented
    return false;
    break;
  case ICOM:
    transferFreqICOM(lFreq);
    delay(100);    // shall we wait here?
    return retrieveResponseICOM();
    break;
  case YAESU:
    // unimplemented
    return false;
    break;
  }
}

// get band
int RigUtil::getBand(long lFreq) {
  for (int i = 0; i < 10; i++) {
    if (BANDS[i][EDGE_L] <= lFreq && lFreq <= BANDS[i][EDGE_H])
      // band matched
      return i;
  }
  // not matched, outside HF and 6m (incl. WARC) bands
  return NO_MATCH;
}

///////////////////////////////
// Private functions
///////////////////////////////

// flush serial communication RX buffer
void RigUtil::flushRxBuffer() {
  while (_pSerial->read() != -1);

  // alternatively
  //  while (_pSerial->available())
  //  _pSerial->read();
}

// chop off one or more bytes
void RigUtil::chopRxBuffer(int iLen) {
  for (int i = 0; i < iLen; i++)
    _pSerial->read();
}

///////////////////////////////
// Kenwood routines
///////////////////////////////

// query frequecy
void RigUtil::queryFreqKenwood() {
  _pSerial->print("IF;");
}

// retrieve frequency
long RigUtil::retrieveFreqKenwood() {
  int i;
  if ((i = _pSerial->available()) == KENWOOD_REPLY_LEN) {
    // rig responded 
    if (checkFreqPreambleKenwood() == true) {
      lFreq = decodeFreqKenwood();
      flushRxBuffer();
      return lFreq;
    }
    // unsuccessful, incorrect preamble
  }
  // unsuccessful, rig unresponsive

  // flush buffer including postamble if any
  flushRxBuffer();
  return NOFREQ;  // return as failed
}

// check and remove preamble
boolean RigUtil::checkFreqPreambleKenwood() {
  return _pSerial->read() == 'I'
    && _pSerial->read() == 'F';
}

// decode frequency bytes
long RigUtil::decodeFreqKenwood() {
  lFreq = 0;
  _pSerial->readBytes(cBuf, 11);
  for (int i = 0; i < 11; i++) {
    lFreq *= 10;
    lFreq += (cBuf[i] - '0');
  }
  return lFreq;
}

///////////////////////////////
// ICOM routines
///////////////////////////////

// query frequecy
void RigUtil::queryFreqICOM() {
  _pSerial->write(0xFE);
  _pSerial->write(0xFE);
  _pSerial->write(_bToHex);
  _pSerial->write(_bFromHex);
  _pSerial->write(0x03);
  _pSerial->write(0xFD);
}

// retrieve frequecy
long RigUtil::retrieveFreqICOM() {
  int i;
  if ((i = _pSerial->available()) == ICOM_QUERY_LEN + ICOM_REPLY_LEN) {
    // rig responded
    chopRxBuffer(ICOM_QUERY_LEN);  // throw away reflected command
    if (checkFreqPreambleICOM() == true) {
      lFreq = decodeFreqICOM();
      // remove postamble
      _pSerial->read();
      return lFreq;
    } 
    // unsuccessful, incorrect preamble
  } 
  // unsuccessful, rig unresponsive

  // flush buffer including postamble if any
  flushRxBuffer();
  return NOFREQ;  // return as failed
}

// check and remove address preamble
boolean RigUtil::checkAddrPreambleICOM() {
  return _pSerial->read() == 0xFE
    && _pSerial->read() == 0xFE
    && _pSerial->read() == _bFromHex
    && _pSerial->read() == _bToHex;
}

// check and remove address and frequency preambles
boolean RigUtil::checkFreqPreambleICOM() {
  return checkAddrPreambleICOM()
    && _pSerial->read() == 0x03;
}

// decode frequency bytes
long RigUtil::decodeFreqICOM() {
  lFreq = 0;
  _pSerial->readBytes(cBuf, 5);
  for (int i = 4; i >= 0; i--) {
    lFreq *= 100;
    lFreq += (((byte)cBuf[i] & B00001111) + ((byte)cBuf[i] >> 4) * 10);
  }
  return lFreq;
}

// transfer frequency
void RigUtil::transferFreqICOM(long lFreq) {
  encodeFreqICOM((byte*)cBuf, lFreq);
  _pSerial->write(0xFE);
  _pSerial->write(0xFE);
  _pSerial->write(_bToHex);
  _pSerial->write(_bFromHex);
  _pSerial->write(0x05);
  for (int i = 0; i < 5; i++) {
    _pSerial->write((byte)cBuf[i]);
  }
  _pSerial->write(0xFD);
}

// encode frequency bytes
void RigUtil::encodeFreqICOM(byte* bBuf, long lFreq) {
  for (int i = 0; i < 5; i++) {
    int j = lFreq % 100;
    bBuf[i] = ((int)floor(j / 10) << 4) + j % 10;
    lFreq /= 100;
  }
}

boolean RigUtil::retrieveResponseICOM() {
  int i;
  if ((i = _pSerial->available()) == ICOM_TRANSFER_LEN + ICOM_RESPONSE_LEN) {
    // rig responded
    chopRxBuffer(ICOM_TRANSFER_LEN);  // throw away reflected command itself
    if (checkAddrPreambleICOM() == true) {
      int j = _pSerial->read();
      if (j == ACK_OK) {
        _pSerial->read();  // remove the last 0xFD;
        return true;
      } 
//      else if (j == ACK_NG) {
//        _pSerial->read();  // remove the last 0xFD;
//        return false;
//      }
//      // unsuccessful, neither 0xFB nor 0xFA (shouldn't happen)  
      // unsuccessful, NG response
    } 
    // unsuccessful, incorrect address preamble
  } 
  // unsuccessful, rig unresponsive

  // flush buffer including postamble if any
  flushRxBuffer();
  return false;  // return as failed
}

///////////////////////////////
// Yaesu routines
///////////////////////////////

// unimplemented
