namespace RobotView
{
	partial class RunLineView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 52);
			this.label1.Text = "RunLine";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(307, 52);
			this.label2.Text = "Length (+/- mm)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(327, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 52);
			this.button1.TabIndex = 2;
			this.button1.Text = "+/-";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(613, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 52);
			this.button2.TabIndex = 3;
			this.button2.Text = "Start";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(439, 52);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(142, 48);
			this.numericUpDown1.TabIndex = 4;
			// 
			// RunLineView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "RunLineView";
			this.Size = new System.Drawing.Size(834, 155);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
