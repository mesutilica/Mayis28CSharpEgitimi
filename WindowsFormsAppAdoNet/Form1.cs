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
            DGVUrunListesi.DataSource = productDal.GetAllDataTable();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DGVUrunListesi.DataSource = productDal.GetAllDataTable(txtAra.Text);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var urun = new Product
            {
                UrunAdi = TxtUrunAdi.Text,
                StokMiktari = Convert.ToInt32(TxtStokMiktari.Text),
                UrunFiyati = Convert.ToDecimal(TxtUrunFiyati.Text),
                Durum = cbDurum.Checked
            };
            productDal.Add(urun);
            DGVUrunListesi.DataSource = productDal.GetAllDataTable();
        }
    }
}
