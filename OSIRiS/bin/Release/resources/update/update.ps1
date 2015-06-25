######################################################
#             THIS FILE IS PART OF OSIRiS            #
#                  COPYRIGHT NOTICE                  #
#         Copyright Adam Heathcote 2014 - 2015.      #
#OSIRiS and associated documentation are distributed #
#       under the GNU General Public License.        #
#Please see gpl.txt in the root of the OSIRiS folder.#
######################################################

#This script creates the directories for the old version of OSIRiS to be
#moved into. It then moves all the old files into this new directory.
#It is called from OSIRiS.exe and as such the paths or in the context of
#OSIRiS.exe's location.

#Ignore errors.
$ErrorActionPreference = 'silentlycontinue'

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
$newsize.height = 20
$pswindow.windowsize = $newsize

#Print some text to the powershell window.
write-host Creating backup, please wait...

#Create a backup directory
new-item backup -itemtype directory

#Move the individual loose files to the backup folder.
Move-Item -Path OSIRiS.exe -Destination backup
Move-Item -Path gpl.txt -Destination backup
Move-Item -Path OSIRiS_Manual.pdf -Destination backup
Move-Item -Path OSIRiS_Manual.docx -Destination backup

#Move the resources directory to the backup folder.
Move-Item -Path resources -Destination backup
