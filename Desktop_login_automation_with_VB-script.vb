set WshShell=Wscript.CreateObject("Wscript.Shell")
    WshShell.Run("""C:\Program Files (x86)\Cisco\Cisco AnyConnect Secure Mobility Client\vpnui.exe""")
    			
	WScript.Sleep 500

	WshShell.SendKeys "{TAB 10}"
    WScript.Sleep 1000
    WshShell.SendKeys "{ENTER}"
	
	WScript.Sleep 14000
	
	REM WScript.Sleep 12000

	REM WshShell.Run "nircmd setcursor 827 546", 0, True
	REM WshShell.Run "nircmd sendmouse left click", 0, True	

	WshShell.SendKeys "" 'Write TIKS code here!
	WScript.Sleep 500
	WshShell.SendKeys "{ENTER}"
	
   	WScript.Sleep 12000
    WshShell.SendKeys "" 'Write the password here!
  	WScript.Sleep 500
  	WshShell.SendKeys "{ENTER}"
			
	WScript.Sleep 7000
		 
    WshShell.SendKeys "{ENTER}"
	WshShell.SendKeys "{ENTER}"
	
	'Start Avaya OneX communicator?
	'Start Jabber?
		
REM	 WScript.Sleep 15000
	
REM	 CreateObject("WScript.Shell").Run "mstsc C:\Users\gaglueck\Desktop\BEL-E2E-INT.RDP"
	 
REM	 WScript.Sleep 20000
REM    WshShell.SendKeys "Start112"
	
		REM Dim dteWait
		REM dteWait = DateAdd("s", 50, Now())
		REM Do Until (Now() > dteWait)
		REM Loop
		
	REM With CreateObject("WScript.Shell")
	
  REM .Run "nircmd setcursor 196 354", 0, True		'Click linkliste!
	REM .Run "nircmd sendmouse left dblclick", 0, True	'Click linkliste!

	REM WScript.Sleep 3000
	
	REM .Run "nircmd setcursor 330 282", 0, True		'Set cursor to AAX Admin GUI from Linkliste!	
    REM .Run "nircmd sendmouse left dblclick", 0, True	'Start AAX Admin GUI from Linkliste!
	
	REM WScript.Sleep 2000
	
	REM WshShell.SendKeys "test4test"
	REM WshShell.SendKeys "{ENTER 2}"
	
	REM WScript.Sleep 1000

	REM .Run "nircmd setcursor 1800 600", 0, True		'Put tray to focus with this click on neutral area on RDP!	

	REM .Run "nircmd setcursor 490 1058", 0, True 		'Start SQL dev from tray icon!	
	REM .Run "nircmd sendmouse left dblclick", 0, True	'Start SQL dev from tray icon!
	
	REM WScript.Sleep 10000
	
	REM .Run "nircmd setcursor 71 162", 0, True  		'Start AAX DB in SQL Dev from left pane! 		
    REM .Run "nircmd sendmouse left dblclick", 0, True	'Start AAX DB in SQL Dev from left pane!

REM End With