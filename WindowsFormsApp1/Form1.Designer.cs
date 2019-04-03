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
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(755, 252);
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
			this.label7.Location = new System.Drawing.Point(407, 161);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 22);
			this.label7.TabIndex = 20;
			this.label7.Text = "Gender";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// RegNo
			// 
			this.RegNo.Location = new System.Drawing.Point(184, 205);
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
			this.Reg.Location = new System.Drawing.Point(41, 205);
			this.Reg.Name = "Reg";
			this.Reg.Size = new System.Drawing.Size(124, 22);
			this.Reg.TabIndex = 5;
			this.Reg.Text = "Registration No.";
			// 
			// Female
			// 
			this.Female.AutoSize = true;
			this.Female.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Female.Location = new System.Drawing.Point(617, 161);
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
			this.Male.Location = new System.Drawing.Point(531, 161);
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
			this.dateTimePicker1.Location = new System.Drawing.Point(531, 117);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
			this.dateTimePicker1.TabIndex = 14;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(531, 72);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(186, 20);
			this.Email.TabIndex = 12;
			this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
			this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
			// 
			// lName
			// 
			this.lName.Location = new System.Drawing.Point(184, 120);
			this.lName.Name = "lName";
			this.lName.Size = new System.Drawing.Size(186, 20);
			this.lName.TabIndex = 10;
			this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
			// 
			// Contact
			// 
			this.Contact.Location = new System.Drawing.Point(184, 164);
			this.Contact.Name = "Contact";
			this.Contact.Size = new System.Drawing.Size(186, 20);
			this.Contact.TabIndex = 9;
			this.Contact.TextChanged += new System.EventHandler(this.Contact_TextChanged);
			this.Contact.Validating += new System.ComponentModel.CancelEventHandler(this.Contact_Validating);
			// 
			// fName
			// 
			this.fName.Location = new System.Drawing.Point(184, 75);
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
			this.label5.Location = new System.Drawing.Point(407, 118);
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
			this.label4.Location = new System.Drawing.Point(407, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(42, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contact";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(0, 287);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(755, 148);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(31, 258);
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
			this.button2.Location = new System.Drawing.Point(241, 258);
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
			this.button3.Location = new System.Drawing.Point(436, 258);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(652, 258);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 4;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 437);
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
	}
}

