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
    public partial class MenüYeniKayit : Form
    {
        int islem;
        
        bool Sonuc = false;
        public MenüYeniKayit()
        {
            InitializeComponent();
        }
        public bool YeniKayit()
        {
            islem = 0;
            return Sonuc;
        }

        public bool KayitSil(int Kodu)
        {
            if (MessageBox.Show("Seçilen Menü Kaydı Silinecek. Emin Misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("Kodu", Kodu));
            return (VeriTabani.ProsedurCalistir_MesajDegerlendir("MenüSil", parametreler));
        }


        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            if (islem == 0)

                parametreler.Add(new DictionaryEntry("Adi", Ad.Text));
            string f_prosedurAdi = "MenüEkle";
            if (VeriTabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
            if(Sonuc==true)
            MessageBox.Show("Yeni Kayıt İşlemi Başarılı");
        }

        private void IptalButonu_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
