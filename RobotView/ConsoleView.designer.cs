namespace RobotView
{
    partial class ConsoleView
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
			this.ledView1 = new RobotView.LedView();
			this.ledView2 = new RobotView.LedView();
			this.ledView3 = new RobotView.LedView();
			this.ledView4 = new RobotView.LedView();
			this.switchView1 = new RobotView.SwitchView();
			this.switchView2 = new RobotView.SwitchView();
			this.switchView3 = new RobotView.SwitchView();
			this.switchView4 = new RobotView.SwitchView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ledView1
			// 
			this.ledView1.Location = new System.Drawing.Point(5, 6);
			this.ledView1.Name = "ledView1";
			this.ledView1.Size = new System.Drawing.Size(40, 40);
			this.ledView1.State = false;
			this.ledView1.TabIndex = 0;
			// 
			// ledView2
			// 
			this.ledView2.Location = new System.Drawing.Point(51, 6);
			this.ledView2.Name = "ledView2";
			this.ledView2.Size = new System.Drawing.Size(40, 40);
			this.ledView2.State = false;
			this.ledView2.TabIndex = 0;
			// 
			// ledView3
			// 
			this.ledView3.Location = new System.Drawing.Point(97, 6);
			this.ledView3.Name = "ledView3";
			this.ledView3.Size = new System.Drawing.Size(40, 40);
			this.ledView3.State = false;
			this.ledView3.TabIndex = 0;
			// 
			// ledView4
			// 
			this.ledView4.Location = new System.Drawing.Point(143, 6);
			this.ledView4.Name = "ledView4";
			this.ledView4.Size = new System.Drawing.Size(40, 40);
			this.ledView4.State = false;
			this.ledView4.TabIndex = 0;
			// 
			// switchView1
			// 
			this.switchView1.Location = new System.Drawing.Point(5, 108);
			this.switchView1.Name = "switchView1";
			this.switchView1.Size = new System.Drawing.Size(40, 80);
			this.switchView1.State = false;
			this.switchView1.TabIndex = 1;
			// 
			// switchView2
			// 
			this.switchView2.Location = new System.Drawing.Point(51, 108);
			this.switchView2.Name = "switchView2";
			this.switchView2.Size = new System.Drawing.Size(40, 80);
			this.switchView2.State = false;
			this.switchView2.TabIndex = 1;
			// 
			// switchView3
			// 
			this.switchView3.Location = new System.Drawing.Point(97, 108);
			this.switchView3.Name = "switchView3";
			this.switchView3.Size = new System.Drawing.Size(40, 80);
			this.switchView3.State = false;
			this.switchView3.TabIndex = 1;
			// 
			// switchView4
			// 
			this.switchView4.Location = new System.Drawing.Point(143, 108);
			this.switchView4.Name = "switchView4";
			this.switchView4.Size = new System.Drawing.Size(40, 80);
			this.switchView4.State = false;
			this.switchView4.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(9, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 29);
			this.label1.Text = "0";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(55, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 29);
			this.label2.Text = "1";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(152, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 29);
			this.label3.Text = "3";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(103, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 29);
			this.label4.Text = "2";
			// 
			// ConsoleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.switchView4);
			this.Controls.Add(this.switchView3);
			this.Controls.Add(this.switchView2);
			this.Controls.Add(this.switchView1);
			this.Controls.Add(this.ledView4);
			this.Controls.Add(this.ledView3);
			this.Controls.Add(this.ledView2);
			this.Controls.Add(this.ledView1);
			this.Name = "ConsoleView";
			this.Size = new System.Drawing.Size(227, 234);
			this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView1;
        private LedView ledView2;
        private LedView ledView3;
        private LedView ledView4;
        private SwitchView switchView1;
        private SwitchView switchView2;
        private SwitchView switchView3;
        private SwitchView switchView4;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}
