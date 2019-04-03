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
			if(group.Text != "" && student.Text != "")
			{
				con.Open();
				string query = "INSERT into GroupStudent(StudentId, GroupId, Status, AssignmentDate) VALUES ( (Select Id FROM Student WHERE RegistrationNo =  @regNo) , (Select Id FROM [Group] WHERE Id = @id), @stat, @ass)";

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
	}
}
