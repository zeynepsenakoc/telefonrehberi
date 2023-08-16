using System.Data.SqlClient;
using System.Windows.Forms;
using TelefonRehberi1;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using GrapeCity.Documents.Word;
using System.Data;

namespace TelefonRehberi1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListesiYukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Formun Verileri Silinecek Devam Edilsin Mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;

            }
            Temizle();

        }

        private void Temizle()
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is TextBox && (c as TextBox).ReadOnly == false)
                {
                    c.ResetText();
                }
                if (c is MaskedTextBox)
                {
                    c.ResetText();
                }



            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bilgi.DatabaseYedek();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Bilgi.KisiID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void buKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bilgi.KisiID > 0)
            {

                if (MessageBox.Show("Seçtiðiniz Kiþinin Verileri Kalýcý Olarak Silinecektir. Devam Edilsin Mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;

                }
                else
                {
                    Bilgi.KayitSil(Bilgi.KisiID);
                    Bilgi.KisiID = 0;
                    KisiListesiYukle();

                }
            }
        }

        private void KisiListesiYukle()
        {
            dataGridView1.DataSource = Bilgi.KisiListesiAl("").Tables[0];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //if (txtAdi.Text != string.Empty && maskedTextBox1.Text != string.Empty)

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Bilgi.KisiID = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["ID"].Value);
            SqlConnection con = new SqlConnection(Bilgi.Constr);
            SqlCommand com = new SqlCommand(" select * from kisi Where KisiID=@KisiID", con);
            com.Parameters.AddWithValue("@KisiID", Bilgi.KisiID);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtAdi.Text = dr["KisiAdi"].ToString();
                txtSoyadi.Text = dr["KisiSoyadi"].ToString();
                maskedTextBox1.Text = dr["Telefonu"].ToString();
                txtEPosta.Text = dr["E-Posta"].ToString();
                txtAdresi.Text = dr["Adresi"].ToString();
                maskedTextBox2.Text = dr["T.C. Kimlik No"].ToString();
                dateTimePicker1.Text = dr["Dogum Tarihi"].ToString();




            }
            dr.Close();
            con.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (rbtad.Checked)
            {
                dataGridView1.DataSource = Bilgi.KisiAraAdaGore(txtAra.Text.ToUpper()).Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = Bilgi.KisiAraSoyadaGore(txtAra.Text.ToUpper()).Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }

        }

        private void txtAra_Enter(object sender, EventArgs e)
        {
            txtAra.ResetText();
        }

        private void txtAra_Leave(object sender, EventArgs e)
        {
            txtAra.Text = "Kiþi Ara";
            KisiListesiYukle();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnKayit_Click_1(object sender, EventArgs e)
        {


            DataTable dataSource = (dataGridView1.DataSource as BindingSource)?.DataSource as DataTable;

            if (dataSource != null)
            {
                DataRow newRow = dataSource.NewRow();
                newRow["ADI"] = txtAdi.Text.ToUpper();
                newRow["SOYADI"] = txtSoyadi.Text.ToUpper();
                newRow["TELEFON"] = maskedTextBox1.Text;
                newRow["E-POSTA"] = txtEPosta.Text.ToLower();
                newRow["ADRES"] = txtAdresi.Text.ToUpper();
                newRow["T.C. KÝMLÝK NO"] = maskedTextBox2.Text;
                newRow["DOÐUM TARÝHÝ"] = dateTimePicker1.Value.ToString("dd.MM.yyyy");

                dataSource.Rows.Add(newRow);
                dataGridView1.Refresh();

                Temizle();
            }
            else
            {
                MessageBox.Show("Veri kaynaðý boþ veya uyumsuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {

            DataTable dataSource = (dataGridView1.DataSource as BindingSource)?.DataSource as DataTable;

            if (dataSource != null)
            {
                string filePath = "C:\\Users\\zeyn3\\OneDrive\\Belgeler\\Rehber.xlsx";

                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                    workbookPart.Workbook = new Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new Worksheet(new SheetData());

                    Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                    Sheet sheet = new Sheet() { Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
                    sheets.Append(sheet);

                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                    foreach (DataRow row in dataSource.Rows)
                    {
                        DocumentFormat.OpenXml.Spreadsheet.Row newRow = new DocumentFormat.OpenXml.Spreadsheet.Row();

                        foreach (object cellValue in row.ItemArray)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Cell newCell = new DocumentFormat.OpenXml.Spreadsheet.Cell()
                            {
                                DataType = CellValues.String,
                                CellValue = new CellValue(cellValue?.ToString())


                            };

                            newRow.AppendChild(newCell);
                        }

                        sheetData.AppendChild(newRow);
                    }
                }

                MessageBox.Show("Excel dosyasý baþarýyla oluþturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri kaynaðý boþ veya uyumsuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
