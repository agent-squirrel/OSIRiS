@ECHO OFF
@title  Setup Display

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

cls
REM #########################################################################
REM                       New Machine Setup Script
REM                             Adam Heathcote
REM This script CANNOT be run manually! It expects arguments, either fed from
REM the command line or from the OSIRiS master control program.
REM Running it manually will likely result in a broken system.
REM 			    	             YOU HAVE BEEN WARNED.
REM #########################################################################

:: Check if this script is being run from OSIRiS master control program
:: or manually. If it's being run manually (incorrectly) then quit.
IF %3.==. (GOTO MANUALRUN) ELSE (GOTO OSDECIDE)

:MANUALRUN
echo This script CANNOT be run manually. Please start OSIRiS.exe instead.
pause>nul
explorer %~d0
exit

:OSDECIDE
:: Set the OSVER variable to the Operating System version so we can run different
:: scripts dependent on if we are running on 8.1 or 10.
echo Finding OS Version
systeminfo | find "OS Name" > osname.txt
FOR /F "usebackq delims=: tokens=2" %%i IN (osname.txt) DO set OSTEMP=%%i
echo.%OSTEMP%|findstr /c "10" >nul 2>&1 && set "OSVAR=Windows 10" || set "OSVAR=Windows 8"
del osname.txt
echo Calling %OSVAR% Script
if "%OSVAR%"=="Windows 10" call "%~dp0setup10.bat" %1 %2 %3 %4
if "%OSVAR%"=="Windows 8" call "%~dp0setup8.bat" %1 %2 %3 %4
