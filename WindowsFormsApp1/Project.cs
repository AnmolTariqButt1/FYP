using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
	public partial class Project : Form
	{
		public Project()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");


		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		int Id = 0;
		private void ClearData()
		{
			Title.Text = "";
			Description.Text = "";

			
		}

		private void Save_Click(object sender, EventArgs e)
		{
			
			if (Description.Text != "" && Title.Text != "")
	
			{
				con.Open();
				String query = " INSERT INTO Project(Description, Title) VALUES('" + richTextBox1.Text + "','" + textBox1.Text + "')";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				SDA.SelectCommand.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearData();
				
			}
			else
				MessageBox.Show("Fill all the fields!");
		}

		private void View_Click(object sender, EventArgs e)
		{
			con.Open();

			String query = "SELECT Id,Title, Description FROM Project";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void Update_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "" && richTextBox1.Text != "")
			{
				SqlCommand cmd = new SqlCommand("update Project set Description=@desc,Title=@title where Id=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.Parameters.AddWithValue("@desc", richTextBox1.Text);
				cmd.Parameters.AddWithValue("@title", textBox1.Text);

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

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}

		private void Delete_Click(object sender, EventArgs e)
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
