@ECHO OFF
setlocal EnableDelayedExpansion
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
REM                  Processor Check Script for Windows 10
REM                             Adam Heathcote
REM This script CANNOT be run manually! It expects arguments, either fed from
REM the command line or from the OSIRiS master control program.
REM Running it manually will likely result in a broken system.
REM 			    	             YOU HAVE BEEN WARNED.
REM #########################################################################

::Use 'find' to look through the cpu.txt file and check for specific
::strings containing CPU information.
::Copy a specific wallpaper over to the local disk based upon the CPU
::discovered inside cpu.txt.

REM ################################### BEGIN PROCESSOR CHECK CODE BLOCK ############################################
echo Setting Up Custom Wallpaper

REM ##INTEL BLOCK##

::Check for Intel
find /I "intel" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (cd "%~dp0\setup_payload\walls\intel") ELSE (GOTO AMD) > NUL 2>&1

::Check for i5
find /I "i5" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (powershell "$cpu = Get-Content %TEMP%\cpu.txt"; "$cpu.Split('-')[1] | Set-Content %TEMP%\cpu.txt") ELSE (GOTO i3) > NUL 2>&1

::Check for Skylake
set /p cpu=<"%TEMP%\cpu.txt"
set gen=%cpu:~0,1%
if %gen%==6 (echo Found Skylake Core i5 && cd "6thgen" && copy i5.bmp C:\profiles\wallpaper.bmp) ELSE (echo Found Core i5 && cd "4thgen" && copy i5.bmp C:\profiles\wallpaper.bmp)
GOTO ENDPROC

:i3
::Check for i3
find /I "i3" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (powershell "$cpu = Get-Content %TEMP%\cpu.txt"; "$cpu.Split('-')[1] | Set-Content %TEMP%\cpu.txt") ELSE (GOTO i7) > NUL 2>&1

::Check for Skylake
set /p cpu=<"%TEMP%\cpu.txt"
set gen=%cpu:~0,1%
if %gen%==6 (echo Found Skylake Core i3 && cd "6thgen" && copy i3.bmp C:\profiles\wallpaper.bmp) ELSE (echo Found Core i3 && cd "4thgen" && copy i3.bmp C:\profiles\wallpaper.bmp)
GOTO ENDPROC

:i7
::Check for i7
find /I "i7" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (powershell "$cpu = Get-Content %TEMP%\cpu.txt"; "$cpu.Split('-')[1] | Set-Content %TEMP%\cpu.txt") ELSE (GOTO pent) > NUL 2>&1

::Check for Skylake
set /p cpu=<"%TEMP%\cpu.txt"
set gen=%cpu:~0,1%
if %gen%==6 (echo Found Skylake Core i7 && cd "6thgen" && copy i7.bmp C:\profiles\wallpaper.bmp) ELSE (echo Found Core i7 && cd "4thgen" && copy i7.bmp C:\profiles\wallpaper.bmp)
GOTO ENDPROC

:pent
::Check for Pentium
find /I "pentium" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Pentium && cd "4thgen" && copy pentium.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO cel)  > NUL 2>&1
GOTO ENDPROC

:cel
::Check for Celeron
find /I "celeron" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Celeron && cd "4thgen" && copy celeron.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO atom)  > NUL 2>&1
GOTO ENDPROC

:atom
::Check for Atom
find /I "atom" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Atom && cd "4thgen" && copy atom.bmp C:\profiles\wallpaper.bmp) ELSE (GOTO corem)  > NUL 2>&1
GOTO ENDPROC

:corem
::Check for original Broadwell based Core M
find /I "5y" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Core M && cd "4thgen" && copy "corem.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO skycorem3)  > NUL 2>&1
GOTO ENDPROC
::Failing search for Broadwell 5th Gen Core M, search for the new Skylake 6th Gen Core M.
::There are 3 different versions of the Skylake Core M so extra code is required.
:skycorem3
find /I "m3" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Skylake Core M3 && cd "6thgen" && copy "m3.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO skycorem5)  > NUL 2>&1
:skycorem5
find /I "m5" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Skylake Core M5 && cd "6thgen" && copy "m5.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO skycorem7)  > NUL 2>&1
:skycorem7
find /I "m7" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found Skylake Core M7 && cd "6thgen" && copy "m7.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO xeon)  > NUL 2>&1
GOTO ENDPROC

:xeon
::Check for Xeon
find /I "xeon" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (powershell "$cpu = Get-Content %TEMP%\cpu.txt"; "$cpu.Split('-')[1] | Set-Content %TEMP%\cpu.txt") ELSE (GOTO AMD) > NUL 2>&1
::Check for Skylake
find /I "v5" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (echo Found Skylake XEON && cd "6thgen" && copy "xeon.bmp" C:\profiles\wallpaper.bmp) ELSE (echo Found XEON && cd "4thgen" && copy "xeon.bmp" C:\profiles\wallpaper.bmp) > NUL 2>&1
GOTO ENDPROC

REM ##END INTEL##

REM ##AMD BLOCK##
:AMD

find /I "amd" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (cd "%~dp0\setup_payload\walls\amd") ELSE (GOTO unknown) > NUL 2>&1

:e2
find /I "e2" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD E2 && copy "e2.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO e1)  > NUL 2>&1
GOTO ENDPROC
:e1
find /I "e1" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD E1 && copy "e1.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO a4)  > NUL 2>&1
GOTO ENDPROC
:a4
find /I "a4" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD A4 && copy "a4.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO a6)  > NUL 2>&1
GOTO ENDPROC
:a6
find /I "a6" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD A6 && copy "a6.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO a8)  > NUL 2>&1
GOTO ENDPROC
:a8
find /I "a8" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD A8 && copy "a8.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO a10)  > NUL 2>&1
GOTO ENDPROC
:a10
find /I "a10" "%TEMP%\cpu.txt"  > NUL 2>&1
if %errorlevel%==0 (echo Found AMD A10 && copy "a10.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO fx)  > NUL 2>&1
GOTO ENDPROC
:fx
find /I "fx" "%TEMP%\cpu.txt" > NUL 2>&1
if %errorlevel%==0 (echo Found AMD FX && copy "fx.bmp" C:\profiles\wallpaper.bmp) ELSE (GOTO unknown)  > NUL 2>&1
GOTO ENDPROC

REM ##END AMD##

:unknown
Unknown CPU Found
copy "%~dp0\setup_payload\walls\generic.bmp" C:\profiles\wallpaper.bmp > NUL 2>&1

REM ################################### END PROCESSOR CHECK CODE BLOCK ############################################

:ENDPROC
