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
	public partial class AssignAdvisor : Form
	{
		public AssignAdvisor()
		{
			InitializeComponent();
		}

		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");



		private void Save_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd0 = new SqlCommand("SELECT COUNT(1) FROM ProjectAdvisor WHERE (AdvisorId = '" + advisor.Text + " ')", con);
			object count1 = cmd0.ExecuteScalar();
			int count = 0;
			if (!(count1 == DBNull.Value))
			{
				count = Convert.ToInt32(count1);
			}

			con.Close();
			if (count == 3)
			{

				MessageBox.Show("No more projects can be advised by this advisor because advisor is already advising 3 projects.");
			}

			else
			{
				if (advisor.Text != "")
				{
					con.Open();


					string query = "INSERT into ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ( (SELECT Id FROM Advisor WHERE Advisor.Id = '" + advisor.Text + "' ), (Select Id FROM Project WHERE Title = '" + comboBox2.Text + "'), (SELECT Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND Value = '" + comboBox1.Text + "'), '" + DateTime.Now + "')";
					//(SELECT Advisor.Id FROM (Person JOIN Advisor ON Advisor.Id = Person.Id)  WHERE FirstName =  @fname And LastName = @lname) 
					SqlCommand cmd = new SqlCommand(query, con);
					//cmd.Parameters.AddWithValue("@fname", fName.Text);
					//cmd.Parameters.AddWithValue("@advisor", adv.Text);
					//cmd.Parameters.AddWithValue("@title", title.Text);
					//cmd.Parameters.AddWithValue("@desig", comboBox1.Text);
					//cmd.Parameters.AddWithValue("@assignment", DateTime.Now);



					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data saved Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();
				}
				else
					MessageBox.Show("Fill all the fields!");

			}
		}
		private void desig_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void AssignAdvisor_Load(object sender, EventArgs e)
		{
			SqlDataAdapter SDA = new SqlDataAdapter("Select * FROM Project", con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				comboBox2.Items.Add(dt.Rows[i]["Title"]);
			}

			

			SqlDataAdapter SDA2 = new SqlDataAdapter("Select * FROM Advisor", con);
			DataTable dt2 = new DataTable();
			SDA.Fill(dt2);
			for (int i = 0; i < dt2.Rows.Count; i++)
			{
				advisor.Items.Add(dt2.Rows[i]["Id"]);
			}
		}

		private void View_Click(object sender, EventArgs e)
		{
			con.Open();

			String query = "SELECT *  FROM [ProjectAdvisor]";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
		int Id = 0;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			   advisor.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			
			comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

		}

		private void ClearData()
		{
			advisor.Text = "";
			comboBox1.Text = "";
			comboBox2.Text = "";


		}


		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd0 = new SqlCommand("SELECT COUNT(1) FROM ProjectAdvisor WHERE (AdvisorId = '" + advisor.Text + " ')", con);
			object count1 = cmd0.ExecuteScalar();
			int count = 0;
			if (!(count1 == DBNull.Value))
			{
				count = Convert.ToInt32(count1);
			}

			con.Close();
			if (count == 3)
			{

				MessageBox.Show("No more projects can be advised by this advisor because advisor is already advising 3 projects.");
			}

			else
			{
				if (advisor.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
				{
					SqlCommand cmd = new SqlCommand("Update ProjectAdvisor set AdvisorId = @AID, ProjectId = @PID, AdvisorRole = @aRole, AssignmentDate = @assn where AdvisorId=@AID AND ProjectId = @PID AND AdvisorRole = @aRole", con);
					con.Open();
					cmd.Parameters.AddWithValue("@AID", advisor.Text);
					cmd.Parameters.AddWithValue("@PID", comboBox1.Text);
					cmd.Parameters.AddWithValue("@aRole", comboBox2.Text);
					cmd.Parameters.AddWithValue("@assn", DateTime.Now);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Updated Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					;
					con.Close();

					ClearData();
				}


				else
					MessageBox.Show("Select Data to Update!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			if (Id != 0)
			{
				SqlCommand cmd = new SqlCommand("DELETE AssignAdvisor WHERE AdvisorId=@id AND ProjectId = @Pid AND AdvisorRole = @role", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", advisor.Text);
				cmd.Parameters.AddWithValue("@pid", comboBox1.Text);
				cmd.Parameters.AddWithValue("@role", comboBox2.Text);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data Deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearData();
			}
			else
			{
				MessageBox.Show("Select Data to Delete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void button4_Click(object sender, EventArgs e)
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

		private void button11_Click(object sender, EventArgs e)
		{
			Student_Group home = new Student_Group();
			home.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Evaluation home = new Evaluation();
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

		private void AssignAdvisor_FormClosed(object sender, FormClosedEventArgs e)
		{
		
		}
	}
}
