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
    public partial class BakiciGuncelle : Form
    {
        int VarlikSicil;
        bool Sonuc = false;
        public BakiciGuncelle()
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

        public bool KayitGuncelle(int SicilNO)
        {
           
            VarlikSicil = SicilNO;     
           

           DataTable f_kayit = VeriTabani.SELECTCalistir("SELECT * FROM Bakici WHERE SicilNO =" + SicilNO.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Bakıcı Kaydı Bulunamadı");
                return false;
            }

            Ad.Text = f_kayit.Rows[0]["Adi"].ToString();
            Soyad.Text = f_kayit.Rows[0]["Soyadi"].ToString();
            Yas.Value = Convert.ToInt32(f_kayit.Rows[0]["Yasi"]);
            Cinsiyet.SelectedValue = f_kayit.Rows[0]["Cinsiyeti"].ToString();
            Telefon.Value = Convert.ToInt64(f_kayit.Rows[0]["Tel"].ToString());
            TCNo.Value = Convert.ToInt64(f_kayit.Rows[0]["TCNo"].ToString());
            Tecrube.Value = Convert.ToInt32(f_kayit.Rows[0]["Tecrube"]);

            this.ShowDialog();

            return Sonuc;
        }

       

        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
           
                parametreler.Add(new DictionaryEntry("SicilNO", VarlikSicil));
           

                parametreler.Add(new DictionaryEntry("Adi", Ad.Text));
            parametreler.Add(new DictionaryEntry("Soyadi", Soyad.Text));
            parametreler.Add(new DictionaryEntry("Yasi", Yas.Value));
            parametreler.Add(new DictionaryEntry("Cinsiyeti", Cinsiyet.SelectedValue));
            parametreler.Add(new DictionaryEntry("Tel", Telefon.Value));
            parametreler.Add(new DictionaryEntry("TCNo", TCNo.Value));
            parametreler.Add(new DictionaryEntry("Tecrube", Tecrube.Value));

            string  f_prosedurAdi = "BakiciGüncelle";
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
