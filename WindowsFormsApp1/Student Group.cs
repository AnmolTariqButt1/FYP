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
	public partial class Student_Group : Form
	{
		public Student_Group()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");


		private void Student_Group_Load(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}


		int Id = 0;
		private void ClearData()
		{
			Date.Text = "";


		}

		private void Save_Click(object sender, EventArgs e)
		{
			if (Date.Text != "")
			{
				con.Open();
				String query = " INSERT INTO [Group](Created_On) VALUES('" + Date.Text + "')";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				SDA.SelectCommand.ExecuteNonQuery();
				con.Close();
				ClearData();
				MessageBox.Show("Group created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Fill the required Field", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}



		}

		private void View_Click(object sender, EventArgs e)
		{
			con.Open();

			String query = "SELECT Id,Created_On  FROM [Group]";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
	}
}
