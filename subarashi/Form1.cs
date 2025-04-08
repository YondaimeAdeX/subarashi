using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subarashi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dbGaleriEntities db = new dbGaleriEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            tblArabalar arabalar = new tblArabalar();
            arabalar.marka = txtMarka.Text;
            arabalar.model = txtModel.Text;
            arabalar.modelyili = txtModelYili.Text;
            arabalar.fiyati = int.Parse(txtFiyati.Text);
            db.tblArabalar.Add(arabalar);
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tblMusteriler musteri = new tblMusteriler();
            musteri.adi = txtadimusteri.Text;
            musteri.tel = txttelmusteri.Text;
            db.tblMusteriler.Add(musteri);
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tblSatici satici = new tblSatici();
            satici.adi = txtadisatici.Text;
            satici.tel = txttelsatici.Text;
            db.tblSatici.Add(satici);
            db.SaveChanges();
        }
    }
}
