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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button8 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
			this.groupBox1.Location = new System.Drawing.Point(145, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(763, 282);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.Contact.Validating += new System.ComponentModel.CancelEventHandler(this.Contact_Validating);
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(207, 205);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(193, 20);
			this.Email.TabIndex = 14;
			this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
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
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(145, 294);
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
			this.button2.Location = new System.Drawing.Point(771, 294);
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
			this.button3.Location = new System.Drawing.Point(574, 294);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Update
			// 
			this.Update.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update.Location = new System.Drawing.Point(343, 294);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 22;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(142, 323);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(763, 194);
			this.dataGridView1.TabIndex = 23;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(3, 159);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(134, 33);
			this.button8.TabIndex = 6;
			this.button8.Text = "Advisor";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(3, 82);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(134, 33);
			this.button4.TabIndex = 0;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(3, 121);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(134, 32);
			this.button7.TabIndex = 3;
			this.button7.Text = "Student";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(3, 198);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(134, 33);
			this.button9.TabIndex = 7;
			this.button9.Text = "Projects";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(3, 238);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(134, 32);
			this.button10.TabIndex = 8;
			this.button10.Text = "Evaluation";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.Location = new System.Drawing.Point(3, 276);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(134, 33);
			this.button11.TabIndex = 9;
			this.button11.Text = "Group";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Location = new System.Drawing.Point(3, 317);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(134, 33);
			this.button12.TabIndex = 10;
			this.button12.Text = "Group Advisor";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(3, 356);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(134, 33);
			this.button13.TabIndex = 11;
			this.button13.Text = "Group Project";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button14
			// 
			this.button14.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.Location = new System.Drawing.Point(3, 396);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(134, 32);
			this.button14.TabIndex = 12;
			this.button14.Text = "Group Evaluation";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.button14, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.button13, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.button12, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.button11, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.button10, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.button9, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.button8, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 12;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 511);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(116, 50);
			this.label10.TabIndex = 14;
			this.label10.Text = "FYP";
			// 
			// Advisor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(903, 514);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Advisor";
			this.Text = "Advisor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
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
		private System.Windows.Forms.RadioButton Female;
		private System.Windows.Forms.RadioButton Male;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.DateTimePicker DOB;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label10;
	}
}