namespace WindowsFormsApp1
{
	partial class GroupProject
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
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.projectCombo = new System.Windows.Forms.ComboBox();
			this.groupCombo = new System.Windows.Forms.ComboBox();
			this.Save = new System.Windows.Forms.Button();
			this.View = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.groupCombo);
			this.groupBox1.Controls.Add(this.projectCombo);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(-6, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 259);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(67, 118);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 22);
			this.label8.TabIndex = 7;
			this.label8.Text = "Group";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Project Title";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(304, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Group Project";
			// 
			// projectCombo
			// 
			this.projectCombo.FormattingEnabled = true;
			this.projectCombo.Location = new System.Drawing.Point(288, 71);
			this.projectCombo.Name = "projectCombo";
			this.projectCombo.Size = new System.Drawing.Size(183, 21);
			this.projectCombo.TabIndex = 8;
			// 
			// groupCombo
			// 
			this.groupCombo.FormattingEnabled = true;
			this.groupCombo.Location = new System.Drawing.Point(288, 121);
			this.groupCombo.Name = "groupCombo";
			this.groupCombo.Size = new System.Drawing.Size(183, 21);
			this.groupCombo.TabIndex = 9;
			this.groupCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// Save
			// 
			this.Save.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Save.Location = new System.Drawing.Point(39, 267);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 27;
			this.Save.Text = "Save";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// View
			// 
			this.View.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.View.Location = new System.Drawing.Point(679, 267);
			this.View.Name = "View";
			this.View.Size = new System.Drawing.Size(75, 23);
			this.View.TabIndex = 28;
			this.View.Text = "View";
			this.View.UseVisualStyleBackColor = true;
			this.View.Click += new System.EventHandler(this.View_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-6, 296);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(794, 158);
			this.dataGridView1.TabIndex = 29;
			// 
			// GroupProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(787, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.View);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.groupBox1);
			this.Name = "GroupProject";
			this.Text = "GroupProject";
			this.Load += new System.EventHandler(this.GroupProject_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox groupCombo;
		private System.Windows.Forms.ComboBox projectCombo;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.Button View;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}