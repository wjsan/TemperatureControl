/**
 * @file BqBus.h
 * @author Wesley José Santos (https://binary-quantum.com)
 * @brief 
 * @version 0.1
 * @date 2020-05-15
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#ifndef __BQBUS__H__
#define __BQBUS__H__

#include <Stream.h>

/**
 * @brief Class to handle BqBus communication
 * 
 */
class BqBus
{
private:
    Stream *bus;
    int *data;
    bool *dataChanged;
    size_t size, idx;
    void processReg(String reg);
public:
    BqBus(size_t size);
    void setBus(Stream *bus);
    void communicationTask();
    void setReg(uint16_t address, int value);
    int getReg(uint16_t address);
};

#endif  //!__BQBUS__H__