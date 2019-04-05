namespace WindowsFormsApp1
{
	partial class Evaluation
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
			this.label1 = new System.Windows.Forms.Label();
			this.tWtg = new System.Windows.Forms.Label();
			this.tMarks = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.Wtg = new System.Windows.Forms.TextBox();
			this.marks = new System.Windows.Forms.TextBox();
			this.Save = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(79, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tWtg
			// 
			this.tWtg.AutoSize = true;
			this.tWtg.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tWtg.Location = new System.Drawing.Point(79, 173);
			this.tWtg.Name = "tWtg";
			this.tWtg.Size = new System.Drawing.Size(125, 22);
			this.tWtg.TabIndex = 1;
			this.tWtg.Text = "Total Weightage";
			// 
			// tMarks
			// 
			this.tMarks.AutoSize = true;
			this.tMarks.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tMarks.Location = new System.Drawing.Point(79, 119);
			this.tMarks.Name = "tMarks";
			this.tMarks.Size = new System.Drawing.Size(95, 22);
			this.tMarks.TabIndex = 2;
			this.tMarks.Text = "Total Marks";
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(258, 69);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(175, 20);
			this.name.TabIndex = 3;
			// 
			// Wtg
			// 
			this.Wtg.Location = new System.Drawing.Point(259, 173);
			this.Wtg.Name = "Wtg";
			this.Wtg.Size = new System.Drawing.Size(174, 20);
			this.Wtg.TabIndex = 4;
			// 
			// marks
			// 
			this.marks.Location = new System.Drawing.Point(258, 121);
			this.marks.Name = "marks";
			this.marks.Size = new System.Drawing.Size(174, 20);
			this.marks.TabIndex = 5;
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(161, 290);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 6;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.button1_Click);
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(781, 288);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 7;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(581, 288);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Update
			// 
			this.Update.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update.Location = new System.Drawing.Point(357, 290);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 9;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tMarks);
			this.groupBox1.Controls.Add(this.tWtg);
			this.groupBox1.Controls.Add(this.marks);
			this.groupBox1.Controls.Add(this.name);
			this.groupBox1.Controls.Add(this.Wtg);
			this.groupBox1.Location = new System.Drawing.Point(143, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(757, 283);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(304, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 36);
			this.label2.TabIndex = 0;
			this.label2.Text = "Evaluation";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(143, 319);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(748, 194);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
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
			this.tableLayoutPanel1.TabIndex = 25;
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
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 50);
			this.label4.TabIndex = 14;
			this.label4.Text = "FYP";
			// 
			// Evaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(903, 514);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.View);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.button3);
			this.Name = "Evaluation";
			this.Text = "Evaluation";
			this.Load += new System.EventHandler(this.Evaluation_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label tWtg;
		private System.Windows.Forms.Label tMarks;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox Wtg;
		private System.Windows.Forms.TextBox marks;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Label label4;
	}
}