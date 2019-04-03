namespace WindowsFormsApp1
{
	partial class Advisor
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.DOB = new System.Windows.Forms.DateTimePicker();
			this.Female = new System.Windows.Forms.RadioButton();
			this.Male = new System.Windows.Forms.RadioButton();
			this.lName = new System.Windows.Forms.TextBox();
			this.Contact = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.TextBox();
			this.sal = new System.Windows.Forms.TextBox();
			this.fName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.DOB);
			this.groupBox1.Controls.Add(this.Female);
			this.groupBox1.Controls.Add(this.Male);
			this.groupBox1.Controls.Add(this.lName);
			this.groupBox1.Controls.Add(this.Contact);
			this.groupBox1.Controls.Add(this.Email);
			this.groupBox1.Controls.Add(this.sal);
			this.groupBox1.Controls.Add(this.fName);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 259);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// DOB
			// 
			this.DOB.Location = new System.Drawing.Point(568, 67);
			this.DOB.Name = "DOB";
			this.DOB.Size = new System.Drawing.Size(193, 20);
			this.DOB.TabIndex = 19;
			// 
			// Female
			// 
			this.Female.AutoSize = true;
			this.Female.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Female.Location = new System.Drawing.Point(649, 203);
			this.Female.Name = "Female";
			this.Female.Size = new System.Drawing.Size(67, 22);
			this.Female.TabIndex = 18;
			this.Female.TabStop = true;
			this.Female.Text = "Female";
			this.Female.UseVisualStyleBackColor = true;
			this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
			// 
			// Male
			// 
			this.Male.AutoSize = true;
			this.Male.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Male.Location = new System.Drawing.Point(568, 206);
			this.Male.Name = "Male";
			this.Male.Size = new System.Drawing.Size(55, 22);
			this.Male.TabIndex = 17;
			this.Male.TabStop = true;
			this.Male.Text = "Male";
			this.Male.UseVisualStyleBackColor = true;
			this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
			// 
			// lName
			// 
			this.lName.Location = new System.Drawing.Point(207, 115);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(193, 20);
			this.lName.TabIndex = 16;
			this.lName.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
			// 
			// Contact
			// 
			this.Contact.Location = new System.Drawing.Point(207, 160);
			this.Contact.Name = "Contact";
			this.Contact.Size = new System.Drawing.Size(193, 20);
			this.Contact.TabIndex = 15;
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(207, 205);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(193, 20);
			this.Email.TabIndex = 14;
			// 
			// sal
			// 
			this.sal.Location = new System.Drawing.Point(568, 160);
			this.sal.Name = "sal";
			this.sal.Size = new System.Drawing.Size(193, 20);
			this.sal.TabIndex = 11;
			// 
			// fName
			// 
			this.fName.Location = new System.Drawing.Point(207, 71);
			this.fName.Name = "fName";
			this.fName.Size = new System.Drawing.Size(193, 20);
			this.fName.TabIndex = 9;
			this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(67, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 22);
			this.label9.TabIndex = 8;
			this.label9.Text = "Last Name";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(67, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 22);
			this.label8.TabIndex = 7;
			this.label8.Text = "Contact";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(67, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 22);
			this.label7.TabIndex = 6;
			this.label7.Text = "Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(441, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "Date Of Birth";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(441, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Designation";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(441, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Salary";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(441, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gender";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(304, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Advisor";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 300);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(794, 176);
			this.dataGridView1.TabIndex = 19;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(47, 271);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(662, 271);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "View";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(448, 271);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(235, 271);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "Update";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Assistant Professor",
            "Lecturer",
            "Industry Professor"});
			this.comboBox1.Location = new System.Drawing.Point(568, 113);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(193, 21);
			this.comboBox1.TabIndex = 20;
			// 
			// Advisor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 475);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Advisor";
			this.Text = "Advisor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox lName;
		private System.Windows.Forms.TextBox Contact;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.TextBox sal;
		private System.Windows.Forms.TextBox fName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RadioButton Female;
		private System.Windows.Forms.RadioButton Male;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DateTimePicker DOB;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}