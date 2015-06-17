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

:TZLOOP
:: Take user input argument %3 and then set the time
:: zone based upon this argument.
:: (This whole section is super badly written and very 'Use a Mallet' rather
:: than 'With a scalpel.')
echo Setting the TimeZone
if /I %3==WA (tzutil /s "W. Australia Standard Time" 1>NUL) ELSE (GOTO NT)
GOTO :BREAKLOOP
:NT
if /I %3==NT (tzutil /s "AUS Central Standard Time" 1>NUL) ELSE (GOTO SA)
GOTO :BREAKLOOP
:SA
if /I %3==SA (tzutil /s "Cen. Australia Standard Time" 1>NUL) ELSE (GOTO QLD)
GOTO :BREAKLOOP
:QLD
if /I %3==QLD (tzutil /s "E. Australia Standard Time" 1>NUL) ELSE (GOTO NSW)
GOTO :BREAKLOOP
:NSW
if /I %3==NSW (tzutil /s "AUS Eastern Standard Time" 1>NUL) ELSE (GOTO VIC)
GOTO :BREAKLOOP
:VIC
if /I %3==VIC (tzutil /s "AUS Eastern Standard Time" 1>NUL) ELSE (GOTO TAS)
GOTO :BREAKLOOP
:TAS
if /I %3==TAS (tzutil /s "Tasmania Standard Time" 1>NUL) ELSE (GOTO ACT)
GOTO :BREAKLOOP
:ACT
if /I %3==ACT (tzutil /s "AUS Eastern Standard Time" 1>NUL)

:BREAKLOOP


:: Set the time from the first argument passed.
@title  Setting Time
time %1 > NUL 2>&1
echo Setting the Time



REM ################################################################
REM #Rename the computer to the machine OEM model extracted from
REM #Firmware with WMIC.
REM ################################################################
@title  Renaming Machine
echo Renaming the Computer

:: Dump the contents of the 'Model' column to a text file from the WMIC COMPUTERSYSTEM command.
wmic computersystem get model > tempmodel.txt

:: Because the 'GET' command tends to dump the column name as well as the content, strip the name from the top of the file.
:: Dump the new data to a different file otherwise the encoding gets mangled.
type tempmodel.txt | findstr /v Model > compmodel.txt

:: The computer name cannot contain spaces so we use powershell to run through the file identifying all spaces and remove them.
powershell "$Host.UI.RawUI.WindowTitle = 'Doing Powershell Stuff'; (Get-Content compmodel.txt) | Foreach-Object {$_ -replace ' ', ''} | Set-Content compmodel.txt" > NUL 2>&1

:: Run a loop through the text file created earlier and load the model name into a variable (%G).
:: Set the variable %G as the computer name.
FOR /F "tokens=* delims=" %%G in (compmodel.txt) DO wmic computersystem where name="%COMPUTERNAME%" call rename name= %%G > NUL 2>&1

:: Delete the two text files.
DEL compmodel.txt > NUL 2>&1
DEL tempmodel.txt > NUL 2>&1

REM ################################################################
REM #Remove all current user accounts except Administrator, Guest
REM #and HomeGroupUser$.
REM #Create an Officeworks Administrator User and set it's password
REM #to happy456 with no Expiry.
REM ################################################################
@title  Creating and Deleting Accounts
echo Creating the Officeworks User

:: Dump all user account names to a text file.
wmic useraccount get name > userlist.txt

:: Trim the white space from the start and end of User Account strings.
powershell "$Host.UI.RawUI.WindowTitle = 'Doing Powershell Stuff'; $content = Get-Content .\userlist.txt"; "$content | Foreach {$_.TrimEnd()} | Set-Content .\userlist.txt" > NUL 2>&1

:: Remove various junk lines from the text file.
type userlist.txt | findstr /v Name | findstr /v Administrator | findstr /v Guest | findstr /v HomeGroup > userlisttrimmed.txt

:: Loop through the text file and delete each user account listed.
FOR /F "tokens=* delims=*" %%G in (userlisttrimmed.txt) DO net user /delete "%%G" 1>NUL

:: Create the new 'Admin Account' user.
net user Officeworks "%4" /add > NUL 2>&1

:: Add 'Admin Account' to the Administrators group.
net localgroup Administrators Officeworks /add > NUL 2>&1

:: Disable the default password expiry to prevent having to change the password every 30 days.
WMIC USERACCOUNT WHERE "Name='Officeworks'" SET PasswordExpires=FALSE > NUL 2>&1

