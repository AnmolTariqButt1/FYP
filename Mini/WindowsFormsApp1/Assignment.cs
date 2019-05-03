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
	public partial class Assignment : Form
	{
		public Assignment()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");



		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd0 = new SqlCommand("SELECT COUNT(1) FROM GroupStudent WHERE (GroupId = '" + group.Text + " ')", con);
			object std1 = cmd0.ExecuteScalar();
			int std = 0;
			if (!(std1 == DBNull.Value))
			{
				std = Convert.ToInt32(std1);
			}

			con.Close();
			if (std == 4)
			{

				MessageBox.Show("No more students can be added because this group already contains 4 students.");
			}

			else
			{

				if (group.Text != "" && student.Text != "")
				{
					con.Open();
					string query = "INSERT into GroupStudent(StudentId, GroupId, Status, AssignmentDate) VALUES ( (Select Id FROM Student WHERE RegistrationNo =  @regNo) , (Select Id FROM [Group] WHERE Id = @id),  (Select Id FROM Lookup WHERE Category = 'STATUS' AND Value = @stat), @ass)";

					SqlCommand cmd = new SqlCommand(query, con);
					cmd.Parameters.AddWithValue("@regNo", student.Text);
					cmd.Parameters.AddWithValue("@id", group.Text);
					cmd.Parameters.AddWithValue("@stat", status.Text);
					cmd.Parameters.AddWithValue("@ass", DateTime.Parse(dateTimePicker1.Text));



					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Updated Successfully");
					con.Close();
					MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
					MessageBox.Show("Fill all the fields!");
			}
		}
		private void Female_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void View_Click(object sender, EventArgs e)
		{
			

				con.Open();

				String query = "SELECT * FROM GroupStudent ";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				DataTable dt = new DataTable();
				SDA.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			
		}

		private void tWtg_Click(object sender, EventArgs e)
		{

		}

		private void Assignment_Load(object sender, EventArgs e)
		{
			SqlDataAdapter SDA = new SqlDataAdapter("Select * FROM [Group]", con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				group.Items.Add(dt.Rows[i]["Id"]);
			}


			SqlDataAdapter SDA1 = new SqlDataAdapter("Select * FROM [Student]", con);
			DataTable dt1 = new DataTable();
			SDA1.Fill(dt1);
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				student.Items.Add(dt1.Rows[i]["RegistrationNo"]);
			}


		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			group.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			status.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

			status.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			

		}

		private void button4_Click(object sender, EventArgs e)
		{
			con.Open();

			if (group.Text != "" && status.Text != "" && student.Text != "" )
			{
				SqlCommand cmd = new SqlCommand("UPDATE GroupStudent set GroupId=@firstName,StudentId=@lastName, Status=@Contact,  AssignmentDate=@dob where GroupId=@firstName", con);
				
				cmd.Parameters.AddWithValue("@firstName", group.Text);
				cmd.Parameters.AddWithValue("@lastName", student.Text);
				cmd.Parameters.AddWithValue("@Contact", status.Text);
		 	cmd.Parameters.AddWithValue("@email", DateTime.Parse(dateTimePicker1.Text));
				
				cmd.ExecuteNonQuery();


				con.Close();



				MessageBox.Show("Data updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}



			else
				MessageBox.Show("Select Data to Update!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			con.Close();
		}

		private void Assignment_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
