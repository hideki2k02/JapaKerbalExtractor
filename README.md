# JapaKerbalExtractor

## Needs [.NET Core 5.0](https://dotnet.microsoft.com/download)
## Program uses [Aspose.Zip](https://www.nuget.org/packages/Aspose.ZIP/)

A Kerbal Space Program Mod Extraction Tool for lazy people

Since for some reason CurseForge does not install mods properly, i decided to make a (probably) temporary script so i can install multiple mods while being lazy

Fun Fact: I annoyed some people, but the whole code under 69 lines (Commentaries and New Lines are counted on this)

## How to use

- Install [.NET Core 5.0](https://dotnet.microsoft.com/download) if its not installed

- Download the pre-built program on the [Releases page](https://github.com/japa4551/JapaKerbalExtractor/releases) (You can also build it yourself if you want to, in case there is no version for your current system)

- The program will attempt to extract **all the files in the same folder as the EXE** with the extension you inputted (tested on RAR and ZIP)

- If it succeeds it will extract the content to a new folder called Output (will be rename in case one already exists)

- In case some of the mods came as "GameData/Mod Folder" instead of just "Mod Folder", the program will fix that for you

- **DONT FORGET TO CHECK FOR ANY EXTRA FILES, you dont need multiple ModuleManager DLLs!**
