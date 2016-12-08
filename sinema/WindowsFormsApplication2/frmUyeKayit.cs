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
    public partial class frmUyeKayit : Form
    {
        private object cKullanıcılar;

        public frmUyeKayit()
        {
            InitializeComponent();
        }

        private void frmUyeKayit_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            if(txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtSifre.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "")
            {
                cKullanicilar k = new cKullanicilar();
                bool sonuc = k.KullaniciKontrol(txtMail.Text, txtSifre.Text);
                if (sonuc)
                {
                    MessageBox.Show("Bu Kullanıcı Kayıtlıdır");
                    txtAdi.Focus();
                }else
                {
                    k.KullaniciAd = txtAdi.Text;
                    k.KullaniciSoyad = txtSoyadi.Text;
                    k.Mail = txtMail.Text;
                    k.Sifre = txtSifre.Text;
                    k.Telefon = txtTelefon.Text;
                    k.Adres = txtAdres.Text;
                    sonuc = k.KullaniciEkle(k);
                    if (sonuc)
                    {
                        MessageBox.Show("Kaydınız Tamamlandı");
                        this.Close();
                    }
                }
            }
        }
    }
}
