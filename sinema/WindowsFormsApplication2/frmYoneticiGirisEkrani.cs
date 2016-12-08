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
    public partial class frmYoneticiGirisEkrani : Form
    {
        public frmYoneticiGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Trim() != "" && txtSifre.Text.Trim() != "")
            {
                cYoneticiler y = new cYoneticiler();
                bool sonuc = y.YoneticiKontrol(txtMail.Text, txtSifre.Text);
                if (sonuc)
                {
                    MessageBox.Show("Mail veya Şifre Yanlış");
                }
                else
                {

                    frmYoneticiGirisi frm = new frmYoneticiGirisi();
                    this.Close();
                    frm.Show();
                    
                }
            }else
            {
                MessageBox.Show("Mail ve Şifre Alanı Boş Bırakılamaz");
            }
        }

        private void frmYoneticiGirisEkrani_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
    }
}
