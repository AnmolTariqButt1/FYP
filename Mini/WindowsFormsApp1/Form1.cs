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
using Microsoft.VisualBasic;

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
		int Id = 0;

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			fName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			 lName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			 Contact.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			RegNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			    Gender = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			 
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

		private void ClearData()
		{
			fName.Text = "";
			lName.Text = "";
			Email.Text = "";
		Contact.Text = "";
			Gender = "";
			RegNo.Text = "";


		}

		private void button1_Click(object sender, EventArgs e)
		{


			con.Open();
			SqlCommand reg = new SqlCommand("SELECT COUNT(RegistrationNo) FROM Student WHERE (RegistrationNo = @registration)", con);
			reg.Parameters.AddWithValue("@registration", RegNo.Text);
			int exists = (int)reg.ExecuteScalar();
			con.Close();
			if (exists > 0)
			{
				MessageBox.Show("Student is already registered");
			}
			else
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
					string q = "insert into Student(Id, RegistrationNo) values('" + value1 + "','" + RegNo.Text + "')";
					SqlDataAdapter SDA1 = new SqlDataAdapter(q, con);
					int i = SDA1.SelectCommand.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Student is registered successfully", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();

				}
				else
				{
					MessageBox.Show("Fill all the Fields", "Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}


			
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

			if (fName.Text != "" && lName.Text != "" && Email.Text != "" && dateTimePicker1.Text != ""  && Contact.Text != "")
			{
			 SqlCommand	cmd = new SqlCommand("UPDATE Person set FirstName=@firstName,LastName=@lastName, Contact=@Contact,  Email=@email, DateOfBirth=@dob, Gender=@gender where Id=@id", con);
				
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.Parameters.AddWithValue("@firstName", fName.Text);
				cmd.Parameters.AddWithValue("@lastName", lName.Text);
				cmd.Parameters.AddWithValue("@Contact", Contact.Text);
				cmd.Parameters.AddWithValue("@reg", RegNo.Text);
				cmd.Parameters.AddWithValue("@email", Email.Text);
				cmd.Parameters.AddWithValue("@dob",DateTime.Parse( dateTimePicker1.Text));
				string g = Gender.ToString();
				int gender = GetGenderFromLookup(g);
				cmd.Parameters.AddWithValue("@gender", gender);

				cmd.ExecuteNonQuery();


				SqlCommand cmd1 = new SqlCommand("UPDATE Student set RegistrationNo = @reg where Id=@id", con);
				cmd1.Parameters.AddWithValue("@id", Id);
				cmd1.Parameters.AddWithValue("@reg", RegNo.Text);
				cmd1.ExecuteNonQuery();
				con.Close();
				
			
				
					MessageBox.Show("Data updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				

				}
				

		
			else
				MessageBox.Show("Select Data to Update!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			con.Close();
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
				e.Cancel = true;
				Email.Focus();
				MessageBox.Show("Please Enter Valid Email!");

			}
		}

		private void RegNo_Validating(object sender, CancelEventArgs e)
		{
			
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

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			Advisor adv = new Advisor();
			adv.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Form1 stu = new Form1();
			stu.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Project pro = new Project();
			pro.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Evaluation eval = new Evaluation();
			eval.Show();
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

		private void button3_Click(object sender, EventArgs e)
		{
			if (Id != 0)
			{
				SqlCommand cmd = new SqlCommand("delete Person where ID=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", Id);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data Deleted Successfully!");
				
				ClearData();
			}

			else
			{
				MessageBox.Show("Please Select Data to Delete");
			}
		
	}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}
	}
}
