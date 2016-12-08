using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class frmUyeGirisi : Form
    {
        public frmUyeGirisi()
        {
            InitializeComponent();
        }

        private void btnParola_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frm = new frmParolamiUnuttum();
            frm.Show();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            frmUyeKayit frm = new frmUyeKayit();
            frm.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtMail.Text.Trim() != "" && txtSifre.Text.Trim() != "")
            {
                cKullanicilar k = new cKullanicilar();
                bool sonuc = k.KullaniciKontrol(txtMail.Text, txtSifre.Text);
                if (sonuc)
                {
                    MessageBox.Show("Mail veya Şifre Yanlış");
                }else
                {
                     
                    frmBiletAl frm = new frmBiletAl();
                    k.KullaniciNoGetir(txtMail.Text, frm.txtkullanici);
                    this.Close();
                    frm.Show();
                    
                }
            }else
            {
                MessageBox.Show("Mail ve Şifre Alanı Boş Bırakılamaz");
            }

            
        }

        private void frmUyeGirisi_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
    }
}
