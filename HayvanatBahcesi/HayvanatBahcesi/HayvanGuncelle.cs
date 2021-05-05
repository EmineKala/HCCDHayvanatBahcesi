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
    public partial class HayvanGuncelle : Form
    {
       
        int VarlikID;
        bool Sonuc = false;
        public HayvanGuncelle()
        {
            InitializeComponent();
        }
        public bool KayitGuncelle(int ID)
        {
            
            VarlikID = ID;
            DataTable f_kayit = VeriTabani.SELECTCalistir("SELECT * FROM Hayvan WHERE ID =" + ID.ToString());
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Hayvan Kaydı Bulunamadı");
                return false;
            }

            Sinif.Text = f_kayit.Rows[0]["Sinifi"].ToString();
            Tür.Text = f_kayit.Rows[0]["Türü"].ToString();
            Yas.Value = Convert.ToInt32(f_kayit.Rows[0]["Yasi"]);
            GelisTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["GelisTarihi"]);
            this.ShowDialog();

            return Sonuc;
            
        }

 
        private void KaydetButonu_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ID", VarlikID));
            parametreler.Add(new DictionaryEntry("Sinifi", Sinif.Text));
            parametreler.Add(new DictionaryEntry("Türü", Tür.Text));
            parametreler.Add(new DictionaryEntry("Yasi", Yas.Value));
            parametreler.Add(new DictionaryEntry("GelisTarihi", GelisTarihi.Value));
            string f_prosedurAdi = "HayvanGüncelle";
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
