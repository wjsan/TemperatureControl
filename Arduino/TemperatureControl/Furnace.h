/**
 * @file Furnace.h
 * @author your name (you@domain.com)
 * @brief 
 * @version 0.1
 * @date 2020-05-21
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#ifndef __FURNACE__H__
#define __FURNACE__H__

#include <Arduino.h>

#define PIN_RESISTENCE 2
#define PIN_FAIL 3
#define PIN_TEMP_SENS A0

/**
 * @brief Furnace controller class
 * 
 */
class Furnace{
private:

    /**
     * @brief Enumeration of furnace possible status
     */
    enum FurnaceStatus
    {
        TurnedOff,        //Furnace is on
        TurnedOn,         //Furnace is off
        Fail              //Furnace general fail
    };

    FurnaceStatus status;       //Status of furnace
    bool automatic;             //Status of automatic control
    bool fail;                  //Status of furnace fail
    bool resistenceStatus;      //Status of resistence
    int temp;                   //Current temperature value
    int setPoint;               //Set-point parameter value
    int histeresis;             //Histeresis parameter value

    void updateInputs();        //Update inputs variables of controller
    void updateOutputs();       //Process inputs and update outputs variables of controller

public:
    Furnace();                                             //Default contructor
    int getTemperature();                                  //Get current furnace temperature
    int getStatus();                                       //Get furnace status
    void setAutomatic(bool automatic);                     //Set automatic status
    void setSetPoint(int setPoint);                        //Set set-point parameter
    void setHisteresis(int histeresis);                    //Set histeresis parameter
    void setResistenceStatus(bool resistenceStatus);       //Set resistence status if automatic is off
    void task();                                           //Furnace controller task 
};

#endif  //!__FURNACE__H__
