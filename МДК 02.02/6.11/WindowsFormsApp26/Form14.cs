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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp26
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            string s = "select * from [dbo].[AllOrders] where [Date] between '"+dateTimePicker1.Value+"' and '"+ dateTimePicker2.Value + "'" ;
            Program.connect.Open();
            System.Data.SqlClient.SqlCommand sql = new SqlCommand(s, Program.connect);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {
                string[] str = new string[5];
                str[0] = reader.GetValue(0).ToString().Trim();
                str[1] = reader.GetValue(1).ToString().Trim();
                str[2] = reader.GetValue(2).ToString().Trim();
                str[3] = reader.GetValue(3).ToString().Trim();
                if (Convert.ToBoolean(reader.GetValue(4)) == true)
                {
                    str[4] = "В зале";
                }
                else
                {
                    str[4] = "С собой";
                }
                //str[3] = reader.GetValue(4).ToString().Trim();                       
                dataGridView1.Rows.Add(str);
            }
            Program.connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document,
                new FileStream("result22.pdf", FileMode.Create)
            );

            document.Open();
            PdfPTable table = new PdfPTable(5);

            PdfPCell cell1 = new PdfPCell(new Phrase("id"));
            cell1.BorderWidth = 1;
            //cell.Colspan = 1;
            //cell.Rowspan = 1;
            table.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase("data"));
            cell1.BorderWidth = 1;
            //cell.Colspan = 1;
            //cell.Rowspan = 1;
            table.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase("333"));
            cell1.BorderWidth = 1;
            //cell.Colspan = 1;
            //cell.Rowspan = 1;
            table.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase("44"));
            cell1.BorderWidth = 1;
            //cell.Colspan = 1;
            //cell.Rowspan = 1;
            table.AddCell(cell1);
            cell1 = new PdfPCell(new Phrase("555"));
            cell1.BorderWidth = 1;
            //cell.Colspan = 1;
            //cell.Rowspan = 1;
            table.AddCell(cell1);

            for ( int i=0; i< dataGridView1.RowCount-1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    cell.BorderWidth = 1;
                    //cell.Colspan = 1;
                    //cell.Rowspan = 1;
                    table.AddCell(cell);
                }
            }
            /*  PdfPTable table = new PdfPTable(5);
              PdfPCell cell = new PdfPCell(new Phrase("ТЕКСТ ЯЧЕЙКИ TEX CELLS"));
              cell.BorderWidth = 1;
              cell.Colspan = 3;
              cell.Rowspan = 2;
              table.AddCell(cell);

              cell = new PdfPCell(new Phrase(@"Electronic ticket"));
              cell.BorderWidth = 1;
              cell.PaddingTop = 5;
              cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
              cell.Colspan = 2;
              table.AddCell(cell);

              cell = new PdfPCell(new Phrase(@"Passenger Itinerary/Receipt"));
              cell.BorderWidth = 1;
              cell.PaddingBottom = 15;
              cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
              cell.Colspan = 2;
              table.AddCell(cell);

              cell = new PdfPCell();
              cell.BorderWidth = 1;
              cell.Colspan = 2;
              table.AddCell(cell);

              cell = new PdfPCell(new Phrase(@"JSC URAL AIRLINES"));
              cell.BorderWidth = 1;
              cell.Colspan = 3;
              table.AddCell(cell);

              cell = new PdfPCell();
              cell.BorderWidth = 1;
              table.AddCell(cell);

              cell = new PdfPCell(new Phrase(@"Order number"));
              cell.BorderWidth = 1;
              cell.Colspan = 3;
              table.AddCell(cell);

              cell = new PdfPCell();
              cell.BorderWidth = 1;
              table.AddCell(cell);

              cell = new PdfPCell();
              cell.BorderWidth = 1;
              table.AddCell(cell);

              cell = new PdfPCell(new Phrase(@"Order number for online check-in"));
              cell.BorderWidth = 1;
              cell.Colspan = 3;
              table.AddCell(cell);

              cell = new PdfPCell();
              cell.BorderWidth = 1;
              table.AddCell(cell);
            */

            document.Add(table);
            document.Close();
            writer.Close();

        }
    }
}
