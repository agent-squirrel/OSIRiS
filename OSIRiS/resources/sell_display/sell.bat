@ECHO OFF
@title  Sell Display

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM # OSACS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

cls
REM #########################################################################
REM                        New Machine Sell Script
REM                             Adam Heathcote
REM This script CANNOT be run manually! It expects arguments, either fed from
REM the command line or from the OSIRiS master control program.
REM Running it manually will likely result in a broken system.
REM 			    		YOU HAVE BEEN WARNED.
REM #########################################################################

REM ################################
REM #Switch Automatic Updates Back On
REM ################################
@title  Switch Windows Update Back On

echo Adding Windows Update Registry DWORD

:: Re-add the registry DWORD value that tells Windows Update to start on boot.
reg add "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update" /v AUOptions /t REG_DWORD /d 4 /f > NUL 2>&1

REM #######################################################
REM #Delete Customer Account.
REM #Delete Officeworks Account.
REM #Delete any other accounts with any name.
REM #Create a new account for buyer based upon argument %2.
REM #and make it an Admin with no password.
REM #######################################################
@title  Remove and Create Accounts

echo Deleting Accounts

:: Dump all user account names to a text file.
wmic useraccount get name > userlist.txt

:: Remove various junk lines from the text file.
type userlist.txt | findstr /v Name | findstr /v Administrator | findstr /v Guest | findstr /v HomeGroup > userlisttrimmed.txt

:: Loop through the text file and delete each user account listed.
FOR /F "tokens=* delims=" %%G in (userlisttrimmed.txt) DO net user /delete %%G > NUL 2>&1

echo Creating New Account

:: Create a new account based on the user input variable %2.
net user %2 "" /add > NUL 2>&1

:: Add the user to the Administrators group.
net localgroup "Administrators" "%2" /add > NUL 2>&1

:: Switch off 'User's password expiry.
wmic useraccount where "name='%2'" set PasswordExpires=FALSE > NUL 2>&1

DEL userlist.txt > NUL 2>&1
DEL userlisttrimmed.txt > NUL 2>&1

REM #################################################
REM #Copy the post-reboot cleanup script to C:\OSACS
REM #and create a scheduled task to run it on
REM #first boot of the new user.
REM #Delete the "Airplane Mode" boot check and
REM #the Auto-Shutdown routine.
REM #################################################
@title  Setting Up Cleanup

echo Copying Cleanup Files

:: Copy over a script to facilitate cleanup operations, post reboot.
:: Schedule a task to run on first boot that launches the cleanup script.
copy %~dp0\cleanup.bat C:\profiles\cleanup.bat > NUL 2>&1
copy %~dp0\usercleanup.bat C:\profiles\usercleanup.bat > NUL 2>&1
schtasks /create /tn "Cleanup" /tr C:\profiles\cleanup.bat /sc onstart /RL HIGHEST /RU "SYSTEM" > NUL 2>&1

:: Delete both of the existing scheduled tasks.
schtasks /delete /tn "Computer Shutdown" /f > NUL 2>&1
schtasks /delete /tn "Wi-Fi Check" /f > NUL 2>&1

REM ###############################################
REM #Set the balanced power plan as the active plan
REM #and delete the Officeworks plan.
REM ###############################################
@title  Fixing Power Plan

echo Restoring Sane Power Settings

POWERCFG -restoredefaultschemes > NUL 2>&1



REM ###############################################
REM #Disconnect the Wireless Radio and disassociate
REM #the Officeworks profile with it.
REM #Delete the Extensible Markup Language file
REM #containing configuration data for the Officeworks
REM #WLAN.
REM ###############################################
@title  Resetting Wireless

echo Kill The Wireless Radio

Netsh wlan disconnect > NUL 2>&1

Netsh wlan delete profile name="OFW-Display" > NUL 2>&1

del  C:\profiles\OFW-Display.xml > NUL 2>&1

REM ###########################################
REM #Reset the Wireless Radio to force a
REM #disconnect of the network if required.
REM ###########################################

:: Force reset of the Wi-Fi card to make sure that it disconnects after removing
:: the OFW-Display profile.
powershell "$Host.UI.RawUI.WindowTitle = 'Doing Powershell Stuff'; get-netadapter wi-fi | restart-netadapter" > NUL 2>&1

echo Deleting the Shutdown Suppressor
DEL C:\Users\Public\Desktop\"Cancel Auto-Shutdown.lnk" > NUL 2>&1
DEL C:\profiles\"Cancel Auto-Shutdown.bat" > NUL 2>&1



goto %1

:Shutdown

shutdown -s -t 5 /c "Shutting down."

exit

:Restart

shutdown -r -t 5 /c "Rebooting to complete setup."

exit
