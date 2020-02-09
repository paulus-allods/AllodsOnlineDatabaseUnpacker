# AllodsOnlineDatabaseUnpacker

## Requirements

The following prerequisite software must be installed on your machine first :
- .NET Framework 4.7.2 : https://dotnet.microsoft.com/download/dotnet-framework/net472

You'll also need 1.1.02.0 Helper archive in further steps : https://community.allods-developers.eu/resources/v1-helper-folder.24/

## Build

- Install NuGet packages described in `packages.config`
- Add `libdb_cs.dll` from Helper Archive to `Database` project dependencies (it should be already mentionned but with an unresolved path, just change the path to target yours)
- Build

## Setup

Once you've build the software you should have the following build folder
```
.
+-- AllodsOnlineDatabaseUnpacker.exe
+-- AllodsOnlineDatabaseUnpacker.pdb
+-- Database.dll
+-- Database.pdb
+-- libdb_cs.dll
+-- Microsoft.Extensions.CommandLineUtils.dll
+-- Microsoft.Extensions.CommandLineUtils.xml
+-- NLog.config
+-- NLog.dll
+-- NLog.xml
```

In order to get the unopacker work you need to grab all the `Release_bin` folder from Helper Archive and move it into the same folder as your build files.

Then create a `data` folder containing :
- `data\Types` folder from Allods 1.1.02.0 server files
- extracted `data\Packs\Bin.pak` from Allods 1.1.02.0 client
- `data\System\index.bin` from Allods 1.1.02.0 server files

You should have the following architecture: 

```
.
+-- data
|   +-- Bin
|   |   +-- Maps_2ndCircle.bin
|   |   +-- Maps_2ndCircle_AC1.bin
|   |   +-- ...
|   |   +-- pack.bin
|   +-- System
|   |   +-- index.bin
|   +-- Types
|   |   +-- Classes
|   |   |   +-- client
|   |   |   |   +-- ...
|   |   |   +-- ServerTest
|   |   |   |   +-- ...
|   |   |   +-- Tools
|   |   |   |   +-- ...
|   |   +-- annotatedTypes.xml
|   |   +-- customTypes.xml
|   |   +-- types.xml
+-- AllodsOnlineDatabaseUnpacker.exe
+-- AllodsOnlineDatabaseUnpacker.pdb
+-- Database.dll
+-- Database.pdb
+-- libdb_cs.dll
+-- Microsoft.Extensions.CommandLineUtils.dll
+-- Microsoft.Extensions.CommandLineUtils.xml
+-- NLog.config
+-- NLog.dll
+-- NLog.xml
+-- Animation.dll
+-- AOGame.exe
+-- All files from Release_bin from Helper Archive ...
```

## Run

To extract all available files run 

```cmd
AllodsDatabaseUnpacker.exe
```

By default, it will use the `data` folder and export to `export` folder.

You can change default paths and use other options. To see all available options, use: 

```cmd
AllodsDatabaseUnpacker.exe --help
```

## Notes

This software is still in developpement and extracted files are still not 100% accurate. Some files are also missing for interface and maps.