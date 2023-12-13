/*
 * Date: 5/30/2016
 * Time: 11:40 AM
 * Created by Tim Pequignot
 * http://peq.me/
*/
namespace CarPC_Power_Event_Handler
{
	partial class CountdownForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Sleep;
		public System.Windows.Forms.Label label_Countdown;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountdownForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label_Countdown = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.button_Sleep = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(454, 70);
			this.label1.TabIndex = 1;
			this.label1.Text = "System running on battery power. \r\nGoing to sleep in:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Countdown
			// 
			this.label_Countdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.label_Countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Countdown.Location = new System.Drawing.Point(12, 105);
			this.label_Countdown.Name = "label_Countdown";
			this.label_Countdown.Size = new System.Drawing.Size(454, 66);
			this.label_Countdown.TabIndex = 2;
			this.label_Countdown.Text = "0";
			this.label_Countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.button_Cancel);
			this.panel1.Controls.Add(this.button_Sleep);
			this.panel1.Location = new System.Drawing.Point(12, 185);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(454, 72);
			this.panel1.TabIndex = 3;
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(320, 5);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(131, 64);
			this.button_Cancel.TabIndex = 1;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.Button_CancelClick);
			// 
			// button_Sleep
			// 
			this.button_Sleep.Location = new System.Drawing.Point(3, 5);
			this.button_Sleep.Name = "button_Sleep";
			this.button_Sleep.Size = new System.Drawing.Size(131, 64);
			this.button_Sleep.TabIndex = 0;
			this.button_Sleep.Text = "Sleep Now";
			this.button_Sleep.UseVisualStyleBackColor = true;
			this.button_Sleep.Click += new System.EventHandler(this.Button_SleepClick);
			// 
			// CountdownForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 269);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label_Countdown);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CountdownForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CarPC Power Event Handler";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountdownFormFormClosing);
			this.Load += new System.EventHandler(this.CountdownFormLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

	}
}
