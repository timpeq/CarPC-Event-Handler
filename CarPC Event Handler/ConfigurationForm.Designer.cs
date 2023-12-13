/*
 * Created by SharpDevelop.
 * User: Tim
 * Date: 5/26/2016
 * Time: 7:07 PM
 */
namespace CarPC_Power_Event_Handler
{
	partial class ConfigurationForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelControls;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.CheckBox checkBox_Monitor_Off;
		private System.Windows.Forms.CheckBox checkBox_Enabled;
		private System.Windows.Forms.Panel panel1;
		//toStart;
		private System.Windows.Forms.CheckBox checkBox_AutoStart;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.CheckBox checkBox_SleepOnStartup;
		private System.Windows.Forms.TextBox textBox_SleepOnStartDelay;
		private System.Windows.Forms.Label label_Delay;
		private System.Windows.Forms.Label label_Seconds;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_SleepDelay;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
			this.panelControls = new System.Windows.Forms.Panel();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_OK = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_SleepDelay = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label_Seconds = new System.Windows.Forms.Label();
			this.label_Delay = new System.Windows.Forms.Label();
			this.textBox_SleepOnStartDelay = new System.Windows.Forms.TextBox();
			this.checkBox_SleepOnStartup = new System.Windows.Forms.CheckBox();
			this.checkBox_AutoStart = new System.Windows.Forms.CheckBox();
			this.checkBox_Monitor_Off = new System.Windows.Forms.CheckBox();
			this.checkBox_Enabled = new System.Windows.Forms.CheckBox();
			this.panelControls.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControls
			// 
			this.panelControls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.panelControls.AutoSize = true;
			this.panelControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelControls.Controls.Add(this.button_Cancel);
			this.panelControls.Controls.Add(this.button_OK);
			this.panelControls.Location = new System.Drawing.Point(20, 255);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(499, 80);
			this.panelControls.TabIndex = 5;
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(339, 3);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(157, 74);
			this.button_Cancel.TabIndex = 6;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.Button_CancelClick);
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(3, 3);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(162, 74);
			this.button_OK.TabIndex = 4;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.Button_OKClick);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox_SleepDelay);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label_Seconds);
			this.panel1.Controls.Add(this.label_Delay);
			this.panel1.Controls.Add(this.textBox_SleepOnStartDelay);
			this.panel1.Controls.Add(this.checkBox_SleepOnStartup);
			this.panel1.Controls.Add(this.checkBox_AutoStart);
			this.panel1.Controls.Add(this.checkBox_Monitor_Off);
			this.panel1.Controls.Add(this.checkBox_Enabled);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(533, 195);
			this.panel1.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(340, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 24);
			this.label2.TabIndex = 19;
			this.label2.Text = "Seconds";
			// 
			// textBox_SleepDelay
			// 
			this.textBox_SleepDelay.Location = new System.Drawing.Point(249, 36);
			this.textBox_SleepDelay.Name = "textBox_SleepDelay";
			this.textBox_SleepDelay.Size = new System.Drawing.Size(85, 26);
			this.textBox_SleepDelay.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 27);
			this.label1.TabIndex = 17;
			this.label1.Text = "Sleep Delay";
			// 
			// label_Seconds
			// 
			this.label_Seconds.Location = new System.Drawing.Point(340, 166);
			this.label_Seconds.Name = "label_Seconds";
			this.label_Seconds.Size = new System.Drawing.Size(81, 24);
			this.label_Seconds.TabIndex = 16;
			this.label_Seconds.Text = "Seconds";
			// 
			// label_Delay
			// 
			this.label_Delay.Location = new System.Drawing.Point(36, 166);
			this.label_Delay.Name = "label_Delay";
			this.label_Delay.Size = new System.Drawing.Size(211, 27);
			this.label_Delay.TabIndex = 15;
			this.label_Delay.Text = "Sleep On Startup Delay";
			// 
			// textBox_SleepOnStartDelay
			// 
			this.textBox_SleepOnStartDelay.Location = new System.Drawing.Point(249, 166);
			this.textBox_SleepOnStartDelay.Name = "textBox_SleepOnStartDelay";
			this.textBox_SleepOnStartDelay.Size = new System.Drawing.Size(85, 26);
			this.textBox_SleepOnStartDelay.TabIndex = 14;
			// 
			// checkBox_SleepOnStartup
			// 
			this.checkBox_SleepOnStartup.AutoSize = true;
			this.checkBox_SleepOnStartup.Location = new System.Drawing.Point(12, 135);
			this.checkBox_SleepOnStartup.Name = "checkBox_SleepOnStartup";
			this.checkBox_SleepOnStartup.Size = new System.Drawing.Size(158, 24);
			this.checkBox_SleepOnStartup.TabIndex = 12;
			this.checkBox_SleepOnStartup.Text = "Sleep On Startup";
			this.checkBox_SleepOnStartup.UseVisualStyleBackColor = true;
			// 
			// checkBox_AutoStart
			// 
			this.checkBox_AutoStart.AutoSize = true;
			this.checkBox_AutoStart.Location = new System.Drawing.Point(12, 105);
			this.checkBox_AutoStart.Name = "checkBox_AutoStart";
			this.checkBox_AutoStart.Size = new System.Drawing.Size(108, 24);
			this.checkBox_AutoStart.TabIndex = 11;
			this.checkBox_AutoStart.Text = "Auto Start";
			this.checkBox_AutoStart.UseVisualStyleBackColor = true;
			// 
			// checkBox_Monitor_Off
			// 
			this.checkBox_Monitor_Off.AutoSize = true;
			this.checkBox_Monitor_Off.Location = new System.Drawing.Point(12, 75);
			this.checkBox_Monitor_Off.Name = "checkBox_Monitor_Off";
			this.checkBox_Monitor_Off.Size = new System.Drawing.Size(477, 24);
			this.checkBox_Monitor_Off.TabIndex = 10;
			this.checkBox_Monitor_Off.Text = "Monitor Off instead of Standby (Connected Standby on Win8+)";
			this.checkBox_Monitor_Off.UseVisualStyleBackColor = true;
			// 
			// checkBox_Enabled
			// 
			this.checkBox_Enabled.AutoSize = true;
			this.checkBox_Enabled.Location = new System.Drawing.Point(12, 12);
			this.checkBox_Enabled.Name = "checkBox_Enabled";
			this.checkBox_Enabled.Size = new System.Drawing.Size(212, 24);
			this.checkBox_Enabled.TabIndex = 9;
			this.checkBox_Enabled.Text = "Enable Event Processing";
			this.checkBox_Enabled.UseVisualStyleBackColor = true;
			// 
			// ConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(533, 347);
			this.Controls.Add(this.panelControls);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(555, 330);
			this.Name = "ConfigurationForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configuration";
			this.Load += new System.EventHandler(this.ConfigurationFormLoad);
			this.panelControls.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
