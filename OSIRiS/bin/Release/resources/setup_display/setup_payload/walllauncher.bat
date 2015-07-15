@ECHO OFF
@title Set Wallpaper

REM ######################################################
REM #             THIS FILE IS PART OF OSIRiS            #
REM #                  COPYRIGHT NOTICE                  #
REM #         Copyright Adam Heathcote 2014 - 2015.      #
REM #OSIRiS and associated documentation are distributed #
REM #       under the GNU General Public License.        #
REM #Please see gpl.txt in the root of the OSIRiS folder.#
REM ######################################################

:: The function of this batch file is to call a powershell script and setup the
:: environment for it. Powershell takes a while to INIT when started from the
:: task scheduler whereas batch files start instantly. So we can use this script
:: to provide user feedback and then run powershell in the background.


CLS
mode con: cols=68 lines=10

echo Setting Wallpaper, please DO NOT close this window.
echo This can take up to 1 minute, the window will close automatically.

powershell.exe -NonInteractive -executionpolicy Bypass -file C:\profiles\wall.ps1

echo Setting Home Page for IE.
@title Set Homepage

:: Set the homepage/default page of IE to www.officeworks.com.au.
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer\Main" /v Default_Page_URL /t REG_SZ /d www.officeworks.com.au /f >NUL 2>&1
reg add "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer\Main" /v "Start Page" /t REG_SZ /d www.officeworks.com.au /f >NUL 2>&1

exit
