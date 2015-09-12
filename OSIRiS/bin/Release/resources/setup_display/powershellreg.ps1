######################################################
#             THIS FILE IS PART OF OSIRiS            #
#                  COPYRIGHT NOTICE                  #
#         Copyright Adam Heathcote 2014 - 2015.      #
#OSIRiS and associated documentation are distributed #
#       under the GNU General Public License.        #
#Please see gpl.txt in the root of the OSIRiS folder.#
######################################################

param(
[string]$a
)

$updatepath = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update'
New-ItemProperty $updatepath -Name AUOptions -Value 1 -Force

$animpath = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System'
New-ItemProperty $animpath -Name EnableFirstLogonAnimation -Value 0 -Force

$loginpath = 'HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon'
New-ItemProperty $loginpath -Name AutoAdminLogon -Value 1 -Force
New-ItemProperty $loginpath -Name DefaultUserName -Value 'Customer' -Force
New-ItemProperty $loginpath -Name DefaultPassword -Value '' -Force
New-ItemProperty $loginpath -Name ForceAutoLogon -Value 1 -Force

$ODINautostart = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run'
if ($a -eq "clearance")
{
New-ItemProperty $ODINautostart -Name ODIN -Value "`"C:\profiles\ODIN.exe`" clear" -force
} else {
New-ItemProperty $ODINautostart -Name ODIN -Value "C:\profiles\ODIN.exe" -force
}

