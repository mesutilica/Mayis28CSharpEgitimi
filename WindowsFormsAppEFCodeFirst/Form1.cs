using System;
using System.Windows.Forms;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            KayitListele();
        }
        void KayitListele()
        {
            DGVUrunListesi.DataSource = productDal.GetAll();
            txtAra.Text = "";
            TxtStokMiktari.Text = "";
            TxtUrunAdi.Text = "";
            TxtUrunFiyati.Text = "";
            cbDurum.Checked = false;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUrunAdi.Text) || string.IsNullOrWhiteSpace(TxtUrunFiyati.Text) || string.IsNullOrWhiteSpace(TxtStokMiktari.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }
            try
            {
                var urun = new Product
                {
                    UrunAdi = TxtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text),
                    Durum = cbDurum.Checked
                };
                var sonuc = productDal.Add(urun);
                if (sonuc > 0)
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void DGVUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var urun = productDal.Find(Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value.ToString()));
            if (urun != null)
            {
                TxtUrunAdi.Text = urun.UrunAdi;
                TxtUrunFiyati.Text = urun.UrunFiyati.ToString();
                TxtStokMiktari.Text = urun.StokMiktari.ToString();
                cbDurum.Checked = urun.Durum;
            }
            BtnGuncelle.Enabled = true;
            BtnSil.Enabled = true;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUrunAdi.Text) || string.IsNullOrWhiteSpace(TxtUrunFiyati.Text) || string.IsNullOrWhiteSpace(TxtStokMiktari.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }
            try
            {
                var urun = new Product
                {
                    Id = Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value),
                    UrunAdi = TxtUrunAdi.Text,
                    StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                    UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text),
                    Durum = cbDurum.Checked
                };
                var sonuc = productDal.Update(urun);
                if (sonuc > 0)
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var urun = new Product
                    {
                        Id = Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value)
                    };
                    productDal.Delete(urun);
                    KayitListele();
                    MessageBox.Show("Ürün Başarıyla Silindi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
