# TuyaNET [![Build and pack](https://github.com/RubenPX/TuyaNET/actions/workflows/main.yml/badge.svg?branch=master)](https://github.com/RubenPX/TuyaNET/actions/workflows/main.yml)

TuyaNET is a .NET library designed to interact with the Tuya API.

## Features

| Service Name | Package ID | Nuget |
| ------------ | ---------- | ----- | 
| [Authorization Token Management](./RubenPX.TuyaNet.API/) | `RubenPX.TuyaNet.API` | [![NugetPackage](https://img.shields.io/nuget/v/RubenPX.TuyaNet.API)](https://www.nuget.org/packages/RubenPX.TuyaNet.API/) | 
| [Smart Home Basic Service](./RubenPX.TuyaNET.Home/) | `RubenPX.TuyaNET.Home` | [![NugetPackage](https://img.shields.io/nuget/v/RubenPX.TuyaNET.Home)](https://www.nuget.org/packages/RubenPX.TuyaNet.Home/) | 

## Configuration

To use the TuyaNET library, you need to provide your Tuya API credentials. You can obtain these credentials by creating
an account on the [Tuya IoT Platform](https://iot.tuya.com/) and creating a new project.

## Target to complete this project

- [X] [Authorization Token Management](https://developer.tuya.com/en/docs/cloud/authorization-management?id=Kaiuy9cjp8kr2)
  - [X] [Refresh Token](https://developer.tuya.com/en/docs/cloud/80bb968f1d?id=Ka7kjv3j8jgvr)
  - [X] [Get a Token](https://developer.tuya.com/en/docs/cloud/6c1636a9bd?id=Ka7kjumkoa53v)
- [ ] [IoT Core](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761)
  - [ ] [Space Management](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-0-Space%20Management)
  - [ ] [Device Management](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-1-Device%20Management)
  - [ ] [Device Control](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-2-Device%20Control)
  - [ ] [Scene Linkage Rules](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-3-Scene%20Linkage%20Rules)
  - [ ] [Device Control (Standard Instruction Set)](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-4-Device%20Control(Standard%20Instruction%20Set))
  - [ ] [Device Group](https://developer.tuya.com/en/docs/cloud/device-connection-service?id=Kb0b8geg6o761#title-5-Device%20Group)
- [ ] [Smart Home Basic Service](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be)
  - [ ] [Home Management](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-0-Home%20Management) (In Progress)
  - [ ] [Smart Home User Management](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-1-Smart%20Home%20User%20Management)
  - [ ] [Smart Home Application Management](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-2-Smart%20Home%20Application%20Management)
  - [ ] [Smart Home Network Management](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-3-Smart%20Home%20Network%20Management)
  - [ ] [Smart Home Device Management](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-4-Smart%20Home%20Device%20Management)
  - [ ] [Smart Home Device Control](https://developer.tuya.com/en/docs/cloud/smart-home-basic-service?id=Kconis1yii4be#title-5-Smart%20Home%20Device%20Control)

## Contributing

Contributions are welcome! Please open an issue or submit a pull request with any improvements or bug fixes.

## Acknowledgements

- [Tuya IoT Platform](https://iot.tuya.com/) for providing the API
