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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		string Gender;
		public Form1()
		{
			InitializeComponent();
			
		}
		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


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
			if (fName.Text != "" && lName.Text != "" && RegNo.Text != "" && Gender != "" && Email.Text != "" && Contact.Text != "")
			{
				con.Open();
				int gender = GetGenderFromLookup(Gender);

				String query = " INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES('" + fName.Text + "','" + lName.Text + "','" + Contact.Text + "','" + Email.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + gender + "')";
				SqlDataAdapter SDA = new SqlDataAdapter(query, con);
				SDA.SelectCommand.ExecuteNonQuery();

				int value1 = 0;
				string query1 = "Select Id from Person where (Id = SCOPE_IDENTITY())";
				SqlCommand cmd = new SqlCommand(query1, con);
				var v = cmd.ExecuteScalar().ToString();
				value1 = int.Parse(v);
				string q = "insert into Student values('" + value1 + "','" + Reg.Text.ToString() + "')";
				SqlCommand cmd1 = new SqlCommand(q, con);
				int i = cmd1.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Student is registered successfully", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
				

			}
			else
			{
				MessageBox.Show("Fill all the fields");
			}
		
			




		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void fName_TextChanged(object sender, EventArgs e)
		{

		}

		private void lName_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Male_CheckedChanged(object sender, EventArgs e)
		{
			Gender = "Male";
		}

		private void Female_CheckedChanged(object sender, EventArgs e)
		{
			Gender = "Female";
		}

		private void View_Click(object sender, EventArgs e)
		{
			con.Open();
		
			String query = "SELECT Person.Id, FirstName, LastName, RegistrationNo, Contact, Email, DateOfBirth, Gender FROM Person JOIN Student ON Person.Id=Student.Id";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			con.Open();
			int gender = GetGenderFromLookup(Gender);
			string query = "UPDATE Person SET FirstName = '"+fName+ "',LastName = '" + lName.Text + "',Contact='" + Contact.Text + "',Email='" + Email.Text + "',DateOfBirth='" + DateTime.Parse(dateTimePicker1.Text) + "',Gender='" + gender + "'";
			SqlDataAdapter SDA = new SqlDataAdapter(query, con);

			SDA.SelectCommand.ExecuteNonQuery();

			con.Close();
			MessageBox.Show("Updated sucessfully!");

		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{ }

		private void Contact_TextChanged(object sender, EventArgs e)
		{
			

		}

		private void Email_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void fName_Validating(object sender, CancelEventArgs e)
		{

		}

		private void Email_Validating(object sender, CancelEventArgs e)
		{
			if (!Regex.IsMatch(Email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
			{
				MessageBox.Show("Enter valid Email address");
				Email.SelectAll();
				e.Cancel = true;
			}
		}

		private void RegNo_Validating(object sender, CancelEventArgs e)
		{
			if (!Regex.Match(RegNo.Text, "^[0-9]{4}-[A-Z]{2}-[0-9]{2,3}$").Success)
			{

				MessageBox.Show("Please Enter Registration Number  of the format 2016-CE-62");
				RegNo.SelectAll();
				e.Cancel = true;

			}
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
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
