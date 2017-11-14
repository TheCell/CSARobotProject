using RobotView;

namespace TestDrive
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.runArc1 = new RobotView.RunArc();
			this.runTurn1 = new RobotView.RunTurn();
			this.runLine1 = new RobotView.RunLine();
			this.commonRunParameters1 = new RobotView.CommonRunParameters();
			this.driveView1 = new RobotView.DriveView();
			this.radarView1 = new RobotView.RadarView();
			this.SuspendLayout();
			// 
			// runArc1
			// 
			this.runArc1.Location = new System.Drawing.Point(390, 196);
			this.runArc1.Name = "runArc1";
			this.runArc1.Size = new System.Drawing.Size(597, 149);
			this.runArc1.TabIndex = 4;
			// 
			// runTurn1
			// 
			this.runTurn1.Location = new System.Drawing.Point(390, 109);
			this.runTurn1.Name = "runTurn1";
			this.runTurn1.Size = new System.Drawing.Size(597, 81);
			this.runTurn1.TabIndex = 3;
			// 
			// runLine1
			// 
			this.runLine1.Location = new System.Drawing.Point(390, 16);
			this.runLine1.Name = "runLine1";
			this.runLine1.Size = new System.Drawing.Size(597, 86);
			this.runLine1.TabIndex = 2;
			// 
			// commonRunParameters1
			// 
			this.commonRunParameters1.Location = new System.Drawing.Point(18, 292);
			this.commonRunParameters1.Name = "commonRunParameters1";
			this.commonRunParameters1.Size = new System.Drawing.Size(366, 188);
			this.commonRunParameters1.TabIndex = 1;
			// 
			// driveView1
			// 
			this.driveView1.Location = new System.Drawing.Point(18, 16);
			this.driveView1.Name = "driveView1";
			this.driveView1.Size = new System.Drawing.Size(366, 256);
			this.driveView1.TabIndex = 0;
			// 
			// radarView1
			// 
			this.radarView1.Location = new System.Drawing.Point(390, 351);
			this.radarView1.Name = "radarView1";
			this.radarView1.Size = new System.Drawing.Size(597, 81);
			this.radarView1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1537, 995);
			this.Controls.Add(this.radarView1);
			this.Controls.Add(this.runArc1);
			this.Controls.Add(this.runTurn1);
			this.Controls.Add(this.runLine1);
			this.Controls.Add(this.commonRunParameters1);
			this.Controls.Add(this.driveView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private DriveView driveView1;
		private CommonRunParameters commonRunParameters1;
		private RunLine runLine1;
		private RunTurn runTurn1;
		private RunArc runArc1;
		private RadarView radarView1;
	}
}

