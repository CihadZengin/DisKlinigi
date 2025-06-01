using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;


namespace dis_klinigi
{
    public partial class detayform : Form
    {
        private string _hastaTC;
        private int _hastaID;
        public detayform()
        {
            InitializeComponent();

        }
        public detayform(string hastaTC, int hastaID)
        {
            InitializeComponent();
            _hastaID = hastaID;
            _hastaTC = hastaTC;
            this.Shown += detayform_Shown;
        }

        private void detayform_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT HastaTCNumarasi, HastaAdi, HastaSoyadi, Girdi as Ödenen, Cıktı as Kalan, Tarih " +
                                   "FROM GirdiCıktı_tbl " +
                                   "INNER JOIN BorcTbl ON BID = BorcID " +
                                   "INNER JOIN Hastalar_tbl ON HIID = HastaID " +
                                   "WHERE HastaID = @hastaID";

                    // SqlCommand ve SqlDataAdapter için de 'using' blokları kullanmak en iyi pratiktir.
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hastaID", _hastaID);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            // conn.Open() ve conn.Close() demeye gerek yok, SqlDataAdapter bunu kendi yönetir.
                            da.Fill(dt);
                            dgvDetaylar.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Detaylar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void detayform_Shown(object sender, EventArgs e)
        {
            dgvDetaylar.BackgroundColor = Color.FromArgb(240, 240, 240);
            dgvDetaylar.GridColor = Color.FromArgb(224, 224, 224);

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            defaultCellStyle.SelectionForeColor = Color.White;
            defaultCellStyle.Padding = new Padding(5, 2, 5, 2);
            dgvDetaylar.DefaultCellStyle = defaultCellStyle;

            DataGridViewCellStyle alternatingCellStyle = new DataGridViewCellStyle();
            alternatingCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            alternatingCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            alternatingCellStyle.SelectionBackColor = Color.FromArgb(62, 162, 229);
            alternatingCellStyle.SelectionForeColor = Color.White;
            dgvDetaylar.AlternatingRowsDefaultCellStyle = alternatingCellStyle;

            dgvDetaylar.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.ForestGreen;     // Sütun başlıkları arka planı (koyu gri)
            columnHeaderStyle.ForeColor = Color.White;                  // Sütun başlıkları yazı rengi
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.TopLeft; // Başlıkları ortala
            columnHeaderStyle.Padding = new Padding(5, 5, 5, 5); // Başlık içi dolgu
            dgvDetaylar.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDetaylar.ColumnHeadersHeight = 30;

            dgvDetaylar.BorderStyle = BorderStyle.None; // Kenar çerçevesi stili
            dgvDetaylar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }


        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                // PDF dosyasını nereye kaydedeceğini seçtir
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF olarak kaydet";
                saveFileDialog.FileName = "GirdiCiktiRaporu.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // PDF belgesi oluştur
                    Document document = new Document(PageSize.A4, 20, 20, 20, 20);
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();

                    // Başlık
                    var baslikFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    Paragraph title = new Paragraph("Hasta Girdi - Çıktı Raporu", baslikFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    document.Add(new Paragraph("\n")); // Boşluk

                    // Tablo
                    PdfPTable table = new PdfPTable(dgvDetaylar.Columns.Count);
                    table.WidthPercentage = 100;

                    // Başlıkları ekle
                    var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                    foreach (DataGridViewColumn column in dgvDetaylar.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headerFont));
                        cell.BackgroundColor = new BaseColor(230, 230, 230); // Gri arka plan
                        table.AddCell(cell);
                    }

                    // Verileri ekle
                    var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                    foreach (DataGridViewRow row in dgvDetaylar.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value != null ? cell.Value.ToString() : "";
                                table.AddCell(new Phrase(value, cellFont));
                            }
                        }
                    }

                    document.Add(table);
                    document.Close();

                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturulurken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
