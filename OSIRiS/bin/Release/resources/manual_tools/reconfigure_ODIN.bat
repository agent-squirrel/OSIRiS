@ECHO OFF
@title ODIN Reconfiguration

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

echo Checking for ADMIN rights and escalating as required.
:::::::::::::::::::::::::::::::::::::::::
:: Automatically check & get admin rights
:::::::::::::::::::::::::::::::::::::::::
@echo off
CLS
ECHO.
ECHO ================================
ECHO      ADMIN MODE ESCALATION
ECHO You do not appear to be an Admin
ECHO       with system rights.
ECHO ================================

:checkPrivileges
NET FILE 1>NUL 2>NUL
if '%errorlevel%' == '0' ( goto gotPrivileges ) else ( goto getPrivileges )

:getPrivileges
if '%1'=='ELEV' (shift & goto gotPrivileges)
ECHO.
ECHO **************************************
ECHO Invoking UAC for Privilege Escalation
ECHO       Press ENTER to continue
ECHO **************************************

PAUSE > NUL

setlocal DisableDelayedExpansion
set "batchPath=%~0"
setlocal EnableDelayedExpansion
ECHO Set UAC = CreateObject^("Shell.Application"^) > "%temp%\OEgetPrivileges.vbs"
ECHO UAC.ShellExecute "!batchPath!", "ELEV", "", "runas", 1 >> "%temp%\OEgetPrivileges.vbs"
"%temp%\OEgetPrivileges.vbs"
exit /B

:gotPrivileges
::::::::::::::::::::::::::::
::START
::::::::::::::::::::::::::::
setlocal & pushd .

:MENU
mode con: cols=73 lines=30
cls
echo #########################################################################
echo                       ODIN Reconfiguration Script
echo                            Adam Heathcote
echo -------------------------------------------------------------------------
echo.
echo This script is intended for use on display computers that have had ODIN
echo incorrectly configured or need to be switched to reg mode from schtasks
echo mode.
echo.
echo #########################################################################

echo.
echo.

ECHO ======================= What would you like to do? ======================
ECHO 1. Switch ODIN to reg mode.
ECHO 2. Toggle ON/OFF clearance mode.
ECHO ============================PRESS 'Q' TO QUIT============================
ECHO.

SET INPUT=
SET /P INPUT=Please select a number:
IF /I '%INPUT%'=='1' GOTO Selection1
IF /I '%INPUT%'=='2' GOTO Selection2
IF /I '%INPUT%'=='Q' EXIT

CLS
ECHO.
ECHO ====================================================================
ECHO "A keyboard. How quaint." - Montgomery Scott USS Enterprise NCC-1701
ECHO ====================================================================
ECHO.
ECHO.
ECHO Whatever you just pressed probably wasn't between 1 and 2.
ECHO -------------------------------------
ECHO Please select a number from the Main Menu
ECHO  [1-2] or select 'Q' to quit.
ECHO -------------------------------------
ECHO.
ECHO Press enter to have another go.

PAUSE > NUL
GOTO MENU


:Selection1

schtasks /query /TN "Start ODIN"
if %errorlevel%==0 (schtasks /delete /TN "Start ODIN") ELSE (GOTO CREATE)

:CREATE

REG ADD HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN /t REG_SZ /d \"C:\profiles\ODIN\" /f

CLS

echo.
echo.
echo Done! Press enter to return to the menu.

pause > nul
goto MENU

:Selection2

REG QUERY HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN
if %errorLevel%==1 GOTO REGMISSING

REG QUERY HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN > %TEMP%\ODINREG
find /I "clear" %TEMP%\ODINREG
if %errorLevel% NEQ 0 GOTO SETCLEAR
REG DELETE HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN /f
REG ADD HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN /t REG_SZ /d \"C:\profiles\ODIN.exe\" /f
CLS

echo.
echo.
echo Done! Press enter to return to the menu.

pause > nul
GOTO MENU

:SETCLEAR
REG DELETE HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN /f
REG ADD HKLM\Software\Microsoft\Windows\CurrentVersion\Run /v ODIN /t REG_SZ /d "\"C:\profiles\ODIN.exe\" clear" /f
CLS

echo.
echo.
echo Done! Press enter to return to the menu.

pause > nul
goto MENU



:REGMISSING
cls
echo.
echo.
echo ODIN is either missing or is in Scheduled mode, please change
echo ODIN to reg mode first. Press enter to continue.

pause > nul
goto MENU
