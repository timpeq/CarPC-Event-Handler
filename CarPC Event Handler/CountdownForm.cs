/*
 * Date: 5/30/2016
 * Time: 11:40 AM
 * Created by Tim Pequignot
 * http://peq.me/
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarPC_Power_Event_Handler
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	/// 
	public partial class CountdownForm : Form
	{
		
		public Timer timerSleep = new System.Windows.Forms.Timer();

		public int intCountdown;
		
		public CountdownForm()	
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
		}
		
		void Button_CancelClick(object sender, EventArgs e)
		{
			if (timerSleep != null)
			{
				timerSleep.Stop();
			}
			this.Close();
		}

		void TimerOnTick(object sender, EventArgs e)
		{
			intCountdown--;
			label_Countdown.Text = intCountdown.ToString();
			if (intCountdown == 0)
			{
				timerSleep.Stop();
				NotificationIcon.MonitorOff();
				this.Close();
			}
		}
		
		void CountdownFormLoad(object sender, EventArgs e)
		{
			intCountdown = NotificationIcon.intCountdownTime;
			label_Countdown.Text = intCountdown.ToString();
			timerSleep.Tick += new EventHandler(TimerOnTick); 	
        	timerSleep.Interval = 1000; 
        	timerSleep.Start();	
		}
		
		void Button_SleepClick(object sender, EventArgs e)
		{
			timerSleep.Stop();
			NotificationIcon.MonitorOff();
			this.Close();
		}
		
		void CountdownFormFormClosing(object sender, FormClosingEventArgs e)
		{
			timerSleep.Stop();
		}
	}
}
