using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HayvanatBahcesi
{
    public partial class BakiciFormu : Form
    {
       

        public BakiciFormu()
        {
            InitializeComponent();
            ListeGetir();

        }
        void ListeGetir()
        {
            BakiciListe.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("BakiciListe", null);
        }
  
        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            BakiciYeniKayit bfr = new BakiciYeniKayit();
            bfr.Show();
            BakiciYeniKayit ba = new BakiciYeniKayit();
            if (ba.YeniKayit())
                ListeGetir();
  

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BakiciListe.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin");
                return;
            }

             int f_sicil = Convert.ToInt32(BakiciListe.SelectedRows[0].Cells["Sicil Numarası"].Value);
            BakiciYeniKayit ba = new BakiciYeniKayit();
            if (ba.KayitSil( f_sicil))
                ListeGetir();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BakiciListe.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin");
                return;
            }
            int f_SicilNO = Convert.ToInt32(BakiciListe.SelectedRows[0].Cells["Sicil Numarası"].Value);
            BakiciGuncelle ba = new BakiciGuncelle();
            if (ba.KayitGuncelle(f_SicilNO))
                ListeGetir();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

      
    }
}
