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
    public partial class YiyecekFormu : Form
    {
        
        public YiyecekFormu()
        {
            InitializeComponent();
            ListeGetir();
        }

        void ListeGetir()
        {
            dataGridView1.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("YiyecekListe", null);
        }

   
        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            YiyecekYeniKayit yfr = new YiyecekYeniKayit();
            yfr.Show();
            YiyecekYeniKayit yk = new YiyecekYeniKayit();
            if (yk.YeniKayit())
                ListeGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin");
                return;
            }

            int f_Kodu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Yiyecek Kodu"].Value);
            YiyecekYeniKayit yk = new YiyecekYeniKayit();
            if (yk.KayitSil(f_Kodu))
                ListeGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin");
                return;
            }
            int f_Kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Yiyecek Kodu"].Value);
            YiyecekGuncelle yk = new YiyecekGuncelle();
            if (yk.KayitGuncelle(f_Kod))
                ListeGetir();
        }

        private void YiyecekFormu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }
    }
    }