REM ############################################################
REM #Configure a standard user account for customer use called
REM #'Customer' with no password and no password expiry.
REM ############################################################

echo Configuring Standard User

:: Create the new standard user.
net user /add Customer > NUL 2>&1

:: Disable the default password expiry to prevent having to change the password every 30 days.
WMIC USERACCOUNT WHERE "Name='Customer'" SET PasswordExpires=FALSE > NUL 2>&1

:: Delete the two text files.
DEL userlist.txt > NUL 2>&1
DEL userlisttrimmed.txt > NUL 2>&1


REM #######################################################################
REM #Set the high performance plan as the default and rename it
REM #"Officeworks".
REM #Reconfigure the plan's defaults to make sure the machine never sleeps.
REM #######################################################################
@title  Setting Up the Power Settings

echo Configuring Power Settings

POWERCFG -SETACTIVE 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c 2>&1
POWERCFG -CHANGENAME 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c "Officeworks" 2>&1
:: This disables the lid close action.
POWERCFG -SETACVALUEINDEX 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c 4f971e89-eebd-4455-a8de-9e59040e7347 5ca83367-6e45-459f-a27b-476b1d01c936 000 2>&1
:: Switch off timeouts for all AC DC states.
POWERCFG -change -monitor-timeout-ac 0 2>&1
POWERCFG -change -monitor-timeout-dc 0 2>&1
POWERCFG -change -standby-timeout-ac 0 2>&1
POWERCFG -change -standby-timeout-dc 0 2>&1
POWERCFG -change -hibernate-timeout-ac 0 2>&1
POWERCFG -change -hibernate-timeout-dc 0 2>&1

REM ####################################################
REM #Switch off Windows Update and set it's service to
REM #not auto-start on boot.
REM ####################################################
@title  Nuking Windows Update
echo Disabling Windows Updates

reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v AUOptions /t REG_DWORD /d 1 /f > NUL 2>&1
net stop wuauserv > NUL 2>&1
sc config wuauserv start= disabled > NUL 2>&1

REM ###################################################
REM #Create a directory on C: called profiles and copy
REM #the Extensible Markup Language file containing
REM #wireless configuration data to it.
REM #Connect the wireless radio to the Officeworks WLAN.
REM #Create a scheduled reset of the wireless radio on
REM #every boot in order to clear Airplane Mode.
REM ###################################################
@title  Setting Up the Wireless Network
echo Configuring Wireless Network

mkdir C:\profiles > NUL 2>&1
copy %~dp0\OFW-Display.xml C:\profiles\OFW-Display.xml > NUL 2>&1
Netsh wlan add profile filename="C:\profiles\OFW-Display.xml" > NUL 2>&1
Netsh wlan connect OFW-Display > NUL 2>&1

:: This task resets the Wireless adapter on every boot of the machine.
:: This is a heavy handed way of switching off airplane mode but it also ensures the adapter is in a known state at each boot.
SCHTASKS /create /F /tn "Wi-Fi Check" /tr "powershell 'get-netadapter wi-fi | restart-netadapter'" /sc onstart /RL HIGHEST /RU "SYSTEM" > NUL 2>&1

REM ######################################################################################
REM #Create a scheduled task to shutdown the machine based upon the argument %2
REM #every night, force killing any running software.
REM #This can be overridden if need be with "shutdown /a" or the shortcut on the Desktop.
REM ######################################################################################
@title  Setting Up Auto Shutdown

echo Configuring Auto Shutdown

SCHTASKS /Create /F /RU "SYSTEM" /RL "HIGHEST" /SC "DAILY" /TN "Computer Shutdown" /TR "shutdown -s -t 60 -c 'Officeworks Auto-Shutdown In Effect.' -f" /ST "%2" > NUL 2>&1


echo Adding a shutdown suppresor to the Desktop
echo shutdown -a > C:\profiles\"Cancel Auto-Shutdown.bat"
echo exit >> C:\profiles\"Cancel Auto-Shutdown.bat"
copy %~dp0\"Cancel Auto-Shutdown.lnk" C:\Users\Public\Desktop\ > NUL 2>&1

REM #########################################################
REM #Modifying the wallpaper for the Customer user requires a
REM #multi-step approach.
REM #########################################################

echo Setting up custom wallpaper

::Here we dump the contents of WMIC CPU to a text file and copy over
::BGInfo to the profiles folder.
::Also copy over the powershell script that runs on every login.

