# Doctor's Office

#### Track patients and the doctors they see, 1.5.2021

#### By Ben McFarland, Patrick Osten

## Description

This program will track all patients and Doctors. You will be able to add patients to a doctor, doctor to a patient, see all patients and associated doctors, an remove doctors and patients.

## Technologies used

* Microsoft Visual Studio Code
* Git/GitHub
* C# v 7.3
* .NET Core v 2.2
* REPL
* MSTest
* ASP.NET MVC

## Installation Requirements

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/POsten040/Doctor_Office], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/POsten040/Doctor_Office`.


#### Installing C#, .NET, dotnet script, & MySQL

###### This program requires C# and the .NET Framework to be installed on your machine:

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download this 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 

## SQL Diagram

![alt text](./Doctor_Office/wwwroot/assets/sqlChart.png)

## Bugs / Issues

No known bugs or issues

### License & Copyright

_MIT_ Copyright (c) 2021 *_Ben McFarland, Patrick Osten_*