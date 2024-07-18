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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            // DGVUrunListesi.DataSource = productDal.GetAll(); // List metoduyla veri listeleme
            //DGVUrunListesi.DataSource = productDal.GetAllDataTable();
            KayitListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DGVUrunListesi.DataSource = productDal.GetAllDataTable(txtAra.Text);
        }
        void KayitListele()
        {
            DGVUrunListesi.DataSource = productDal.GetAllDataTable();
            txtAra.Text = "";
            TxtStokMiktari.Text = "";
            TxtUrunAdi.Text = "";
            TxtUrunFiyati.Text = "";
            cbDurum.Checked = false;
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
                int sonuc = productDal.Add(urun);
                if (sonuc > 0) // kayıt başarılı
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void DGVUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ekrandaki listeden seçilen satırdaki bilgileri yakalama
            /*
            TxtUrunAdi.Text = DGVUrunListesi.CurrentRow.Cells[1].Value.ToString();
            TxtUrunFiyati.Text = DGVUrunListesi.CurrentRow.Cells[2].Value.ToString();
            TxtStokMiktari.Text = DGVUrunListesi.CurrentRow.Cells[3].Value.ToString();
            cbDurum.Checked = Convert.ToBoolean(DGVUrunListesi.CurrentRow.Cells[4].Value);
            */
            // Ürün bilgisini Get metoduyla veritabanından getirme
            var urun = productDal.Get(Convert.ToInt32(DGVUrunListesi.CurrentRow.Cells[0].Value.ToString()));
            if (urun != null)
            {
                TxtUrunAdi.Text = urun.UrunAdi;
                TxtUrunFiyati.Text = urun.UrunFiyati.ToString();
                TxtStokMiktari.Text = urun.StokMiktari.ToString();
                cbDurum.Checked = urun.Durum;
            }
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
                int sonuc = productDal.Update(urun);
                if (sonuc > 0) // kayıt başarılı
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
