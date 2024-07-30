using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsAppEFCodeFirst.Entities;

namespace WindowsFormsAppEFCodeFirst
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        UrunDbContext context = new UrunDbContext(); // Kategori veritabanı CRUD(ekle-güncelle-sil-listele) işlemlerini yapabilmek için context nesnesi oluşturduk
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            DGVKategoriler.DataSource = context.Categories.ToList();
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
                return; // eğer kategori adı boşsa geri dön aşağıdaki kodları çalıştırma
            }
            try
            {
                Category kategori = new Category()
                {
                    Durum = cbDurum.Checked,
                    KategoriAdi = txtKategoriAdi.Text
                };
                context.Categories.Add(kategori); // context üzerindeki Categories tablosuna üstteki kategoriyi ekle
                var sonuc = context.SaveChanges(); // eklenen kategoriyi veritabanına kaydet
                if (sonuc > 0) // eğer kayıt veritabanına işlenmişse
                {
                    Yukle(); // ekrandaki verileri yeniden yükle
                    MessageBox.Show("Kayıt Başarılı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void DGVKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)// DGVKategoriler ekrandaki data grid view
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
                int id = Convert.ToInt32(DGVKategoriler.CurrentRow.Cells[0].Value);
                var kategori = context.Categories.Find(id); // veritabanındaki kategorilerden güncellenecek olanı id sine göre bul
                kategori.Durum = cbDurum.Checked; // bulduğun kategorinin değerlerini ekrandan gelenle değiştir
                kategori.KategoriAdi = txtKategoriAdi.Text;
                var sonuc = context.SaveChanges(); // değişiklikleri veritabanına kaydet
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
                int id = Convert.ToInt32(DGVKategoriler.CurrentRow.Cells[0].Value);
                var kategori = context.Categories.Find(id);
                context.Categories.Remove(kategori);
                var sonuc = context.SaveChanges(); // değişiklikleri veritabanına kaydet
                if (sonuc > 0)
                {
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
