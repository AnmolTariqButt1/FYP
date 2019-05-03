using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 home = new Form1();
			home.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Advisor adv = new Advisor();
			adv.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Project p = new Project();
			p.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Evaluation eval = new Evaluation();
			eval.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Student_Group sg = new Student_Group();
			sg.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			AssignAdvisor aa = new AssignAdvisor();
			aa.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			GroupProject gp = new GroupProject();
			gp.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			GroupEvaluation ge = new GroupEvaluation();
			ge.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			PDF pdf = new PDF();
			pdf.Show();
		}

		private void Home_Load(object sender, EventArgs e)
		{

		}
	}
}
