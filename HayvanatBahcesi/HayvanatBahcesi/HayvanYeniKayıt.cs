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
    public partial class HayvanYeniKayıt : Form
    {
        int islem;
        bool Sonuc = false;

        public HayvanYeniKayıt()
        {
            InitializeComponent();

        }
        
    
        public bool KayitSil(int ID)
        {
            if (MessageBox.Show("Seçilen Hayvan Kaydı Silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ID", ID));
            return (VeriTabani.ProsedurCalistir_MesajDegerlendir("HayvanSil", parametreler));
        }


        private void IptalButonu_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool YeniKayit()
        {
            islem = 0;

            return Sonuc;
        }


        private void KaydetButonu_Click_1(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            if(islem==0)
           
            parametreler.Add(new DictionaryEntry("Sinifi", Sinif.Text));
            parametreler.Add(new DictionaryEntry("Türü", Tür.Text));
            parametreler.Add(new DictionaryEntry("Yasi", Yas.Value));
            parametreler.Add(new DictionaryEntry("GelisTarihi", GelisTarihi.Value));
            string f_prosedurAdi = "HayvanEkle";
            if (VeriTabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
              
            }
            if(Sonuc==true)
            
            MessageBox.Show("Yeni Kayıt İşlemi Başarılı");
           
        }

        private void HayvanYeniKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
