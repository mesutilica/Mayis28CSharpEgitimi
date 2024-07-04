using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitim
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;//timer1 nesnesini sayfa yüklenirken aktif hale getiriyoruz
            timer1.Interval = 1000;//timer ın süresini milisaniye cinsinden bu şekile ayarlayabiliriz
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ön yüzdeki timer1 e çift tıkladığımızda bu metot oluşur ve ayarladığımız süreye göre saatin tiktak mantığıyla çalışır ve buradaki kodları çalıştırır.
            Random random = new Random(); // rasgele sayı üreten c# sınıfımız
            this.BackColor = Color.FromArgb(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)); // 1. değer red, 2. green, 3. blue
        }
    }
}
