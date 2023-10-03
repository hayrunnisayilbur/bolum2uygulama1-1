using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2uygukama1_1
{
    public partial class lblDurum : Form
    {
        public lblDurum()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt32(txtYas.Text);

            if (yas < 18)
            {
                lbl.Text = "araba kullanmak için büyümen lazım";


            }if (yas >= 18)
                lbl.Text = "araba kullanabilirsin";

        }
    }
}
