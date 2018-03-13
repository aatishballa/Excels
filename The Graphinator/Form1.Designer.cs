namespace The_Graphinator
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
			this.T_Equation = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.T_Start = new System.Windows.Forms.TextBox();
			this.T_End = new System.Windows.Forms.TextBox();
			this.T_Interval = new System.Windows.Forms.TextBox();
			this.C_Dim = new System.Windows.Forms.ComboBox();
			this.T_IntervalY = new System.Windows.Forms.TextBox();
			this.T_EndY = new System.Windows.Forms.TextBox();
			this.T_StartY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// T_Equation
			// 
			this.T_Equation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_Equation.Location = new System.Drawing.Point(72, 476);
			this.T_Equation.Name = "T_Equation";
			this.T_Equation.Size = new System.Drawing.Size(494, 26);
			this.T_Equation.TabIndex = 1;
			this.T_Equation.TextChanged += new System.EventHandler(this.T_Equation_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(15, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(628, 455);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(572, 476);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Graph";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(572, 515);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(71, 28);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Save";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 516);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Start X:";
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(178, 514);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "End X:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(344, 515);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Interval:";
			// 
			// T_Start
			// 
			this.T_Start.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_Start.Location = new System.Drawing.Point(89, 515);
			this.T_Start.Name = "T_Start";
			this.T_Start.Size = new System.Drawing.Size(85, 26);
			this.T_Start.TabIndex = 8;
			// 
			// T_End
			// 
			this.T_End.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_End.Location = new System.Drawing.Point(253, 515);
			this.T_End.Name = "T_End";
			this.T_End.Size = new System.Drawing.Size(85, 26);
			this.T_End.TabIndex = 9;
			// 
			// T_Interval
			// 
			this.T_Interval.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_Interval.Location = new System.Drawing.Point(424, 515);
			this.T_Interval.Name = "T_Interval";
			this.T_Interval.Size = new System.Drawing.Size(85, 26);
			this.T_Interval.TabIndex = 10;
			// 
			// C_Dim
			// 
			this.C_Dim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C_Dim.FormattingEnabled = true;
			this.C_Dim.Items.AddRange(new object[] {
            "y=",
            "z="});
			this.C_Dim.Location = new System.Drawing.Point(16, 475);
			this.C_Dim.Name = "C_Dim";
			this.C_Dim.Size = new System.Drawing.Size(50, 28);
			this.C_Dim.TabIndex = 11;
			this.C_Dim.SelectedIndexChanged += new System.EventHandler(this.C_Dim_SelectedIndexChanged);
			// 
			// T_IntervalY
			// 
			this.T_IntervalY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_IntervalY.Location = new System.Drawing.Point(424, 560);
			this.T_IntervalY.Name = "T_IntervalY";
			this.T_IntervalY.Size = new System.Drawing.Size(85, 26);
			this.T_IntervalY.TabIndex = 17;
			this.T_IntervalY.Visible = false;
			// 
			// T_EndY
			// 
			this.T_EndY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_EndY.Location = new System.Drawing.Point(253, 559);
			this.T_EndY.Name = "T_EndY";
			this.T_EndY.Size = new System.Drawing.Size(85, 26);
			this.T_EndY.TabIndex = 16;
			this.T_EndY.Visible = false;
			// 
			// T_StartY
			// 
			this.T_StartY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.T_StartY.Location = new System.Drawing.Point(89, 556);
			this.T_StartY.Name = "T_StartY";
			this.T_StartY.Size = new System.Drawing.Size(85, 26);
			this.T_StartY.TabIndex = 15;
			this.T_StartY.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(344, 559);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Interval:";
			this.label1.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(180, 559);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "End Y:";
			this.label5.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 555);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Start Y:";
			this.label6.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(19, 596);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(624, 23);
			this.progressBar1.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 631);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.T_IntervalY);
			this.Controls.Add(this.T_EndY);
			this.Controls.Add(this.T_StartY);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.C_Dim);
			this.Controls.Add(this.T_Interval);
			this.Controls.Add(this.T_End);
			this.Controls.Add(this.T_Start);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.T_Equation);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(691, 670);
			this.Name = "Form1";
			this.Text = "The Graphinator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox T_Equation;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox T_Start;
		private System.Windows.Forms.TextBox T_End;
		private System.Windows.Forms.TextBox T_Interval;
		private System.Windows.Forms.ComboBox C_Dim;
		private System.Windows.Forms.TextBox T_IntervalY;
		private System.Windows.Forms.TextBox T_EndY;
		private System.Windows.Forms.TextBox T_StartY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

