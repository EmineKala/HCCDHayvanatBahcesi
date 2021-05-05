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
    public partial class HayvanBakici : Form
    {

        bool Sonuc = false;
        public HayvanBakici()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
            dataGridView1.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("HayvanBakiciListe", null);
        }
        public bool KayitSil(int SatirSayisi)
        {
            if (MessageBox.Show("Seçilen Kayıt Silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SatirSayisi", SatirSayisi));
            return (VeriTabani.ProsedurCalistir_MesajDegerlendir("HayvanBakiciSil", parametreler));
        }
   
        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            HayvanBakiciYeniKayit hby = new HayvanBakiciYeniKayit();
            hby.Show();
            ListeGetir();
        }

        private void GüncelleButonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin");
                return;
            }
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SatirSayisi", SatirSayisi.Value));
            parametreler.Add(new DictionaryEntry("HayvanID", ID.Value));
            parametreler.Add(new DictionaryEntry("BakiciSicilNo", BakiciSicilNo.Value));
            parametreler.Add(new DictionaryEntry("Gorevi", Gorev.Text));

            string f_prosedurAdi = "HayvanBakiciGuncelle";
            if (VeriTabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
            }

            if (Sonuc == true)
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            ListeGetir();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListeGetir();
        }

        private void SilButonu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin");
                return;
            }



            int f_SatirSayisi= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Satır Sayısı"].Value);
            HayvanBakici hm = new HayvanBakici();
            if (hm.KayitSil(f_SatirSayisi))
                ListeGetir();
        }

 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SatirSayisi.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ID.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            BakiciSicilNo.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            Gorev.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
