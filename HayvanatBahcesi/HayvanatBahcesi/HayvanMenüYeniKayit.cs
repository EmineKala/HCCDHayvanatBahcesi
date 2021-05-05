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
    public partial class HayvanMenüYeniKayit : Form
    {
      

        bool Sonuc = false;
        public HayvanMenüYeniKayit()
        {
            InitializeComponent();
        }

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
           

                parametreler.Add(new DictionaryEntry("HayvanID", ID.Value));
            parametreler.Add(new DictionaryEntry("MenuKodu", MenüKodu.Value));
            parametreler.Add(new DictionaryEntry("Gun", Gün.Value));

            string f_prosedurAdi = "HayvanMenuEkle";
            if (VeriTabani.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
            if (Sonuc == true)
                MessageBox.Show("Yeni Kayıt İşlemi Başarılı");
        }
    }
}
