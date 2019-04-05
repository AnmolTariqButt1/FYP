using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
	public partial class PDF : Form
	{

		SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;User ID=sa;Password=Anmoltariqbutt");


		public PDF()
		{
			InitializeComponent();
		}

		private void PDF_Load(object sender, EventArgs e)
		{
			{
				DataTable dt = new DataTable();
				con.Open();
				String query = "SELECT Title AS 'Projects', FirstName+ ' ' + LastName AS 'Advisors'  , (SELECT Value FROM [Lookup] WHERE [Lookup].Id = AdvisorRole AND Category = 'ADVISOR_ROLE') AS 'Role', AssignmentDate FROM ((Project JOIN ProjectAdvisor ON ProjectId = Id) JOIN Advisor ON AdvisorId = Advisor.Id) JOIN Person ON Person.Id = Advisor.Id";
				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataAdapter SDA = new SqlDataAdapter();
				SDA.SelectCommand = cmd;
				SDA.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
		}

			public void exportGridToPDF(DataGridView dataGridView, string filename)
			{
				BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
				PdfPTable pdftable = new PdfPTable(dataGridView.Columns.Count);
				pdftable.DefaultCell.Padding = 3;
				pdftable.WidthPercentage = 100;
				pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
				pdftable.DefaultCell.BorderWidth = 1;
				iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
				//Add header
				foreach (DataGridViewColumn col in dataGridView.Columns)
				{
					PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
					cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
					pdftable.AddCell(cell);
				}


				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
					}
				}

				var savefiledialoge = new SaveFileDialog();
				savefiledialoge.FileName = filename;
				savefiledialoge.DefaultExt = ".pdf";
				if (savefiledialoge.ShowDialog() == DialogResult.OK)
				{
					using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
					{
						Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
						PdfWriter.GetInstance(pdfdoc, stream);
						pdfdoc.Open();
						string str = string.Format("Date: {0}", DateTime.Now);
						pdfdoc.Add(pdftable);
						pdfdoc.Close();
						stream.Close();
					}
				}

			
		}

		private void Save_Click(object sender, EventArgs e)
		{
			exportGridToPDF(dataGridView1, "PDF");
		}
	}
}
