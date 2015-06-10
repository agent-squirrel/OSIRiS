######################################################
#             THIS FILE IS PART OF OSIRiS            #
#                  COPYRIGHT NOTICE                  #
#         Copyright Adam Heathcote 2014 - 2015.      #
#OSIRiS and associated documentation are distributed #
#       under the GNU General Public License.        #
#Please see gpl.txt in the root of the OSIRiS folder.#
######################################################

#Change the dimensions of the window so it's not so imposing.
$pshost = Get-Host
$pswindow = $pshost.UI.RawUI

$newsize = $pswindow.BufferSize
$newsize.width = 150
$pswindow.buffersize = $newsize

$newsize = $pswindow.windowsize
$newsize.width = 70
$pswindow.windowsize = $newsize

$newsize = $pswindow.windowsize
$newsize.height = 5
$pswindow.windowsize = $newsize

#Make BGInfo highDPI aware. This is required because Windows 8.1 treats BGInfo
#as a 'Legacy' application and scales it's UI to make it touch friendly.
#This has the nasty side effect of making BGInfo think it's running on a very
#small display, and thusly tiles the wallpaper. Here we disable this feature.
reg.exe Add "HKCU\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" /v "C:\profiles\BGInfo\Bginfo.exe" /d "HIGHDPIAWARE" /f


#Print some text to the powershell window.
write-host Setting walpaper, please wait...

#Set the $regvar variable to the contents of the registry value indicating the
#wallpaper to use.

$regvar = (gp "HKCU:\Control Panel\Desktop").Wallpaper

#Set the wallpaper to the copied bitmap if it isn't already by comparing the
#$regvar variable to the hardcoded path. We have to do this because setting
#the wallpaper if it is already set, and then running BGInfo mangles the
#wallpaper style control.

if($regvar -ne "C:\Users\Customer\AppData\Local\Temp\BGInfo.bmp") {
Set-ItemProperty -path 'HKCU:\Control Panel\Desktop\' -name wallpaper -value C:\profiles\wallpaper.bmp
Set-ItemProperty 'HKCU:\Control Panel\Desktop' -Name "WallpaperStyle" -Value 2
}
else {exit}

rundll32.exe user32.dll, UpdatePerUserSystemParameters

#Spawn BGInfo with our standard configuration then close.

C:\profiles\BGInfo\Bginfo.exe C:\profiles\BGInfo\OWbginfoconfig.bgi /TIMER:0 /accepteula
