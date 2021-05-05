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
    public partial class YiyecekGuncelle : Form
    {
        int VarlikKodu;
        bool Sonuc = false;
        public YiyecekGuncelle()
        {
            InitializeComponent();
        }

        public bool KayitGuncelle(int Kodu)
        {
          
            VarlikKodu = Kodu;
            DataTable f_kayit = VeriTabani.SELECTCalistir("SELECT * FROM Yiyecek WHERE Kodu=" + Kodu.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Yiyecek Kaydı Bulunamadı");
                return false;
            }

            MenuKodu.Value = Convert.ToInt32(f_kayit.Rows[0]["MenuKodu"]);
            Ad.Text = f_kayit.Rows[0]["Adi"].ToString();
            Miktar.Text = f_kayit.Rows[0]["Miktar"].ToString();
            this.ShowDialog();

            return Sonuc;
        }

 
        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            
                parametreler.Add(new DictionaryEntry("Kodu", VarlikKodu));
                parametreler.Add(new DictionaryEntry("MenuKodu", MenuKodu.Value));
                parametreler.Add(new DictionaryEntry("Adi", Ad.Text));
                parametreler.Add(new DictionaryEntry("Miktar", Miktar.Text));

                 string  f_prosedurAdi = "YiyecekGüncelle";
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
