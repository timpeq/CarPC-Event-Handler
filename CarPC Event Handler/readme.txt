CarPC Power Event Handler
by Tim Pequignot
http://peq.me/cpceh

This is a small utility which lives in the system tray which serves two purposes:
It automatically suspends the machine when it switches from AC (charging) to battery power, and it moves the mouse when the machine
switches from Battery to AC.

Beginning with Windows 8, Microsoft introduced "Connected Standby".  Any software that attempts to put a machine with connected standby
into Standby/Sleep state instead hibernates the machine.  Through trial and error, I found that the command which normally puts a monitor
to sleep, will put the machine in Connected Standby.

I have installed a Winbook TW801 running Windows 10 in the dash of my car.  The charger is connected to acc power, so that when the key 
is turned off, the tablet will begin running on battery.  This software detects this change and puts the computer in sleep mode. 

Any time that this machines have power applied while it's sleeping (in connected standby) it momentarily wakes up.  The only way I have
found to keep it from going back to sleep a couple seconds later is move the mouse a few pixels back and forth when the power has been 
re-applied.

To keep the battery in the tablet from draining completely overnight (Connected standby drains a lot more power than old-style standby)
I have Windows set to hibernate the computer at 80.
