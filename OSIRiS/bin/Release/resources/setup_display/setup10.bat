@ECHO OFF

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2016.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

cls
REM #########################################################################
REM                  New Machine Setup Script for Windows 10
REM                             Adam Heathcote
REM This script CANNOT be run manually! It expects arguments, either fed from
REM the command line or from the OSIRiS master control program.
REM Running it manually will likely result in a broken system.
REM 			    	             YOU HAVE BEEN WARNED.
REM #########################################################################
echo We Are Running In Windows 10 Mode Now

:: Check system Architecture version so we can call the correct version of Powershell.
echo Finding Architecure
reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OSARC=32BIT || set OSARC=64BIT
echo %OSARC%
:: Check if this script is being run from OSIRiS master control program
:: or manually. If it's being run manually (incorrectly) then quit.
:: Essentially all we do here is check if variable %3 is set to itself.
:: If OSIRiS has started this script, then %3 will be something other than %3.
IF %3.==. (GOTO MANUALRUN) ELSE (GOTO TZLOOP)

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

:: Set the country to Australia in case the user forgot at setup.
echo Setting the System Locale
powershell "Set-WinSystemLocale en-AU" > NUL 2>&1

:: Set the time from the first argument passed.
echo Setting the Time
time %1 > NUL 2>&1



REM ################################################################
REM #Rename the computer to the machine OEM model extracted from
REM #Firmware with WMIC.
REM ################################################################
echo Renaming the Computer

:: Dump the contents of the 'Model' column to a text file from the WMIC COMPUTERSYSTEM command.
wmic computersystem get model > tempmodel.txt

:: Because the 'GET' command tends to dump the column name as well as the content, strip the name from the top of the file.
:: Dump the new data to a different file otherwise the encoding gets mangled.
type tempmodel.txt | findstr /v Model > compmodel.txt

:: The computer name cannot contain spaces so we use powershell to run through the file identifying all spaces and remove them.
powershell "(Get-Content compmodel.txt) | Foreach-Object {$_ -replace '[^a-zA-Z]', ''} | Set-Content compmodel.txt" > NUL 2>&1

:: Run a loop through the text file created earlier and load the model name into a variable (%G).
:: Set the variable %G as the computer name.
FOR /F "tokens=* delims=" %%G in (compmodel.txt) DO wmic computersystem where name="%COMPUTERNAME%" call rename name=%%G > NUL 2>&1

:: Delete the two text files.
DEL compmodel.txt > NUL 2>&1
DEL tempmodel.txt > NUL 2>&1

REM ################################################################
REM #Remove all current user accounts except Administrator, Guest
REM #and HomeGroupUser$.
REM #Create an Officeworks Administrator User and set it's password
REM #to happy456 with no Expiry.
REM ################################################################
echo Creating the Officeworks User
:: Switch guest off.
net user guest /active:no > NUL 2>&1

:: Dump all user account names to a text file.
wmic useraccount get name > userlist.txt

:: Trim the white space from the start and end of User Account strings.
powershell "$content = Get-Content .\userlist.txt"; "$content | Foreach {$_.TrimEnd()} | Set-Content .\userlist.txt" > NUL 2>&1

:: Remove various junk lines from the text file.
type userlist.txt | findstr /v Name | findstr /v Administrator | findstr /v Guest | findstr /v HomeGroup | findstr /v DefaultAccount > userlisttrimmed.txt

:: Loop through the text file and delete each user account listed.
FOR /F "tokens=* delims=*" %%G in (userlisttrimmed.txt) DO net user /delete "%%G" 1>NUL

:: Create the new 'Admin Account' user.
net user Officeworks "%~4" /add > NUL 2>&1

:: Add 'Admin Account' to the Administrators group.
net localgroup Administrators Officeworks /add > NUL 2>&1

:: Disable the default password expiry to prevent having to change the password every 30 days.
WMIC USERACCOUNT WHERE "Name='Officeworks'" SET PasswordExpires=FALSE > NUL 2>&1

REM ############################################################
REM #Configure a standard user account for customer use called
REM #'Customer' with no password and no password expiry.
REM ############################################################

echo Creating the Standard Customer User

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
:: Disables Hybrid sleep so we can wake the machine at 6:30am.
powercfg -hibernate off 2>&1

REM ####################################################
REM #Switch off Windows Update and set it's service to
REM #not auto-start on boot.
REM ####################################################
echo Disabling Windows Update

net stop wuauserv > NUL 2>&1
sc config wuauserv start=disabled > NUL 2>&1

REM ###################################################
REM #Create a directory on C: called profiles.
REM #Connect the wireless radio to the Officeworks WLAN.
REM ###################################################
echo Configuring Wireless Network

mkdir C:\profiles > NUL 2>&1
Netsh wlan add profile filename="%~dp0\OFW-Display.xml" > NUL 2>&1
Netsh wlan connect OFW-Display > NUL 2>&1

