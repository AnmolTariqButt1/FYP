using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Evaluation : Form
	{
		public Evaluation()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");


		private void label1_Click(object sender, EventArgs e)
		{

		}

		int Id = 0;
		private void ClearData()
		{
			name.Text = "";
			marks.Text = "";
			Wtg.Text = "";


		}

		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand reg = new SqlCommand("SELECT COUNT(*) FROM [Evaluation] WHERE (Name = @user and TotalMarks= @marks and TotalWeightage = @wtg)", con);
			reg.Parameters.AddWithValue("@user", name.Text);
			reg.Parameters.AddWithValue("@marks", marks.Text);
			reg.Parameters.AddWithValue("@wtg", Wtg.Text);
			int UserExist = (int)reg.ExecuteScalar();
			con.Close();
			if (UserExist > 0)
			{
				MessageBox.Show("This Evaluation has already Inserted");
			}
			else
			{
				if (name.Text != "" && marks.Text != "" && Wtg.Text != "")
				{
					con.Open();
					string query = "INSERT into Evaluation(Name, TotalMarks, TotalWeightage) VALUES ('" + name.Text + "','" + marks.Text + "','" + Wtg.Text + "')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);



					cmd.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();

				}
				else
					MessageBox.Show("Fill all the Fields ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void View_Click(object sender, EventArgs e)
		{
			
			con.Open();

			String query = "SELECT Id,Name,TotalMarks,TotalWeightage  FROM Evaluation";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		int selectedRow;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			selectedRow = e.RowIndex;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (name.Text != "" && marks.Text != "" && Wtg.Text != "")
			{
				con.Open();
				SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM Evaluation", con);
				int c = Convert.ToInt32(count.ExecuteScalar().ToString());

				if (c != 0)
				{


					DataGridViewRow row = new DataGridViewRow();
					row = dataGridView1.Rows[selectedRow];
					row.Cells[1].Value = name.Text;
					row.Cells[2].Value = marks.Text;
					row.Cells[3].Value = Wtg.Text;
					con.Close();
					MessageBox.Show("Data updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();

				}
				else
				{
					MessageBox.Show("There is No Data. Insert Data First.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
				MessageBox.Show("Fil all the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Id != 0)
			{
				SqlCommand cmd = new SqlCommand("DELETE Project WHERE ID=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data Deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearData();
			}
			else
			{
				MessageBox.Show("Please Select Data to Delete");
			}
		}

		private void Evaluation_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form1 home = new Form1();
			home.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Advisor home = new Advisor();
			home.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Project home = new Project();
			home.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Evaluation home = new Evaluation();
			home.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
	Student_Group home = new Student_Group();
			home.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			AssignAdvisor home = new AssignAdvisor();
			home.Show();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			GroupProject home = new GroupProject();
			home.Show();
		}

		private void button14_Click(object sender, EventArgs e)
		{
		GroupEvaluation home = new GroupEvaluation();
			home.Show();
		}
	}
}
