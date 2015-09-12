######################################################
#             THIS FILE IS PART OF OSIRiS            #
#                  COPYRIGHT NOTICE                  #
#         Copyright Adam Heathcote 2014 - 2015.      #
#OSIRiS and associated documentation are distributed #
#       under the GNU General Public License.        #
#Please see gpl.txt in the root of the OSIRiS folder.#
######################################################

$updatepath = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\WindowsUpdate\Auto Update'
New-ItemProperty $updatepath -Name AUOptions -Value 4 -Force

$animpath = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System'
New-ItemProperty $animpath -Name EnableFirstLogonAnimation -Value 1 -Force

$loginpath = 'HKLM:\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon'
New-ItemProperty $loginpath -Name AutoAdminLogon -Value 0 -Force
New-ItemProperty $loginpath -Name DefaultUserName -Value '' -Force
New-ItemProperty $loginpath -Name DefaultPassword -Value '' -Force
New-ItemProperty $loginpath -Name ForceAutoLogon -Value 0 -Force

$ODINautostart = 'HKLM:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run'
Remove-ItemProperty $ODINautostart -Name ODIN -Force
