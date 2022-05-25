using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btn_garaze_Click(object sender, EventArgs e)
        {
            Garaze frm_garaze = new Garaze();
            frm_garaze.Show();
        }

        private void btn_stanje_Click(object sender, EventArgs e)
        {
            Stanje frm_stanje = new Stanje();
            frm_stanje.Show();
        }

        private void btn_promet_Click(object sender, EventArgs e)
        {
            Promet frm_promet = new Promet();
            frm_promet.Show();
        }
    }
}
