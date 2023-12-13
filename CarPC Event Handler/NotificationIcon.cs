/*
 * Created by SharpDevelop.
 * User: Tim Pequignot
 * Date: 5/24/2016
 */
 
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Configuration;

namespace CarPC_Power_Event_Handler 
{
	
	public sealed class NotificationIcon 
	{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		
		[DllImport("user32.dll")]
		private static extern int PostMessage(int hWnd, int hMsg, int wParam, int lParam);
		
       	[DllImport("user32.dll")]
		static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 dwData, UIntPtr dwExtraInfo);
		
		private const int MOUSEEVENTF_MOVE = 0x0001;
		
		ConfigurationForm frmConfiguration = new ConfigurationForm();
		CountdownForm frmCountdown = new CountdownForm();
		
		public static bool cfgEnabled;
		public static bool cfgMonitorOff;
		public static bool cfgAutoStart;
		public static bool cfgSleepOnStart;
		public static int cfgSleepOnStartDelay;
		public static int cfgSleepDelay;
		
		public static int intCountdownTime;
		
       	#region Initialize icon and menu
       	public NotificationIcon()
       	{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());
			
			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
			
			SystemEvents.PowerModeChanged 
        		+= new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);
			
			ReadAllSettings();	
			
			PowerStatus power = SystemInformation.PowerStatus;
			
			if (power.PowerLineStatus == PowerLineStatus.Offline) 
			{
				if (cfgSleepOnStart)
				{
					intCountdownTime = cfgSleepOnStartDelay;
					
					if(frmCountdown == null || frmCountdown.IsDisposed)
    					frmCountdown = new CountdownForm();  
					frmCountdown.Show();
				}
			}	
		}
		
		private MenuItem[] InitializeMenu() 
		{
			MenuItem[] menu = new MenuItem[] 
			{
				//new MenuItem("Enabled", menuEnabledClick),
				new MenuItem("Configure", menuConfigureClick),
				new MenuItem("About", menuAboutClick),
				new MenuItem("-"),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}		
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			
			using (Mutex mtx = new Mutex(true, "CarPC_Power_Event_Handler", out isFirstInstance))
			{
				if (isFirstInstance) 
				{
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else 
				{
					MessageBox.Show("CarPC Power Event Handler is already running");
				}
			} // releases the Mutex
		}
		#endregion
		
		
		
		#region Event Handlers
		private void menuConfigureClick(object sender, EventArgs e) 
		{
			if(frmConfiguration == null || frmConfiguration.IsDisposed)
    			frmConfiguration = new ConfigurationForm();  
			frmConfiguration.Show();
		}
		
		private void menuEnabledClick(object sender, EventArgs e) 
		{
			//TODO:
			//Make this change the setting and store the checkbox to the menu it
		}
		
		private void menuAboutClick(object sender, EventArgs e)
		{
			MessageBox.Show("CarPC Power Event Handler v0.1 by Tim Pequignot");
		}
		
		private void menuExitClick(object sender, EventArgs e) 
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			if(frmConfiguration == null || frmConfiguration.IsDisposed)
			{
    			frmConfiguration = new ConfigurationForm();  
				frmConfiguration.Show();
				frmConfiguration.Activate();
			}
			else
			{
				frmConfiguration.Show();
				frmConfiguration.Activate();
				
			}
		}
		
		private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
		{
			if (cfgEnabled) 
			{
				if (e.Mode == PowerModes.StatusChange) 
				{
					PowerStatus power = SystemInformation.PowerStatus;
					if (power.PowerLineStatus == PowerLineStatus.Online)
					{
						MouseMove();
						if(frmCountdown != null || !frmCountdown.IsDisposed)
							frmCountdown.timerSleep.Stop();
							frmCountdown.Dispose();
					}
					
					else if (power.PowerLineStatus == PowerLineStatus.Offline)
					{
						//if (cfgMonitorOff) MonitorOff();
						//else SystemSleep();
						
						intCountdownTime = cfgSleepDelay;
						
						if(frmCountdown == null || frmCountdown.IsDisposed)
    						frmCountdown = new CountdownForm();  
						frmCountdown.Show();
						
					}
				}
			}
		}
		#endregion
		
		#region Custom Routines
		public static void MonitorOff() 
		{
        	PostMessage(0xFFFF, 0x112, 0xF170, (int)2);	
    	}
		
		public static void SystemSleep()
		{
			//TODO
			//Make this suspend/sleep PC
			//I don't need this so this might stay as "todo" forever .
		}
		
		private static void MouseMove()
		{
			mouse_event(MOUSEEVENTF_MOVE, 0, 5, 5, UIntPtr.Zero);
			System.Threading.Thread.Sleep(40);
			mouse_event(MOUSEEVENTF_MOVE, 0, -5, -5, UIntPtr.Zero);
		}
		
        static string ReadSetting(string key) 
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("Error reading app settings");
                return null;
            }
        }
		
		static void WriteSetting(string key, string value)
		{
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException) 
            {
                MessageBox.Show("Error Writing App Settings");
            }
        }

		public static void ReadAllSettings() 
		{
			cfgEnabled = false;
			cfgMonitorOff = false;
			cfgAutoStart = false;
			cfgSleepDelay = 2;
			cfgSleepOnStart = false;
			cfgSleepOnStartDelay = 10;

			try 
			{
				if (ReadSetting("cfgEnabled") == "True")
					cfgEnabled = true;	
	
				if (ReadSetting("cfgMonitorOff") == "True")
					cfgMonitorOff = true;
				
				if (ReadSetting("cfgAutoStart") == "True")
					cfgAutoStart = true;
				
				if (ReadSetting("cfgSleepOnStart") == "True")
					cfgSleepOnStart = true;
				
				cfgSleepOnStartDelay = Convert.ToInt32(ReadSetting("cfgSleepOnStartDelay"));
			
				cfgSleepDelay = Convert.ToInt32(ReadSetting("cfgSleepDelay"));
			}
			
			catch {
				MessageBox.Show("Error Reading Settings");
			}
			
		}
		
		public static void WriteAllSettings() 
		{
			try
			{
				WriteSetting("cfgEnabled",cfgEnabled.ToString());
				WriteSetting("cfgMonitorOff",cfgMonitorOff.ToString());
				WriteSetting("cfgAutoStart",cfgAutoStart.ToString());
				WriteSetting("cfgSleepOnStart",cfgSleepOnStart.ToString());
				WriteSetting("cfgSleepOnStartDelay",cfgSleepOnStartDelay.ToString());
				WriteSetting("cfgSleepDelay",cfgSleepDelay.ToString());
			}
			catch
			{
				MessageBox.Show("Error Writing Settings");
			}
		}
		
		public static void msgbox(String Message)
		{
			MessageBox.Show(Message);
		}
		
	#endregion

	} // End public sealed class NotificationIcon

} // End namespace CarPC_Power_Event_Handler
