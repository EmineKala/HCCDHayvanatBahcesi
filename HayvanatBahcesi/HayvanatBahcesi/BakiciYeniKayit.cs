using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HayvanatBahcesi
{
    public partial class BakiciYeniKayit : Form
    {
        int islem;
        bool Sonuc = false;
        public BakiciYeniKayit()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(Cinsiyet, "CINSIYET");
        }
        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = VeriTabani.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }
        public bool YeniKayit()
        {
            islem = 0;

            return Sonuc;
        }



        public bool KayitSil(int SicilNO)
        {
            if (MessageBox.Show("Seçilen Bakıcı Kaydı Silinecek. Emin Misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("SicilNO", SicilNO));
            return (VeriTabani.ProsedurCalistir_MesajDegerlendir("BakiciSil", parametreler));
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            if (islem == 0)

                parametreler.Add(new DictionaryEntry("Adi", Ad.Text));
            parametreler.Add(new DictionaryEntry("Soyadi", Soyad.Text));
            parametreler.Add(new DictionaryEntry("Yasi", Yas.Value));
            parametreler.Add(new DictionaryEntry("Cinsiyeti", Cinsiyet.SelectedValue));
            parametreler.Add(new DictionaryEntry("Tel", Telefon.Value));
            parametreler.Add(new DictionaryEntry("TCNo", TCNo.Value));
            parametreler.Add(new DictionaryEntry("Tecrube", Tecrube.Value));

            string f_prosedurAdi = "BakiciEkle";
            
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
