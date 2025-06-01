using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dis_klinigi
{
    public partial class OdemeForm : Form
    {
        private string _hastaTC;
        private int _hastaID;
        private int secilenBorcID = 0;
        public OdemeForm()
        {
            InitializeComponent();
            this.Load += OdemeForm_Load;
        }
        public OdemeForm(string hastaTC, int hastaID)
        {
            InitializeComponent();
            _hastaTC = hastaTC; 
            _hastaID = hastaID;
            this.Load += OdemeForm_Load; 
            this.Shown += Odemeform_Shown;
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            LoadBorcDetaylari();
        }
        private void Odemeform_Shown(object sender, EventArgs e)
        {
            dtgBorcDetaylari.BackgroundColor = Color.FromArgb(240, 240, 240);
            dtgBorcDetaylari.GridColor = Color.FromArgb(224, 224, 224);

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            defaultCellStyle.SelectionForeColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            defaultCellStyle.Padding = new Padding(5, 2, 5, 2);
            dtgBorcDetaylari.DefaultCellStyle = defaultCellStyle;

            DataGridViewCellStyle alternatingCellStyle = new DataGridViewCellStyle();
            alternatingCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            alternatingCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            alternatingCellStyle.SelectionBackColor = Color.FromArgb(62, 162, 229);
            alternatingCellStyle.SelectionForeColor = Color.White;
            dtgBorcDetaylari.AlternatingRowsDefaultCellStyle = alternatingCellStyle;

            dtgBorcDetaylari.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.FromArgb(70, 70, 70);     
            columnHeaderStyle.ForeColor = Color.White;                  
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold); 
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.TopLeft; 
            columnHeaderStyle.Padding = new Padding(5, 5, 5, 5); 
            dtgBorcDetaylari.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dtgBorcDetaylari.ColumnHeadersHeight = 30;

            dtgBorcDetaylari.BorderStyle = BorderStyle.None; 
            dtgBorcDetaylari.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
        private void LoadBorcDetaylari()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    string BorcQuery = "SELECT BorcID, HastaTCNumarasi, toplamtutar, ödenentutar, borctutarı FROM BorcTbl " +
                                       "INNER JOIN Hastalar_tbl ON HastaID = HID WHERE HastaTCNumarasi = @hastaTC";

                    using (SqlCommand cmd = new SqlCommand(BorcQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@hastaTC", _hastaTC);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dtborc = new DataTable();
                            da.Fill(dtborc);
                            dtgBorcDetaylari.DataSource = dtborc;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Borç detayları yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InitializeFormControls(bool enabled)
        {
            txtToplamTutar.ReadOnly = true;
            txtOdenenTutar.ReadOnly = true;
            txtKalanBorc.ReadOnly = true;

            txtYeniOdemeMiktari.Enabled = enabled;
            btnOdemeYap.Enabled = enabled;
        }

        private void dtgBorcDetaylari_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgBorcDetaylari.Rows.Count)
            {
                DataGridViewRow selectedRow = dtgBorcDetaylari.Rows[e.RowIndex];

                try
                {
                    if (selectedRow.Cells["BorcID"].Value != null && selectedRow.Cells["BorcID"].Value != DBNull.Value)
                    {
                        secilenBorcID = Convert.ToInt32(selectedRow.Cells["BorcID"].Value);

                        decimal toplamTutar = selectedRow.Cells["toplamtutar"].Value != DBNull.Value ? Convert.ToDecimal(selectedRow.Cells["toplamtutar"].Value) : 0m;
                        decimal odenenTutar = selectedRow.Cells["ödenentutar"].Value != DBNull.Value ? Convert.ToDecimal(selectedRow.Cells["ödenentutar"].Value) : 0m;
                        decimal kalanBorc = selectedRow.Cells["borctutarı"].Value != DBNull.Value ? Convert.ToDecimal(selectedRow.Cells["borctutarı"].Value) : 0m;

                       
                        txtToplamTutar.Text = toplamTutar.ToString("C2", CultureInfo.GetCultureInfo("tr-TR")); 
                        txtOdenenTutar.Text = odenenTutar.ToString("C2", CultureInfo.GetCultureInfo("tr-TR"));
                        txtKalanBorc.Text = kalanBorc.ToString("C2", CultureInfo.GetCultureInfo("tr-TR"));
                        txtYeniOdemeMiktari.Clear(); 

                        InitializeFormControls(true); 
                        txtYeniOdemeMiktari.Focus(); 
                    }
                    else
                    {
                        MessageBox.Show("Seçilen satırda geçerli bir BorcID bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        InitializeFormControls(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Seçilen borç bilgileri aktarılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    InitializeFormControls(false);
                }
            }
        }
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (secilenBorcID == 0)
            {
                MessageBox.Show("Lütfen önce listeden bir borç kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYeniOdemeMiktari.Text))
            {
                MessageBox.Show("Lütfen ödeme miktarını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYeniOdemeMiktari.Focus();
                return;
            }

            // Kuruş ve para birimi sembollerini temizleyip decimal'a çevirme
            string yeniOdemeStr = txtYeniOdemeMiktari.Text.Replace(CultureInfo.GetCultureInfo("tr-TR").NumberFormat.CurrencySymbol, "").Trim();
            if (!decimal.TryParse(yeniOdemeStr, NumberStyles.Any, CultureInfo.GetCultureInfo("tr-TR"), out decimal yeniOdemeMiktari))
            {
                MessageBox.Show("Lütfen geçerli bir ödeme miktarı girin.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYeniOdemeMiktari.Focus();
                return;
            }

            if (yeniOdemeMiktari <= 0)
            {
                MessageBox.Show("Ödeme miktarı sıfırdan büyük olmalıdır.", "Geçersiz Miktar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYeniOdemeMiktari.Focus();
                return;
            }

            string kalanBorcStr = txtKalanBorc.Text.Replace(CultureInfo.GetCultureInfo("tr-TR").NumberFormat.CurrencySymbol, "").Trim();
            if (!decimal.TryParse(kalanBorcStr, NumberStyles.Any, CultureInfo.GetCultureInfo("tr-TR"), out decimal mevcutKalanBorc))
            {
                MessageBox.Show("Kalan borç değeri okunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yeniOdemeMiktari > mevcutKalanBorc)
            {
                MessageBox.Show("Ödeme miktarı kalan borçtan fazla olamaz.", "Geçersiz Miktar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYeniOdemeMiktari.Focus();
                return;
            }

            // --- VERİTABANI İŞLEMLERİ BAŞLANGICI ---
            // Bağlantıyı DbConnection yardımcımızdan alıyoruz
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 1. GirdiCıktı tablosuna ödeme kaydını ekle
                    string insertGirdiCiktiQuery = @"
                INSERT INTO GirdiCıktı_tbl (BID, HIID, Girdi, Cıktı, Tarih)
                VALUES (@BorcID, @HastaID, @GirdiMiktari, @KalanBorcSonrasi, @OdemeTarihi);";

                    using (SqlCommand cmdGirdiCikti = new SqlCommand(insertGirdiCiktiQuery, connection, transaction))
                    {
                        cmdGirdiCikti.Parameters.AddWithValue("@BorcID", secilenBorcID);
                        cmdGirdiCikti.Parameters.AddWithValue("@HastaID", _hastaID);
                        cmdGirdiCikti.Parameters.AddWithValue("@GirdiMiktari", yeniOdemeMiktari);
                        cmdGirdiCikti.Parameters.AddWithValue("@KalanBorcSonrasi", mevcutKalanBorc - yeniOdemeMiktari);
                        cmdGirdiCikti.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);
                        cmdGirdiCikti.ExecuteNonQuery();
                    }

                    // 2. BorcTbl tablosundaki borç ve ödenen tutarı güncelle
                    string updateBorcQuery = @"
                UPDATE Borctbl
                SET borctutarı = borctutarı - @YeniOdeme,
                    ödenentutar = ödenentutar + @YeniOdeme
                WHERE BorcID = @BorcID;";

                    using (SqlCommand cmdBorcUpdate = new SqlCommand(updateBorcQuery, connection, transaction))
                    {
                        cmdBorcUpdate.Parameters.AddWithValue("@YeniOdeme", yeniOdemeMiktari);
                        cmdBorcUpdate.Parameters.AddWithValue("@BorcID", secilenBorcID);
                        cmdBorcUpdate.ExecuteNonQuery();
                    }

                    // Her şey yolundaysa işlemi onayla
                    transaction.Commit();
                    MessageBox.Show("Ödeme başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. DataGridView'i yenilemek için en temiz yol, mevcut metodu çağırmaktır
                    LoadBorcDetaylari();

                    // Formu temizle ve başlangıç durumuna getir
                    txtYeniOdemeMiktari.Clear();
                    txtToplamTutar.Clear();
                    txtOdenenTutar.Clear();
                    txtKalanBorc.Clear();
                    InitializeFormControls(false);
                    secilenBorcID = 0;
                }
                catch (Exception ex)
                {
                    // Bir hata olursa tüm işlemleri geri al
                    transaction.Rollback();
                    MessageBox.Show("Ödeme kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
