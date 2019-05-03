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
			{
				con.Open();
				String query = " INSERT INTO [Group](Created_On) VALUES('" + DateTime.Parse(Date.Text) + "')";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				SDA.SelectCommand.ExecuteNonQuery();
				con.Close();
				ClearData();
				MessageBox.Show("Group created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void button1_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Assignment home = new Assignment();
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
			AssignAdvisor h = new AssignAdvisor();
			h.Show();
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

		private void button4_Click(object sender, EventArgs e)
		{
			con.Open();


				SqlCommand cmd = new SqlCommand("UPDATE [Group] set Created_On=@dob,  where Id=@id", con);

				cmd.Parameters.AddWithValue("@id", Id);
			
				cmd.Parameters.AddWithValue("@dob", DateTime.Parse(Date.Text));
				
				cmd.ExecuteNonQuery();

			
				con.Close();



				MessageBox.Show("Data updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


			
		
	}

		private void Student_Group_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
