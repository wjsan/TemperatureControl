/**
 * @file BqBusRegs.h
 * @author your name (you@domain.com)
 * @brief 
 * @version 0.1
 * @date 2020-05-21
 * 
 * @copyright Copyright (c) 2020
 * 
 */

#ifndef __BQBUSREGS__H__
#define __BQBUSREGS__H__

#include "BqBus.h"

/**
 * @brief Registers handler
 * 
 */
class BqBusRegs{
private:

    /**
     * @brief Registers address map
     */
    enum Regs{
        AutomaticControl,          //Register Address for Auto/Manual Control Toggle
        FurnaceControl,            //Register Address for Furnace Control Toggle
        ParameterSetPoint,         //Register Address for Set-Point Parameter
        ParameterHisteresis,       //Register Address for Histeresis Parameter
        FurnaceStatus,             //Register Address for Furnace Control Status
        FurnaceTemperature,        //Register Address for Furnace Temperature
        LastRegister,              //Last register address used to get registers count
    };

    BqBus *bqBus;                  //Pointer to BqBus instance of handled registers

public:
    BqBusRegs(BqBus *bqBus){ this->bqBus = bqBus; }                                                             //Initialize BqBusRegs Handler
    bool getAutomaticToggle(){ return bqBus->getReg(Regs::AutomaticControl); }                                  //Get automatic toggle value
    bool getFurnaceToggle(){ return bqBus->getReg(Regs::FurnaceControl); }                                      //Get furnace toggle
    int getParameterSetPoint() { return bqBus->getReg(Regs::ParameterSetPoint); }                               //Get set-point textbox parameter value
    int getParameterHisteresis() { return bqBus->getReg(Regs::ParameterHisteresis); }                           //Get histeresis textbox parameter value
    void setFurnaceStatus(int status) { bqBus->setReg(Regs::FurnaceStatus, status); }                           //Set furnace status indicator value
    void setFurnaceTemperature(int tempereture) { bqBus->setReg(Regs::FurnaceTemperature, tempereture); }       //Set furnace temperature indicator value
    static int getSize(){ return LastRegister; }                                                                //Get registers map size
};

#endif  //!__BQBUSREGS__H__
