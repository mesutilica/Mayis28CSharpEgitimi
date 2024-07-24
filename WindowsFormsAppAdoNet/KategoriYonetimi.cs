using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNet
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriDAL kategoriDAL = new KategoriDAL();
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            DGVKategoriler.DataSource = kategoriDAL.GetAllDataTable("select * from Categories");
            txtKategoriAdi.Text = string.Empty;
            cbDurum.Checked = false;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnEkle.Enabled = true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return;
            }
            try
            {
                var kategori = new Kategori()
                {
                    Durum = cbDurum.Checked,
                    KategoriAdi = txtKategoriAdi.Text
                };
                var sonuc = kategoriDAL.Add(kategori);
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void DGVKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriAdi.Text = DGVKategoriler.CurrentRow.Cells[1].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(DGVKategoriler.CurrentRow.Cells[2].Value);
            btnEkle.Enabled = false;
            btnSil.Enabled = true;
            btnGuncelle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez!");
                return;
            }
            try
            {
                var kategori = new Kategori()
                {
                    Id = Convert.ToInt32(DGVKategoriler.CurrentRow.Cells[0].Value),
                    Durum = cbDurum.Checked,
                    KategoriAdi = txtKategoriAdi.Text
                };
                var sonuc = kategoriDAL.Update(kategori);
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    kategoriDAL.Delete(Convert.ToInt32(DGVKategoriler.CurrentRow.Cells[0].Value));
                    Yukle();
                    MessageBox.Show("Kayıt Silindi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
