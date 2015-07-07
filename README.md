# OSIRiS (Officeworks Scripted Initialization Routine for Stores)
OSIRiS is a tool kit for working on display/demo computers at Officeworks
or other environments where Group Policies and system images are
impractical. 
It makes setting up and selling display computers less of a chore and a more
streamlined process by automating most of the commonly performed tasks.
It also has the benefit of creating a standardised setup for all display computers.

#The key goals of OSIRiS deployment are:

To create a great place for people to shop and try computers.

Allow the use of display computers in a safe environment with
reduced risk of unwanted materials being on the machines.

To prevent configuration changes to the display computers.

The ability to deploy a display computer and have it operate
in an optimum configuration reliably in a significant amount
less time than was previously possible.

To allow a team member to sell a display computer and have
it in a clean and usable state for the customer in a minimum amount
of time.

To allow team members to format external hard disk drives and 
USB flash drives for customers in a fast and efficient manner in
a variety of file systems.

OSIRiS is written in C#, BATCH and Powershell and is open source under the GPL.

#What does it do?

When setting up a machine, OSIRiS performs the following actions:

1. Renames the machine based on the manufacturers model number as extracted from the firmware.
 
2. Sets the wallpaper to an Officeworks custom one.

3. Deletes all the user accounts on the machine.
 
4. Creates two new accounts, ‘Customer’ and ‘Officeworks’ which has it's password set to whatever the user chooses.

5. Configures a new power plan called ‘Officeworks’ that never sleeps nor hibernates.

6. Disables ‘Windows Update’ to prevent the display machines from eating all the bandwidth.

7. Configures the ‘OFW-Display’ wireless network.

8. Sets the time zone.

9. Sets the time to whatever the user chose.

10. Configures the machine to automatically shutdown at the user designated time.

11. Schedules a task to reset the wireless card on every boot of the machine. This prevents the machines being in airplane mode at the start of the day.

12. Reboots the machine.

When selling a machine, OSIRiS performs the following actions:

1. Switches ‘Windows Update’ back on.

2. Deletes the ‘Officeworks’ and ‘Customer’ users.

3. Creates a new user based on whatever the user chooses.

4. Copies over two cleanup scripts to tidy up the OSIRiS left overs on machine reboot.

5. Creates a scheduled task which executes upon reboot and login of the new user account, this task bootstraps the cleanup scripts.

6. Deletes the computer shutdown scheduled task and the wi-fi check scheduled task.

7. Deletes the Officeworks power plan and sets the balanced plan as the default one. 

8. Disconnects the wireless radio and deletes the directory containing the profile data. It then forces a reset of the radio to make sure it’s disconnected. 

9. Reboots the machine into the new user account or alternatively shuts down.