wmic cpu get name > cpu.txt
xcopy /S /I %~dp0\setup_payload\BGInfo\* C:\profiles\BGInfo > NUL 2>&1
copy %~dp0\setup_payload\wall.ps1 C:\profiles\wall.ps1 > NUL 2>&1


::Use 'find' to look through the cpu.txt file and check for specific
::strings containing CPU information.
::Copy a specific wallpaper over to the local disk based upon the CPU
::discovered inside cpu.txt.

REM ############### BEGIN PROCESSOR CHECK CODE BLOCK ##########################

REM ##INTEL BLOCK##
find /I "i5" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\i5.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO i3)  > NUL 2>&1
GOTO ENDPROC
:i3
find /I "i3" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\i3.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO i7)  > NUL 2>&1
GOTO ENDPROC
:i7
find /I "i7" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\i7.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO pent)  > NUL 2>&1
GOTO ENDPROC
:pent
find /I "pentium" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\pentium.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO cel)  > NUL 2>&1
GOTO ENDPROC
:cel
find /I "celeron" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\celeron.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO atom)  > NUL 2>&1
GOTO ENDPROC
:atom
find /I "atom" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\atom.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO corem)  > NUL 2>&1
GOTO ENDPROC
:corem
find /I "5y" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\corem.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO e2)  > NUL 2>&1
GOTO ENDPROC
REM ##END INTEL##

REM ##AMD BLOCK##
:e2
find /I "e2" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\e2.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO a4)  > NUL 2>&1
GOTO ENDPROC
:a4
find /I "a4" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\a4.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO a6)  > NUL 2>&1
GOTO ENDPROC
:a6
find /I "a6" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\a6.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO a8)  > NUL 2>&1
GOTO ENDPROC
:a8
find /I "a8" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\a8.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO a10)  > NUL 2>&1
GOTO ENDPROC
:a10
find /I "a10" cpu.txt  > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\a10.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO fx)  > NUL 2>&1
GOTO ENDPROC
:fx
find /I "fx" cpu.txt > NUL 2>&1
if %errorlevel%==0 (copy %~dp0\setup_payload\fx.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO unknown)  > NUL 2>&1
GOTO ENDPROC
REM ##END AMD##

:unknown
copy %~dp0\setup_payload\generic.bmp C:\profiles\wallpaper.bmp > NUL 2>&1

REM ################ END PROCESSOR CHECK CODE BLOCK ###########################
:ENDPROC

::Create a scheduled task to set the wallpaper back to our custom one on every login.
schtasks /CREATE /F /TN "Set Wallpaper" /TR "powershell.exe -executionpolicy Bypass -windowstyle minimized -file C:\profiles\wall.ps1" /SC ONLOGON /RU Customer > NUL 2>&1

::Delete the cpu.txt file.
del cpu.txt

REM #######################################################
REM #Here we verify that the various sections of OSIRiS
REM #have run correctly. This ensures that no weirdness
REM #happens, such as having no Admin account.
REM #######################################################
@title Verifying Successful Run

echo Pinging Localhost for 10 seconds before verification

PING 127.0.0.1 -n 10 >NUL 2>&1 || PING ::1 -n 10 >NUL 2>&1


echo Beginning Verification

net user | find /i "Officeworks" 1>NUL || Net user Officeworks %4 /add > NUL 2>&1
WMIC USERACCOUNT WHERE "Name='Officeworks'" SET PasswordExpires=FALSE > NUL 2>&1
net localgroup Administrators Officeworks /add > NUL 2>&1
net user | find /i "Customer" 1>NUL || Net user Customer /add > NUL 2>&1
WMIC USERACCOUNT WHERE "Name='Customer'" SET PasswordExpires=FALSE > NUL 2>&1
SCHTASKS /query /TN "Computer Shutdown" > NUL 2>&1
if NOT %errorlevel%==0 (
SCHTASKS /Create /F /RU "SYSTEM" /RL "HIGHEST" /SC "DAILY" /TN "Computer Shutdown" /TR "shutdown -s -t 60 -c 'Officeworks Auto-Shutdown In Effect.' -f" /ST "%2" > NUL 2>&1
)
SCHTASKS /query /TN "Wi-Fi Check" > NUL 2>&1
if NOT %errorlevel%==0 (
SCHTASKS /create /F /tn "Wi-Fi Check" /tr "powershell 'get-netadapter wi-fi | restart-netadapter'" /sc onstart /RL HIGHEST /RU "SYSTEM" > NUL 2>&1
)

echo Verification Complete


@title  Restarting
echo Restarting

shutdown -r -t 5 /c "Rebooting to complete setup."
exit
