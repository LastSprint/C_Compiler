@echo off

%~d0
cd "%~dp0"

rem set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v3.5
set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727
set ILASM="%NET_HOME%\ilasm"
set FILENAME=%~n1

start CompilerConsole "input.txt"
pause;

%ILASM% cil
pause
start cil

