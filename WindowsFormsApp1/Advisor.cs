using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Advisor : Form
	{
		public Advisor()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");


		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}


		private void ClearData()
		{
			fName.Text = "";
			lName.Text = "";
			Contact.Text = "";
			Email.Text = "";
			comboBox1.Text = "";
			sal.Text = "";


		}


		string Gender;


		private int GetGenderFromLookup(string gen)
		{
			int value = 0;
			string q;
			if (gen == "Male")
				q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = '" + gen + "'";
			else
				q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = 'Female'";
			if (con.State == ConnectionState.Closed)
			{

				con.Open();
			}
			SqlCommand cmd = new SqlCommand(q, con);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				value = int.Parse(reader[0].ToString());
			}

			return value;
		}




		private void button1_Click(object sender, EventArgs e)
		{
			if (fName.Text != "" && lName.Text != "" && Contact.Text != "" && Email.Text != "" && sal.Text != "" && Contact.Text != "" && comboBox1.Text != "")
			{
				con.Open();
				int gender = GetGenderFromLookup(Gender);
				

				String query = " INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + fName.Text + "','" + lName.Text + "','" + Contact.Text + "','" + Email.Text + "','" + DateTime.Parse(DOB.Text) + "','" + gender + "')";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				SDA.SelectCommand.ExecuteNonQuery();

				int value1 = 0;
				
				string query1 = "Select Id from Person where (Id = SCOPE_IDENTITY())";
				SqlCommand cmd = new SqlCommand(query1, con);
				var v = cmd.ExecuteScalar().ToString();
				value1 = int.Parse(v);
		
				string q = "insert into Advisor values('" + value1 + "',(SELECT Id FROM Lookup WHERE Category = 'DESIGNATION' AND Value = '"+ comboBox1.Text +"'),'" + sal.Text +"')";
				SqlCommand cmd1 = new SqlCommand(q, con);
				int i = cmd1.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Advisor is registered successfully", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearData();

			}
			else
			{
				MessageBox.Show("Fill all the Fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void fName_TextChanged(object sender, EventArgs e)
		{

		}

		private void Female_CheckedChanged(object sender, EventArgs e)
		{
			Gender = "Female";
		}


		private void Male_CheckedChanged(object sender, EventArgs e)
		{
			Gender = " Male";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			con.Open();

			String query = "SELECT Person.Id AS 'Advisor ID', FirstName, LastName, Contact, Email, DateOfBirth, Gender, Designation, Salary FROM Person JOIN Advisor ON Person.Id=Advisor.Id";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
		int Id = 0;

		int selectedRow;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//selectedRow = e.RowIndex;

			Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			fName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			lName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			Email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			DOB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			Gender = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			sal.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			con.Close();
			con.Open();

			SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM Advisor", con);
			int c = Convert.ToInt32(count.ExecuteScalar().ToString());
			if (fName.Text != "" && lName.Text != "" && Contact.Text != "" && Email.Text != "" && sal.Text != "" &&  comboBox1.Text != "")
			{
				if (c != 0)
				{
					SqlCommand designation = new SqlCommand("SELECT Id FROM LookUp WHERE Category = 'DESIGNATION' AND Value = '" + comboBox1.Text + "'", con);
					int d = Convert.ToInt32(designation.ExecuteScalar().ToString());
					int gender = GetGenderFromLookup(Gender);
					DataGridViewRow row = new DataGridViewRow();
					row = dataGridView1.Rows[selectedRow];
					row.Cells[1].Value = fName.Text;
					row.Cells[2].Value = lName.Text;
					row.Cells[3].Value = Contact.Text;
					row.Cells[4].Value = Email.Text;
					row.Cells[5].Value = DateTime.Parse(DOB.Text);
					row.Cells[6].Value = d;
					row.Cells[7].Value = sal.Text;
					row.Cells[8].Value = gender;



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
				MessageBox.Show("Fill all the Fields!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

		private void Contact_Validating(object sender, CancelEventArgs e)
		{
			Regex validator = new Regex("^[0-9]{10,12}$");
			string match = validator.Match(Contact.Text).Value.ToString();
			if (match.Length != 11)
			{
				MessageBox.Show("invalid phone number. Enter 0-11 digits");
				Contact.Focus();

			}
			else
			{
				e.Cancel = false;
			}
		}

		private void Email_Validating(object sender, CancelEventArgs e)
		{
			if (!Regex.IsMatch(Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
			{
				e.Cancel = true;
				Email.Focus();
				MessageBox.Show("Please Enter Valid Email!");

			

		}
		}
	}
}
