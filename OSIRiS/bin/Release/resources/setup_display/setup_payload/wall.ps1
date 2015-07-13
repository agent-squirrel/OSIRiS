######################################################
#             THIS FILE IS PART OF OSIRiS            #
#                  COPYRIGHT NOTICE                  #
#         Copyright Adam Heathcote 2014 - 2015.      #
#OSIRiS and associated documentation are distributed #
#       under the GNU General Public License.        #
#Please see gpl.txt in the root of the OSIRiS folder.#
######################################################

#Set process priority of this script to 'Normal' from the Task Scheduler's
#usual setting of 'Low'.
#We do this so that this script runs quickly and gets out of the way at boot time.
(Get-Process -id $pid).PriorityClass = "Normal"

#Create a function that hooks the win32 API in C# to set the wallpaper.
#This has to be done because Windows wont reliably reload the registry and
#update the user theme unless the request comes from the shell.
Add-Type @"
using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace Wallpaper
{
   public enum Style : int
   {
       Tile, Center, Stretch, NoChange
   }
   public class Setter {
      public const int SetDesktopWallpaper = 20;
      public const int UpdateIniFile = 0x01;
      public const int SendWinIniChange = 0x02;
      [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
      private static extern int SystemParametersInfo (int uAction, int uParam, string lpvParam, int fuWinIni);
      public static void SetWallpaper ( string path, Wallpaper.Style style ) {
         SystemParametersInfo( SetDesktopWallpaper, 0, path, UpdateIniFile | SendWinIniChange );
         RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
         switch( style )
         {
            case Style.Stretch :
               key.SetValue(@"WallpaperStyle", "2") ;
               key.SetValue(@"TileWallpaper", "0") ;
               break;
            case Style.Center :
               key.SetValue(@"WallpaperStyle", "1") ;
               key.SetValue(@"TileWallpaper", "0") ;
               break;
            case Style.Tile :
               key.SetValue(@"WallpaperStyle", "1") ;
               key.SetValue(@"TileWallpaper", "1") ;
               break;
            case Style.NoChange :
               break;
         }
         key.Close();
      }
   }
}
"@

#Set the $regvar variable to the contents of the registry value indicating the
#wallpaper to use.

$regvar = (gp "HKCU:\Control Panel\Desktop").Wallpaper

#Set the wallpaper to the copied bitmap if it isn't already by comparing the
#$regvar variable to the hardcoded path.
#Start OSIRiS Desktop Info on top of the wallpaper.

if($regvar -ne "C:\profiles\wallpaper.bmp") {
[Wallpaper.Setter]::SetWallpaper( 'C:\profiles\wallpaper.bmp', 2 )
write-host Starting ODI.
start C:\profiles\ODI.exe
}
else { write-host Starting ODI. ; start C:\profiles\ODI.exe }

exit
