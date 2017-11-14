using RobotView;

namespace TestDrive
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mainMenu1;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.driveView1 = new RobotView.DriveView();
			this.commonRunParameters1 = new RobotView.CommonRunParameters();
			this.SuspendLayout();
			// 
			// driveView1
			// 
			this.driveView1.Location = new System.Drawing.Point(18, 16);
			this.driveView1.Name = "driveView1";
			this.driveView1.Size = new System.Drawing.Size(597, 256);
			this.driveView1.TabIndex = 0;
			// 
			// commonRunParameters1
			// 
			this.commonRunParameters1.Location = new System.Drawing.Point(18, 292);
			this.commonRunParameters1.Name = "commonRunParameters1";
			this.commonRunParameters1.Size = new System.Drawing.Size(597, 214);
			this.commonRunParameters1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(872, 708);
			this.Controls.Add(this.commonRunParameters1);
			this.Controls.Add(this.driveView1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private DriveView driveView1;
		private CommonRunParameters commonRunParameters1;
	}
}

