using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;


namespace dis_klinigi
{
    public partial class frmlogin : Form
    {

        SqlConnection con; //= new SqlConnection("Data Source= CIHAD;Initial Catalog=proje;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public frmlogin()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '*';
        }
        private string HashSifre(string sifre)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void giris()
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ býrakýlamaz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = txtkullanici.Text;
            string girilenSifre = txtsifre.Text;
            string hashlenmisGirilenSifre = HashSifre(girilenSifre);

            string veritabanindakiHash = null;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Sifre FROM login_tbl WHERE KullaniciAdi = @KullaniciAdi", con))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            veritabanindakiHash = result.ToString();
                        }
                        con.Close();
                    }


                    if (veritabanindakiHash != null && veritabanindakiHash == hashlenmisGirilenSifre)
                    {
                        MessageBox.Show("Giriþ Baþarýlý! Güzel Bir Ýþ Günü Dileriz :)", "Giriþ Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý Adý Veya Þifre Yanlýþ Lütfen Tekrar Deneyin", "Giriþ Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Sil();
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Veritabanýna baðlanýrken bir hata oluþtu: {sqlex.Message}", "SQL Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmedik bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

        }
        private void Sil()
        {
            txtkullanici.Clear();
            txtsifre.Clear();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void txtsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamayý kapatmak istiyor musunuz?", "Kapanýyor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chcsifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsifre.Checked)
            {
                txtsifre.PasswordChar = '\0';
            }
            else
                txtsifre.PasswordChar = '*';
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtkullanici.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("Kullanýcý yönetimi bölümüne eriþmek için lütfen kullanýcý adý ve þifrenizi girin.", "Giriþ Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string kullaniciAdi = txtkullanici.Text;
            string girilenSifre = txtsifre.Text;
            string hashlenmisGirilenSifre = HashSifre(girilenSifre);

            string veritabanindakiHash = null;
            bool yetkiliKullanici = false;
            using (SqlConnection con = DbConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Sifre FROM login_tbl WHERE KullaniciAdi = @KullaniciAdi", con))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            veritabanindakiHash = result.ToString();
                        }
                        con.Close();
                    }

                    if (veritabanindakiHash != null && veritabanindakiHash == hashlenmisGirilenSifre)
                    {
                        yetkiliKullanici = true;
                    }

                    if (yetkiliKullanici)
                    {
                        var dialogResult = MessageBox.Show("Kullanýcý Düzenleme Bölümüne eriþmek istediðinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            kullanici_ekle klnc = new kullanici_ekle();
                            klnc.Show();
                            // this.Hide(); // Login formunu açýk býrakabilirsin, kullanýcý ekleme formu modal deðilse.
                            Sil(); // Giriþ bilgilerini temizle
                        }
                        else
                        {
                            MessageBox.Show("Ýþlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Sil();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý Adý Ve/Veya Þifre yanlýþ! Kullanýcý düzenleme bölümüne sadece yetkili kiþiler eriþebilir.", "Yetkisiz Eriþim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Sil();
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show($"Veritabaný hatasý: {sqlex.Message}", "SQL Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
        private void frmlogin_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblsifre_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

            
                
            
