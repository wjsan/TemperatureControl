/**
 * @file Furnace.cpp
 * @author your name (you@domain.com)
 * @brief 
 * @version 0.1
 * @date 2020-05-21
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#include "Furnace.h"

Furnace::Furnace(){
    
};

/**
 * @brief Getters and Setters
 */

int Furnace::getTemperature(){
    return temp;
}

int Furnace::getStatus(){
    return this->status;
}

void Furnace::setAutomatic(bool automatic){
    this->automatic = automatic; 
}

void Furnace::setSetPoint(int setPoint) {
    this->setPoint = setPoint; 
}

void Furnace::setHisteresis(int histeresis) {
    this->histeresis = histeresis; 
}

void Furnace::setResistenceStatus(bool resistenceStatus) {
    if(!automatic) this->resistenceStatus = resistenceStatus; 
}

/**
 * @brief Update inputs variables of controller
 * 
 */
void Furnace::updateInputs(){
    temp = analogRead(PIN_TEMP_SENS);
    fail = digitalRead(PIN_FAIL);
    this->status = fail ? FurnaceStatus::Fail : (resistenceStatus ? FurnaceStatus::TurnedOn : FurnaceStatus::TurnedOff);
}

/**
 * @brief Process inputs and update outputs variables of controller
 * 
 */
void Furnace::updateOutputs(){
    static int histereseStatus = 0;
    if(automatic){
        if(temp < setPoint && histereseStatus == 0){
            resistenceStatus = true;
            histereseStatus = 1;
        }
        if(temp > setPoint && histereseStatus == 1){
            resistenceStatus = false;
            histereseStatus = 2;
        }
        if((temp + histeresis) < setPoint && histereseStatus == 2){
            histereseStatus = 0;
        }
    }else{
        histereseStatus = 0; 
    }        
    digitalWrite(PIN_RESISTENCE, resistenceStatus && !fail);
}

/**
 * @brief Furnace controller task
 * 
 */
void Furnace::task(){
    updateInputs();
    updateOutputs();
}