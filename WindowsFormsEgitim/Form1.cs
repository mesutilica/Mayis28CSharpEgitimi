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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // bu metotla açılınca alttaki forma erişime izin veriliyor
            // form2.ShowDialog(); // bu metotla açarsak alttaki forma erişimi engelliyor
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // geçerli formu kapatır
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.AdSoyad = textBox1.Text;
            form2.ShowDialog();
        }
    }
}
