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
	public partial class GroupEvaluation : Form
	{
		public GroupEvaluation()
		{
			InitializeComponent();
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}


		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");



		private void Save_Click(object sender, EventArgs e)
		{

			if (obtMarks.Text != "")
			{
				con.Open();


				string query = "INSERT into GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ( (SELECT Id FROM [Group] WHERE [Group].Id = '" + groupCombo.Text + "' ), (Select Id FROM Evaluation WHERE Evaluation.Name = '" + evaluationCombo.Text + "'),'" + obtMarks.Text + "', '" + DateTime.Now + "')";
		
				SqlCommand cmd = new SqlCommand(query, con);
				



				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
				MessageBox.Show("Fill all the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			
		}

		private void GroupEvaluation_Load(object sender, EventArgs e)
		{
			SqlDataAdapter SDA = new SqlDataAdapter("Select * FROM [Group]", con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				groupCombo.Items.Add(dt.Rows[i]["Id"]);
			}

			SqlDataAdapter SDA1 = new SqlDataAdapter("Select Name FROM Evaluation", con);
			DataTable dt1 = new DataTable();
			SDA1.Fill(dt1);
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				evaluationCombo.Items.Add(dt1.Rows[i]["Name"]);
			}

		}

		private void View_Click(object sender, EventArgs e)
		{

			con.Open();

			String query = "SELECT * FROM GroupEvaluation ";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
	}
}
