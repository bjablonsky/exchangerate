# Exchange Rate

A small Blazor web app for accessing an exchange rate api

## Prerequisites
- Visual Studio 2022 Preview 2
- .NET 6 Preview 6

## Building
To build the project, run the following commands:
```
dotnet build .\src\ExchangeRate.sln
```

## Usage
To run the project, run the following commands:
```
dotnet run --project .\src\ExchangeRate.Web\Server\
```

Then, open a browser and navigate to https://localhost:5001

## Deployment
To deploy the project, run the following commands:
```
dotnet publish -o C:\PATH\TO\OUTPUT .\src\ExchangeRate.sln
```
