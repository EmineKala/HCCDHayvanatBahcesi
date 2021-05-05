using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanatBahcesi
{
    public partial class MenuGuncelle : Form
    {
        int VarlikKodu;
        bool Sonuc = false;

        public MenuGuncelle()
        {
            InitializeComponent();
        }
        public bool KayitGuncelle(int Kodu)
        {
            VarlikKodu = Kodu;
            DataTable f_kayit = VeriTabani.SELECTCalistir("SELECT * FROM Menu WHERE Kodu =" + Kodu.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Menü Kaydı Bulunamadı");
                return false;
            }
            Ad.Text = f_kayit.Rows[0]["Adi"].ToString();

            this.ShowDialog();

            return Sonuc;
        }


        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
             parametreler.Add(new DictionaryEntry("Kodu", VarlikKodu));
            parametreler.Add(new DictionaryEntry("Adi", Ad.Text));
             string f_prosedurAdi = "MenüGüncelle";
           
            if (VeriTabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void IptalButonu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
