namespace WindowsFormsApp1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.RegNo = new System.Windows.Forms.TextBox();
			this.Reg = new System.Windows.Forms.Label();
			this.Female = new System.Windows.Forms.RadioButton();
			this.Male = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Email = new System.Windows.Forms.TextBox();
			this.lName = new System.Windows.Forms.TextBox();
			this.Contact = new System.Windows.Forms.TextBox();
			this.fName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.RegNo);
			this.groupBox1.Controls.Add(this.Reg);
			this.groupBox1.Controls.Add(this.Female);
			this.groupBox1.Controls.Add(this.Male);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.Email);
			this.groupBox1.Controls.Add(this.lName);
			this.groupBox1.Controls.Add(this.Contact);
			this.groupBox1.Controls.Add(this.fName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(140, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(763, 282);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(244, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(225, 36);
			this.label6.TabIndex = 21;
			this.label6.Text = "Student Registration";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(443, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 22);
			this.label7.TabIndex = 20;
			this.label7.Text = "Gender";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// RegNo
			// 
			this.RegNo.Location = new System.Drawing.Point(187, 222);
			this.RegNo.Name = "RegNo";
			this.RegNo.Size = new System.Drawing.Size(186, 20);
			this.RegNo.TabIndex = 18;
			this.RegNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
			this.RegNo.Validating += new System.ComponentModel.CancelEventHandler(this.RegNo_Validating);
			// 
			// Reg
			// 
			this.Reg.AutoSize = true;
			this.Reg.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Reg.Location = new System.Drawing.Point(41, 222);
			this.Reg.Name = "Reg";
			this.Reg.Size = new System.Drawing.Size(124, 22);
			this.Reg.TabIndex = 5;
			this.Reg.Text = "Registration No.";
			// 
			// Female
			// 
			this.Female.AutoSize = true;
			this.Female.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Female.Location = new System.Drawing.Point(663, 173);
			this.Female.Name = "Female";
			this.Female.Size = new System.Drawing.Size(67, 22);
			this.Female.TabIndex = 17;
			this.Female.TabStop = true;
			this.Female.Text = "Female";
			this.Female.UseVisualStyleBackColor = true;
			this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
			// 
			// Male
			// 
			this.Male.AutoSize = true;
			this.Male.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Male.Location = new System.Drawing.Point(567, 174);
			this.Male.Name = "Male";
			this.Male.Size = new System.Drawing.Size(55, 22);
			this.Male.TabIndex = 15;
			this.Male.TabStop = true;
			this.Male.Text = "Male";
			this.Male.UseVisualStyleBackColor = true;
			this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(558, 130);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
			this.dateTimePicker1.TabIndex = 14;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(558, 84);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(186, 20);
			this.Email.TabIndex = 12;
			this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
			this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
			// 
			// lName
			// 
			this.lName.Location = new System.Drawing.Point(187, 132);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(186, 20);
			this.lName.TabIndex = 10;
			this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
			// 
			// Contact
			// 
			this.Contact.Location = new System.Drawing.Point(187, 174);
			this.Contact.Name = "Contact";
			this.Contact.Size = new System.Drawing.Size(186, 20);
			this.Contact.TabIndex = 9;
			this.Contact.TextChanged += new System.EventHandler(this.Contact_TextChanged);
			this.Contact.Validating += new System.ComponentModel.CancelEventHandler(this.Contact_Validating);
			// 
			// fName
			// 
			this.fName.Location = new System.Drawing.Point(187, 86);
			this.fName.Name = "fName";
			this.fName.Size = new System.Drawing.Size(186, 20);
			this.fName.TabIndex = 6;
			this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
			this.fName.Validating += new System.ComponentModel.CancelEventHandler(this.fName_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(433, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "Date Of Birth";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(433, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contact";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(148, 317);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(755, 194);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(148, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(390, 288);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(632, 288);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(795, 286);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 4;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 0);
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
			this.tableLayoutPanel1.TabIndex = 5;
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
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(3, 82);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(134, 33);
			this.button4.TabIndex = 0;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(903, 514);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.View);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.TextBox lName;
		private System.Windows.Forms.TextBox Contact;
		private System.Windows.Forms.TextBox fName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton Female;
		private System.Windows.Forms.RadioButton Male;
		private System.Windows.Forms.Label Reg;
		private System.Windows.Forms.TextBox RegNo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
	}
}

