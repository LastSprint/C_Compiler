@echo off

%~d0
cd "%~dp0"

if "%1"=="" (
  echo Usage %~nx0 ^<filename^>
  exit
)

::set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v3.5
set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727
::set NETSDK_HOME=C:\Program Files\Microsoft Visual Studio 8\SDK\v2.0
set NETSDK_HOME=C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A


set CSC="%NET_HOME%\csc"
set ILASM="%NET_HOME%\ilasm"
set ILDASM="%NETSDK_HOME%\bin\ildasm"



set FILENAME=%~n1

del .\%FILENAME%.exe .\%FILENAME%.ilasm.exe .\%FILENAME%.res .\%FILENAME%.pdb .\%FILENAME%.ilasm .\%FILENAME%.ilasm.html

%CSC% /optimize+ /debug+ /out:%FILENAME%.exe %FILENAME%.cs
%ILDASM% /text /output=%FILENAME%.ilasm %FILENAME%.exe
%ILDASM% /text /html /source /output=%FILENAME%.ilasm.html %FILENAME%.exe
%ILASM% /output:%FILENAME%.ilasm.exe %FILENAME%.ilasm

del .\%FILENAME%.res .\%FILENAME%.ilasm.res .\%FILENAME%.pdb
