using System;
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
    public partial class HayvanatBahcesiFormu : Form
    {
        public HayvanatBahcesiFormu()
        {
            InitializeComponent();
        }

        private void HayvanButonu_Click(object sender, EventArgs e)
        {
            HayvanFormu hfr = new HayvanFormu();
            hfr.Show();
        }

    

        private void BakiciButonu_Click(object sender, EventArgs e)
        {
            BakiciFormu bfr = new BakiciFormu();
            bfr.Show();

        }

        private void MenüButonu_Click(object sender, EventArgs e)
        {
            MenüFormu mfr = new MenüFormu();
            mfr.Show();
        }

        private void YiyecekButonu_Click(object sender, EventArgs e)
        {
            YiyecekFormu yfr = new YiyecekFormu();
            yfr.Show();
        }

        private void CikisButonu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HayvanMenü hm = new HayvanMenü();
            hm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HayvanBakici hb = new HayvanBakici();
            hb.Show();
        }
    }
}
