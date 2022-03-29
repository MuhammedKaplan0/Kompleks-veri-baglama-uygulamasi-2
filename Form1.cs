using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kompleks_veri_baglama_uygulamasi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kaynakVeri = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar Kitap= new Kitaplar();
            Kitap.KitapAdi = textBox1.Text;
            Kitap.KitapYazari = textBox2.Text;
            Kitap.KitapTuru = textBox3.Text;
            kaynakVeri.Add(Kitap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource=null;
            listBox1.DataSource = kaynakVeri;
            listBox1.DisplayMember = "KitapAdi";
        }
    }
}
