# Temperature Control

Temperature Control is an SCADA Open Source application to monitor and control a temperature control system.

## Table of contents 

- [Features](#features)
- [Quickstart](#quickstart)
- [ScreenShot](#screenshot)

## Features

* Automatic and Manual operation
* Set-Point, Alarm-High, Alarm-Low and Histeresis parameters
* Auto save parameters on exit
* Real-Time high speed monitorament
* Alarms Table with Save options
* Serial Communication Bettweem Device and Software
* Multilingual suport (English, Portuguese)
* Modern Beautiful Design

## Quickstart

* Open [Arduino Sketch](https://github.com/WesleyJoseSantos/TemperatureControl/blob/master/Arduino/TemperatureControl)
* Change [Hardware Settings](https://github.com/WesleyJoseSantos/TemperatureControl/blob/master/Arduino/TemperatureControl/Furnace.h)

```C++
#define PIN_RESISTENCE 2        //Output to control resistence furnace actuator
#define PIN_FAIL 3              //Output to detect general system failure
#define PIN_TEMP_SENS A0        //Input to read teperature sensor (0-5V)
```
* Upload Sketch to Arduino Board
* Open and run [Visual Studio Solution](https://github.com/WesleyJoseSantos/TemperatureControl)
* Enjoy!

## ScreenShot

<p align="center">
  <a href="https://binquantum.wordpress.com/" target="_blank">
    <img src="https://binaryquantum.files.wordpress.com/2020/05/temperaturecontrolsnapshot.png" alt="Temperature Control"></img>
  </a>
</p>