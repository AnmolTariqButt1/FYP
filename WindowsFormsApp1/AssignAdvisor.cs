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
			if (advisor.Text != "")
			{
				con.Open();

				
				string query = "INSERT into ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ( (SELECT Id FROM Advisor WHERE Advisor.Id = '"+advisor.Text+"' ), (Select Id FROM Project WHERE Title = '"+comboBox2.Text+"'), (SELECT Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND Value = '"+comboBox1.Text+"'), '"+DateTime.Now+"')";
				//(SELECT Advisor.Id FROM (Person JOIN Advisor ON Advisor.Id = Person.Id)  WHERE FirstName =  @fname And LastName = @lname) 
				SqlCommand cmd = new SqlCommand(query, con);
				//cmd.Parameters.AddWithValue("@fname", fName.Text);
				//cmd.Parameters.AddWithValue("@advisor", adv.Text);
				//cmd.Parameters.AddWithValue("@title", title.Text);
				//cmd.Parameters.AddWithValue("@desig", comboBox1.Text);
				//cmd.Parameters.AddWithValue("@assignment", DateTime.Now);



				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
				MessageBox.Show("Fill all the fields!");

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
			SqlDataAdapter SDA = new SqlDataAdapter("Select Title FROM Project", con);
			DataTable dt = new DataTable();
			SDA.Fill(dt);
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				comboBox2.Items.Add(dt.Rows[i]["Title"]);
			}
		}
	}
}
