namespace WindowsFormsApp1
{
	partial class Assignment
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
			this.status = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.Female = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tMarks = new System.Windows.Forms.Label();
			this.tWtg = new System.Windows.Forms.Label();
			this.group = new System.Windows.Forms.TextBox();
			this.student = new System.Windows.Forms.TextBox();
			this.Save = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.status);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.Female);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tMarks);
			this.groupBox1.Controls.Add(this.tWtg);
			this.groupBox1.Controls.Add(this.group);
			this.groupBox1.Controls.Add(this.student);
			this.groupBox1.Location = new System.Drawing.Point(2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(796, 239);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(258, 160);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(175, 20);
			this.status.TabIndex = 22;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(259, 203);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
			this.dateTimePicker1.TabIndex = 21;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(538, 145);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(77, 22);
			this.radioButton2.TabIndex = 20;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "InActive";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Female
			// 
			this.Female.AutoSize = true;
			this.Female.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Female.Location = new System.Drawing.Point(538, 88);
			this.Female.Name = "Female";
			this.Female.Size = new System.Drawing.Size(64, 22);
			this.Female.TabIndex = 19;
			this.Female.TabStop = true;
			this.Female.Text = "Active";
			this.Female.UseVisualStyleBackColor = true;
			this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(79, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Assignment";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(304, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 36);
			this.label2.TabIndex = 0;
			this.label2.Text = "Assignment";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tMarks
			// 
			this.tMarks.AutoSize = true;
			this.tMarks.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tMarks.Location = new System.Drawing.Point(79, 116);
			this.tMarks.Name = "tMarks";
			this.tMarks.Size = new System.Drawing.Size(64, 22);
			this.tMarks.TabIndex = 2;
			this.tMarks.Text = "Student";
			// 
			// tWtg
			// 
			this.tWtg.AutoSize = true;
			this.tWtg.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tWtg.Location = new System.Drawing.Point(79, 160);
			this.tWtg.Name = "tWtg";
			this.tWtg.Size = new System.Drawing.Size(54, 22);
			this.tWtg.TabIndex = 1;
			this.tWtg.Text = "Status";
			this.tWtg.Click += new System.EventHandler(this.tWtg_Click);
			// 
			// group
			// 
			this.group.Location = new System.Drawing.Point(259, 66);
			this.group.Name = "group";
			this.group.Size = new System.Drawing.Size(174, 20);
			this.group.TabIndex = 5;
			// 
			// student
			// 
			this.student.Location = new System.Drawing.Point(259, 119);
			this.student.Name = "student";
			this.student.Size = new System.Drawing.Size(175, 20);
			this.student.TabIndex = 3;
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(49, 247);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 13;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(239, 247);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "Update";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(441, 247);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 15;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(663, 247);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 22;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(2, 276);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(796, 172);
			this.dataGridView1.TabIndex = 23;
			// 
			// Assignment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.View);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.groupBox1);
			this.Name = "Assignment";
			this.Text = "Assignment";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label tMarks;
		private System.Windows.Forms.Label tWtg;
		private System.Windows.Forms.TextBox group;
		private System.Windows.Forms.TextBox student;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton Female;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox status;
	}
}