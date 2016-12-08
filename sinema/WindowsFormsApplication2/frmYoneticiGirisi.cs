using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmYoneticiGirisi : Form
    {
        public frmYoneticiGirisi()
        {
            InitializeComponent();
        }

        private void frmYoneticiGirisi_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            frmFilmEkle frm = new frmFilmEkle();
            frm.Show();
        }

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            frmBiletAl frm = new frmBiletAl();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFilmSil frm = new frmFilmSil();
            frm.Show();
        }

        private void btnSorgulamaekrani_Click(object sender, EventArgs e)
        {
            frmSorgulama frm = new frmSorgulama();
            frm.Show();
        }
    }
}
