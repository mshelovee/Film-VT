using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fim_VT_96
{
    public partial class TumFilmlerForm : Form
    {
        string baglanti = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        string yeniAd;
        public TumFilmlerForm()
        {
            InitializeComponent();
        }

        private void dgwTumFilmler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwTumFilmler.SelectedCells.Count > 0)
            {
                txtAd.Text = dgwTumFilmler.SelectedRows[0].Cells["film_ad"].Value.ToString();
                txtYonetmen.Text = dgwTumFilmler.SelectedRows[0].Cells["yonetmen"].Value.ToString();
                txtYil.Text = dgwTumFilmler.SelectedRows[0].Cells["yil"].Value.ToString();
                cmbTur.SelectedValue = dgwTumFilmler.SelectedRows[0].Cells["tur"].Value.ToString();
                txtSure.Text = dgwTumFilmler.SelectedRows[0].Cells["sure"].Value.ToString();
                // txtPoster.Text = dgwTumFilmler.SelectedRows[0].Cells["poster"].Value.ToString();
                txtPuan.Text = dgwTumFilmler.SelectedRows[0].Cells["imdb_puan"].Value.ToString();
                cbOdul.Checked = Convert.ToBoolean(dgwTumFilmler.SelectedRows[0].Cells["film_odul"].Value);

                string dosyaYolu = Path.Combine(Environment.CurrentDirectory, "poster", dgwTumFilmler.SelectedRows[0].Cells["poster"].Value.ToString());

                pbResim.Image = null;
                if (File.Exists(dosyaYolu))
                {
                    pbResim.Image = Image.FromFile(dosyaYolu);
                    pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }

        }

        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM filmler;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwTumFilmler.DataSource = dt;

            }
        }

        private void TumFilmlerForm_Load(object sender, EventArgs e)
        {
            DgwDoldur();
            CmbDoldur();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string sorgu = " SELECT * FROM filmler WHERE film_ad LIKE @aranan;";
            if (rbFilmAd.Checked)
            {
                sorgu = "SELECT * FROM filmler WHERE film_Ad LIKE @aranan;";
            }

            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@aranan", "%" + txtArama.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwTumFilmler.DataSource = dt;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwTumFilmler.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Filmi silmek istediğinizden emin misiniz?",
                                                 "Filmi sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int film_id = Convert.ToInt32(dgwTumFilmler.SelectedRows[0].Cells["film_id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM filmler WHERE film_id=@film_id;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@film_id", film_id);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "UPDATE filmler SET film_ad=@film_ad, yonetmen = @yonetmen, yil = @yil, tur=@tur, sure= @sure, poster = @poster, imdb_puan = @imdb_puan, film_odul = @film_odul WHERE film_id = @film_id";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@film_ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@yonetmen", txtYonetmen.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);               
                cmd.Parameters.AddWithValue("@imdb_puan",Convert.ToDouble(txtPuan.Text));
                cmd.Parameters.AddWithValue("@film_odul", cbOdul.Checked);
                int film_id = Convert.ToInt32(dgwTumFilmler.SelectedRows[0].Cells["film_id"].Value);
                cmd.Parameters.AddWithValue("@film_id", film_id);
                cmd.Parameters.AddWithValue("@poster", yeniAd); 

                cmd.ExecuteNonQuery();
                DgwDoldur();

            }
        }

        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT tur FROM filmler;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbTur.DataSource = dt;

                cmbTur.DisplayMember = "tur";
                cmbTur.ValueMember = "tur";

            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "poster", yeniAd);

            File.Copy(kaynakDosya,hedefDosya);

            pbResim.Image = null;
            if (File.Exists(hedefDosya))
            {
                pbResim.Image = Image.FromFile(hedefDosya);
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
