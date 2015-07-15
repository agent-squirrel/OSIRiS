@ECHO OFF
@title  Suppress Auto-Shutdown

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

:: This batch file simply lives in C:\Profiles\ and is called from the desktop
:: shortcut of the same name. If a display machine is powering off for the day
:: and you need to continue using it, double click the desktop icon.
:: This batch file will suspend shutdown for one hour.



shutdown -a > NUL 2>&1
if errorlevel 1 goto noshutdown
echo Shutdown has been suspended for 1 hour.
echo Press enter to close this window.
shutdown -t 3600 -f -s
pause > nul
exit

:noshutdown
echo There is no pending shutdown.
echo Press any key to exit.
pause > nul
exit
