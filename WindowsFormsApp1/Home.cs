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
	}
}
