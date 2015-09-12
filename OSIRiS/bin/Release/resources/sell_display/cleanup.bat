@ECHO OFF
@title Cleanup

REM ######################################################
REM #            THIS FILE IS PART OF OSIRiS             #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

CLS
REM ######################################################################
REM #    This script is invoked on first boot of the Machine Post-Sell.  #
REM #      Its purpose is to clean up the left over OSIRiS data.         #
REM #      RUNNING THIS SCRIPT MANUALLY WILL DESTROY USER PROFILES       #
REM ######################################################################
mode con: cols=100 lines=10
echo Cleaning Officeworks left-over data.
echo.
echo This can take some time, feel free to continue using your new computer.
echo.
echo DO NOT close this window, it will close by itself when finished.

REM ###########################################
REM #Delete the cleanup task so it doesn't try
REM #to run more than once.
REM ###########################################

schtasks /delete /tn Cleanup /f > NUL 2>&1

REM #############################################
REM #Stop the Windows Search Service and the
REM #Windows Media Player network service so
REM #we can delete the old user profile folders.
REM #############################################

net stop WMPNetworkSvc > NUL 2>&1

net stop WSearch > NUL 2>&1

REM ##########################################
REM #Call Mike Stone's User Cleanup script.
REM #http://mstoneblog.wordpress.com
REM ##########################################

CALL C:\profiles\usercleanup.bat > NUL 2>&1
@title Cleanup
:: Take ownership of the old Officeworks and Customer directories and then
:: delete them.

takeown /a /r /d Y /f C:\Users\Officeworks > NUL 2>&1
takeown /a /r /d Y /f C:\Users\Customer > NUL 2>&1
rmdir /q /s C:\Users\Officeworks > NUL 2>&1
rmdir /q /s C:\Users\Customer > NUL 2>&1

REM ###########################################
REM #Restart the Windows Update Service as well
REM #as the Windows Search Service and the
REM #Windows Media Player Network Service.
REM ###########################################

:: Despite the fact that the Windows Update Reg DWORD is now set to auto start,
:: sometimes the Windows Update service fails to start itself.
:: So here we manually restart it, along with the Windows Search service and
:: the Windows Media Player Network Service.

net start wuauserv > NUL 2>&1

sc config wuauserv start=auto > NUL 2>&1

net start WSearch > NUL 2>&1

net start WMPNetworkSvc > NUL 2>&1



REM ##################################
REM #Self-Destruct the cleanup script
REM #to leave no trace.
REM ##################################

del /s /q C:\profiles\* > NUL 2>&1
del "%~f0"&exit /b > NUL 2>&1
