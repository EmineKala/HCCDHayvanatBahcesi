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
    public partial class HayvanFormu : Form
    {

        public HayvanFormu()
        {
            InitializeComponent();
            ListeGetir();
        }
        
        void ListeGetir()
        {
            dataGridView1.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("HayvanListe",null);
        }


        private void button3_Click(object sender, EventArgs e)
        {
           if (dataGridView1.SelectedRows.Count<1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin");
                return;
            }

            int f_varlikID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            HayvanYeniKayıt ha = new HayvanYeniKayıt();
            if (ha.KayitSil(f_varlikID))
                ListeGetir();
            
        }

        private void button2_Click(object sender, EventArgs e)
        { if (dataGridView1.SelectedRows.Count < 1)
            { MessageBox.Show("Önce Güncellenecek Kaydı Seçin");
                return;
            }
            int f_VarlikID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            HayvanGuncelle ha = new HayvanGuncelle();
            if (ha.KayitGuncelle(f_VarlikID))
                ListeGetir();
           }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {

            HayvanYeniKayıt hfr = new HayvanYeniKayıt();
            hfr.Show();
            HayvanYeniKayıt hy = new HayvanYeniKayıt();
            if (hy.YeniKayit())
            ListeGetir();
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

      
    }
}
//Data Source=ASUS-PC;Initial Catalog=HayvanatBahcesi;Integrated Security=True