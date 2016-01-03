#Updates
- Use temporary folder when compiling .bat wrapper to allow use from inside write protected folder
- Remove "any key" to exit after .bat runs

#Original readme

BatToExe – Readme.txt – http://softwarebydefault.com
Thank you for downloading BatToExe! This application is entirely open source and free of charge. 
BatToExe is released under the Microsoft Public License (Ms-PL).

The aim of this application is to convert batch files (*.bat) to executable files. 
To get you started copy the following text then paste into a blank text file. 
After saving rename the text file’s extension to .bat:

@echo off  
"%SystemRoot%\System32\ipconfig.exe" /all  
@pause  

Specify your newly created *.bat file as an input batch file to BatToExe.exe, 
then specify a file name and location for the executable file that will be generated. 
If all goes well you should end up with an executable file that performs the exact same function as the original *.bat file.

BatToExe is hosted at http://softwarebydefault.com, the primary online resource for updates, comments or questions.
Please follow me on twitter: @DefaultSoftware
Thank you -- Dewald Esterhuizen -- 2013
