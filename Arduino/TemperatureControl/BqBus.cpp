/**
 * @file BqBus.cpp
 * @author Wesley José Santos (https://binary-quantum.com)
 * @brief 
 * @version 0.1
 * @date 2020-05-15
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#include "BqBus.h"

/**
 * @brief Construct a new Bq Bus:: Bq Bus object
 * 
 * @param size regs count
 */
BqBus::BqBus(size_t size){
    this->size = size;
    delete [] this->data;
    delete [] this->dataChanged;
    this->data = new int [size];
    this->dataChanged = new bool [size];
    for (size_t i = 0; i < size; i++){
        this->data[i] = 0;
        this->dataChanged[i] = false;
    }
}

/**
 * @brief Set bus of communication
 * 
 * @param bus Stream or Serial instance
 */
void BqBus::setBus(Stream *bus){
    this->bus = bus;
}

/**
 * @brief Performs communication beetween devices
 * 
 */
void BqBus::communicationTask(){
    if(this->bus->available()){
        String reg;
        if (this->idx < size){
            reg = this->bus->readStringUntil(',');
        }else{
            reg = this->bus->readStringUntil('\n');
        }
        this->processReg(reg);
    }
}

/**
 * @brief Set register value
 * 
 * @param address address of register
 * @param value new value
 */
void BqBus::setReg(uint16_t address, int value){
    data[address] = value;
    dataChanged[address] = true;
}

/**
 * @brief Get register value
 * 
 * @param address address of register
 * @return int value of register
 */
int BqBus::getReg(uint16_t address){
    return(data[address]);
}

/**
 * @brief Process recieved register
 * 
 * @param reg register content to be processed
 */
void BqBus::processReg(String reg){
    if(!this->dataChanged[idx]){
        this->data[idx] = reg.toInt();
    }
    this->dataChanged[idx] = false;
    this->bus->print(data[idx]);
    idx++;
    if (this->idx < size){
        this->bus->print(',');
    }else{
        this->bus->print('\n');
        idx = 0;
    }
}
