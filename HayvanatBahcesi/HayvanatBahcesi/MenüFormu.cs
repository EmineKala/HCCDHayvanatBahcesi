using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HayvanatBahcesi
{
    public partial class MenüFormu : Form
    {
        public MenüFormu()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
            dataGridView1.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("MenüListe", null);
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            MenüYeniKayit mfr = new MenüYeniKayit();
            mfr.Show();
            MenüYeniKayit mn = new MenüYeniKayit();
            if (mn.YeniKayit())
                ListeGetir();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin");
                return;
            }

            int f_varlikKodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Menü Kodu"].Value);
            MenüYeniKayit ha = new MenüYeniKayit();
            if (ha.KayitSil(f_varlikKodu))
                ListeGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin");
                return;
            }
            int f_varlikKodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Menü Kodu"].Value);
            MenuGuncelle mn = new MenuGuncelle();
            if (mn.KayitGuncelle(f_varlikKodu))
                ListeGetir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
}
