/*
 * Created by SharpDevelop.
 * User: Tim Pequignot
 * Date: 5/26/2016
 */
 
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration.Assemblies;
using System.Configuration;

namespace CarPC_Power_Event_Handler
{
	public partial class ConfigurationForm : Form
	{
		
		public ConfigurationForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			
			InitializeComponent();	
		}
		
		void Button_CancelClick(object sender, EventArgs e)
		{
			// Close configuration, don't save
			
			this.Close();
		}
		
		void Button_OKClick(object sender, EventArgs e)
		{
			// Save configuration and close
			
			try
			{
				NotificationIcon.cfgAutoStart = checkBox_AutoStart.Checked;
				NotificationIcon.cfgEnabled = checkBox_Enabled.Checked;
				NotificationIcon.cfgMonitorOff = checkBox_Monitor_Off.Checked;
				NotificationIcon.cfgSleepOnStart = checkBox_SleepOnStartup.Checked;
				NotificationIcon.cfgSleepOnStartDelay = Convert.ToInt32(textBox_SleepOnStartDelay.Text);
				NotificationIcon.cfgSleepDelay = Convert.ToInt32(textBox_SleepDelay.Text);
				NotificationIcon.WriteAllSettings();
				this.Close();
			}
			
			catch
			{
				MessageBox.Show("Error Writing Configuration");
			}
			

		}
		
		void ConfigurationFormLoad(object sender, EventArgs e)
		{
			// Set controls to current settings
			
			try
			{
				checkBox_AutoStart.Checked = NotificationIcon.cfgAutoStart;
				checkBox_Enabled.Checked = NotificationIcon.cfgEnabled;
				checkBox_Monitor_Off.Checked = NotificationIcon.cfgMonitorOff;
				checkBox_SleepOnStartup.Checked = NotificationIcon.cfgSleepOnStart;
				textBox_SleepDelay.Text = NotificationIcon.cfgSleepDelay.ToString();
				textBox_SleepOnStartDelay.Text = NotificationIcon.cfgSleepOnStartDelay.ToString();
			}
			
			catch (ConfigurationErrorsException)
			{
				MessageBox.Show("Error Reading Configuration");
				this.Close();
			}
		}
	}
}
