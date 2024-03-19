using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa187
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Ogrenciler
        {
            public int Numara { get; set; }
            public string AdSoyad { get; set; }
            public string Alan { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 17;
            ogrenci.AdSoyad = "selo";
            ogrenci.Alan = "Bilişim Teknolojileri";
            numara.DataBindings.Add("Text", ogrenci, "Numara");
            adSoyad.DataBindings.Add("Text", ogrenci, "AdSoyad");
            alan.DataBindings.Add("Text", ogrenci, "Alan");
        }

        private void adSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