REM ######################################################################################
REM #Create a scheduled task to sleep the machine based upon the argument %2 every night.
REM ######################################################################################

echo Configuring Auto Sleep
copy "%~dp0\setup_payload\sleep.ps1" C:\profiles\ > NUL 2>&1
SCHTASKS /Create /XML "%~dp0\AutoSleep.xml" /tn AutoSleep > NUL 2>&1
SCHTASKS /Change /AutoSleep /ST "%2" > NUL 2>&1

echo Configuring Auto Wake
SCHTASKS /Create /XML "%~dp0\AutoWake.xml" /tn AutoWake > NUL 2>&1

REM #########################################################
REM #Modifying the wallpaper for the Customer user requires a
REM #multi-step approach.
REM #########################################################

echo Setting Up Custom Wallpaper

::Here we dump the contents of WMIC CPU to a text file and copy over
::OSIRiS Desktop Info to the profiles folder.

copy "%~dp0\setup_payload\ODIN.exe" C:\profiles\ > NUL 2>&1
copy "%~dp0\setup_payload\Reconfigure_ODIN.exe" C:\profiles\ > NUL 2>&1

wmic cpu get name |more > %TEMP%\tempcpu.txt

::Strip the top line of the file.
type %TEMP%\tempcpu.txt | findstr /v Name > %TEMP%\cpu.txt

::Call the prccheck.bat script to determine what wallpaper to use.
call "%~dp0\proccheck.bat"

::Start ODIN at logon. The old method was to use a scheduled task which is unreliable on certain machines.
::The new approach is to write to the startup section of the registry. This SHOULD (read: might break) work
::on all machines.
::Call the powershellreg.ps1 script to disable first sign in animations, disable Windows Update and force 'Customer' account login.
::Also set up ODIN on login start.
echo Set Registry Entries Via PowerShell
SET "ThisScriptsDirectory=%~dp0"
SET "PowerShellScriptPath=%ThisScriptsDirectory%powershellreg.ps1"
if %OSARC%==64BIT C:\windows\sysnative\windowspowershell\v1.0\powershell.exe -NonInteractive -executionpolicy Bypass -file "%PowerShellScriptPath%" %5 > NUL 2>&1
if %OSARC%==32BIT powershell.exe -NonInteractive -executionpolicy Bypass -file "%PowerShellScriptPath%" %5 > NUL 2>&1

::Delete the cpu.txt file.
del %TEMP%\cpu.txt
del %TEMP%\tempcpu.txt

::Copy over ROSY for use when a machine fails to be sold with OSIRiS.
copy "%~dp0\setup_payload\ROSY.exe" C:\profiles\ > NUL 2>&1

REM #######################################################
REM #Here we verify that the various sections of OSIRiS
REM #have run correctly. This ensures that no weirdness
REM #happens, such as having no Admin account.
REM #######################################################

echo Pinging Localhost for 10 Seconds Before Verification
echo Beginning Verification
PING 127.0.0.1 -n 10 >NUL 2>&1 || PING ^::1 -n 10 >NUL 2>&1

net user | find /i "Officeworks" 1>NUL || Net user Officeworks "%4" /add > NUL 2>&1
WMIC USERACCOUNT WHERE "Name='Officeworks'" SET PasswordExpires=FALSE > NUL 2>&1
net localgroup Administrators Officeworks /add > NUL 2>&1
net user | find /i "Customer" 1>NUL || Net user Customer /add > NUL 2>&1
WMIC USERACCOUNT WHERE "Name='Customer'" SET PasswordExpires=FALSE > NUL 2>&1
SCHTASKS /query /TN "AutoSleep" > NUL 2>&1
if NOT %errorlevel%==0 (
  SCHTASKS /Create /XML "%~dp0\AutoSleep.xml" /tn AutoSleep > NUL 2>&1
  SCHTASKS /Change /AutoSleep /ST "%2" > NUL 2>&1
)
SCHTASKS /query /TN "AutoWake" > NUL 2>&1
if NOT %errorlevel%==0 (
SCHTASKS /Create /XML "%~dp0\AutoWake.xml" /tn AutoWake > NUL 2>&1
)
SCHTASKS /query /TN "Wi-Fi Check" > NUL 2>&1
if NOT %errorlevel%==0 (
SCHTASKS /create /F /tn "Wi-Fi Check" /tr "powershell 'get-netadapter wi-fi | restart-netadapter'" /sc onstart /RL HIGHEST /RU "SYSTEM" > NUL 2>&1
)

echo Verification Complete


echo Restarting

shutdown -r -t 5 -c "Rebooting to complete setup."
exit

:MANUALRUN
echo This script CANNOT be run manually. Please start OSIRiS.exe instead.
pause>nul
explorer %~d0
exit
