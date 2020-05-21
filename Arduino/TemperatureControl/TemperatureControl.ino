/**
 * @file TemperatureControl.ino
 * @author Wesley José Santos (https://binary-quantum.com)
 * @brief Arduino code example to work with TemperatureControl.exe
 * Repo of visual studio application: https://github.com/WesleyJoseSantos/TemperatureControl
 * @version 0.1
 * @date 2020-05-19
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#include "BqBus.h"
#include "BqBusRegs.h"
#include "Furnace.h"

BqBus bqBus(BqBusRegs::getSize());        //Instance to share registers with pcApp application
BqBusRegs pcApp(&bqBus);                  //Instance to handle bqBus registers of pcApp (Temperature Control.exe)
Furnace furnace;                          //Instance to control furnace

void setup() {
    Serial.begin(9600);                           //Initialize serial port
    bqBus.setBus(&Serial);                        //Set serial port used to communicate with pcApp application
    pinMode(PIN_RESISTENCE, OUTPUT);              //Configure output to control furnace resistence
    pinMode(PIN_FAIL, INPUT);                     //Configure input to detect general failures on system
    pinMode(PIN_TEMP_SENS, INPUT);                //Configure input to read temperature sensor
}

void loop() {
    bqBus.communicationTask();                                   //Performs communication betteen arduino and pcApp application
    
    furnace.setAutomatic(pcApp.getAutomaticToggle());            //Set furnace automatic parameter from automatic toggle interface control
    furnace.setSetPoint(pcApp.getParameterSetPoint());           //Set furnace set-point parameter from set-point text box interface control
    furnace.setHisteresis(pcApp.getParameterHisteresis());       //Set histeresis parameter from histeresis text box interface control
    furnace.setResistenceStatus(pcApp.getFurnaceToggle());       //Set resistence status parameter from furnace toggle interface control

    pcApp.setFurnaceStatus(furnace.getStatus());                 //Set furnace status interface control from furnace status property
    pcApp.setFurnaceTemperature(furnace.getTemperature());       //Set furnace temperature indicator control from furnace temperature property

    furnace.task();                                              //Furnace controller task
}