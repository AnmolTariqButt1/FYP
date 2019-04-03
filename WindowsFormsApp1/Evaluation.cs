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
			if (name.Text != "" && marks.Text != "" && Wtg.Text != "")
			{
				con.Open();
				string query = "INSERT into Evaluation(Name, TotalMarks, TotalWeightage) VALUES ('" + name.Text + "','" + marks.Text + "','" + Wtg.Text + "')";
					SqlDataAdapter cmd = new SqlDataAdapter(query, con);
					
					

					cmd.SelectCommand.ExecuteNonQuery();
				MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearData();

			}
			else
				MessageBox.Show("Fill all the fields!");
		}

		private void View_Click(object sender, EventArgs e)
		{
			con.Close();
			con.Open();

			String query = "SELECT Id,Name,TotalMarks,TotalWeightage  FROM Evaluation";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			marks.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			Wtg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (name.Text != "" && marks.Text != "" && Wtg.Text != "")
			{
				SqlCommand cmd = new SqlCommand("UPDATE Evaluation SET Name=@name1,TotalMarks=@tmarks, TotalWeightage = @tWtg WHERE Id=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.Parameters.AddWithValue("@name1", name.Text);
				cmd.Parameters.AddWithValue("@tMarks", marks.Text);
				cmd.Parameters.AddWithValue("@tWtg", Wtg.Text);


				cmd.ExecuteNonQuery();
				MessageBox.Show("Data updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				con.Close();

				ClearData();
			}
			else
			{
				MessageBox.Show("Please Select Data to Update");
			}

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
	}
}
