# NOAA Weather Dashboard

Welcome to the NOAA Weather Dashboard! This application is built using Blazor Server and provides an interactive interface for displaying weather data from various NOAA (National Oceanic and Atmospheric Administration) APIs.


## Introduction

The NOAA Weather Dashboard is designed to provide users with real-time weather data and insights using NOAA's extensive range of weather APIs. This Blazor web application aims to offer an intuitive and responsive interface for accessing weather information, including forecasts, alerts, and historical data.
Features

    Real-time Weather Data: Fetch and display current weather conditions and forecasts.
    Weather Alerts: Receive and display weather alerts and warnings.
    Historical Data: Access and visualize historical weather data.
    Interactive Maps: View weather patterns on interactive maps.
    

## Installation:
Install additional nuget packages
Install SQL Server
run: 
    dotnet ef migrations add InitialCreate
    dotnet ef database update

    If you have multiple DbContext
    dotnet ef migrations add 'migration_name' --context 'context_name' -o Migrations/'folder_name'
    dotnet ef database update --context 'context_name'


## Usage
Sample text.


## TODO
    1. Integrating NOAA-APT (Automatic Picture Transmission demodulator in C) into .Net webapp 

    2. Add error handling for the various api endpoint return codes 


## License

This project is licensed under the GPLv3 License. See the LICENSE file for more details.
