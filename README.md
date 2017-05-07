# Rocket Monitor

A small application for changing the resolution in the .ini file for Rocket League.

This enables two or more people to play Rocket League in local co-op on seperate monitors.  
Then we avoid the dreaded splitscreen scenarios.

## How to download

Latest release is contained in the .7z file under 'Releases'.

## How to compile it

You need to have the Microsoft .NET Core Framework installed.

### Steps

From the solution directory:

`\Rocket-Monitor\RLM`

Run the commands:

```
$ dotnet restore
```
```
$ dotnet build
```

Then to create an windows 10 .exe file, run:

```
$ dotnet publish -c Release -r win10-x64
```

This will create a folder:

`\Rocket-Monitor\RLM\RocketMonitor.Console\bin\Release\netcoreapp1.1\win10-x64`

Where the .exe file is located.
