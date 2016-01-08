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
REM      Windows 8 support has been deprecated as of OSIRiS version 3.1
REM        If you still have Windows 8 display machines, you can still
REM                        use OSIRiS to sell them.
REM #########################################################################
echo We are running in Windows 8 mode now.

echo Finding Architecure
reg Query "HKLM\Hardware\Description\System\CentralProcessor\0" | find /i "x86" > NUL && set OSARC=32BIT || set OSARC=64BIT
echo %OSARC%

if %OSARC%==64BIT C:\Windows\sysnative\MSG.exe /w /time:60 %username% This version of OSIRiS setup is incompatible with Windows 8/8.1, you can still sell this machine with OSIRiS.
if %OSARC%==32BIT MSG.exe /w /time:60 %username% This version of OSIRiS setup is incompatible with Windows 8/8.1, you can still sell this machine with OSIRiS.
taskkill /f /T /IM OSIRiS.exe
