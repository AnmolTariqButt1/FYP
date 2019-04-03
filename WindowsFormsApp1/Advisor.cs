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
			if (fName.Text != "" && lName.Text != "" && Contact.Text != "" && Email.Text != "" && sal.Text != "" && Contact.Text != "")
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


			}
			else
			{
				MessageBox.Show("Fill all the fields");
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
	}
}
