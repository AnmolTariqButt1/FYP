namespace WindowsFormsApp1
{
	partial class Project
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
			this.Title = new System.Windows.Forms.Label();
			this.Description = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Save = new System.Windows.Forms.Button();
			this.Update = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.Location = new System.Drawing.Point(48, 71);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(43, 22);
			this.Title.TabIndex = 0;
			this.Title.Text = "Title";
			// 
			// Description
			// 
			this.Description.AutoSize = true;
			this.Description.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Description.Location = new System.Drawing.Point(49, 131);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(90, 22);
			this.Description.TabIndex = 1;
			this.Description.Text = "Description";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(148, 321);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(731, 194);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(182, 71);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(201, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(182, 131);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(201, 86);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(173, 290);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 4;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// Update
			// 
			this.Update.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Update.Location = new System.Drawing.Point(368, 290);
			this.Update.Name = "Update";
			this.Update.Size = new System.Drawing.Size(75, 23);
			this.Update.TabIndex = 5;
			this.Update.Text = "Update";
			this.Update.UseVisualStyleBackColor = true;
			this.Update.Click += new System.EventHandler(this.Update_Click);
			// 
			// Delete
			// 
			this.Delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Location = new System.Drawing.Point(578, 292);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 6;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(778, 286);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 7;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Title);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.Description);
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Location = new System.Drawing.Point(145, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(763, 282);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(287, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Projects";
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 4);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 50);
			this.label4.TabIndex = 26;
			this.label4.Text = "FYP";
			// 
			// Project
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(874, 516);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.View);
			this.Controls.Add(this.Update);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Project";
			this.Text = "Project";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Project_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button Update;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
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