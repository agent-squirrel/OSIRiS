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
REM #         You can run it manually as an Admin if you need.           #
REM # DO NOT RUN THIS SCRIPT IF YOU HAVE ACCOUNTS OTHER THAN '%USERNAME' #
REM #     IT WILL TOTALLY DESTROY THE PROFILES OF ANY OTHER ACCOUNT.     #
REM ######################################################################


REM ###########################################
REM #Delete the cleanup task so it doesn't try
REM #to run more than once.
REM ###########################################

schtasks /delete /tn Cleanup /f

REM #############################################
REM #Stop the Windows Search Service and the
REM #Windows Media Player network service so
REM #we can delete the old user profile folders.
REM #############################################

net stop WMPNetworkSvc

net stop WSearch

REM ##########################################
REM #Call Mike Stone's User Cleanup script.
REM #http://mstoneblog.wordpress.com
REM ##########################################

REM CALL C:\profiles\usercleanup.bat

:: Take ownership of the old Officeworks and Customer directories and then
:: delete them.

takeown /a /r /d Y /f C:\Users\Officeworks
takeown /a /r /d Y /f C:\Users\Customer
rmdir /q /s C:\Users\Officeworks
rmdir /q /s C:\Users\Customer

REM ###########################################
REM #Restart the Windows Update Service as well
REM #as the Windows Search Service and the
REM #Windows Media Player Network Service.
REM ###########################################

:: Despite the fact that the Windows Update Reg DWORD is now set to auto start,
:: sometimes the Windows Update service fails to start itself.
:: So here we manually restart it, along with the Windows Search service and
:: the Windows Media Player Network Service.
:: We also reenable UAC since we disabled it to run this script.

net start wuauserv

sc config wuauserv start=auto

net start WSearch

net start WMPNetworkSvc



REM ##################################
REM #Self-Destruct the cleanup script
REM #to leave no trace.
REM ##################################

del C:\profiles\usercleanup.bat
del "%~f0"&exit /b
