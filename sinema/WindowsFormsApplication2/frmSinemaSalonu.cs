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
    public partial class frmSinemaSalonu : Form
    {
        public frmSinemaSalonu()
        {
            InitializeComponent();
        }

        cBiletSatis bs = new cBiletSatis();
        private void frmSinemaSalonu_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtSecilenKoltuk.Text = txtKoltukNoGir.Text;
            txttarih.Text = dtpTarih.Value.ToShortDateString();
            bool sonuc = bs.KoltukKontrol(btn1, txttarih.Text, Convert.ToInt32(txtSalonNo.Text), Convert.ToInt32(txtSeansNo.Text));
            if (sonuc)
            {
                btn1.BackColor = Color.Red;
            }
            
            
            
           
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if(txtSecilenKoltuk.Text.Trim() != "")
            {
                cBiletSatis bs = new cBiletSatis();
                bool sonuc = bs.BiletSatisKontrol(txtSecilenKoltuk.Text);
                if (sonuc)
                {
                    MessageBox.Show("Bu Bilet Kayıtlıdır");
                    txtSecilenKoltuk.Focus();
                }
                else
                {
                    bs.BirimFiyat = Convert.ToDouble(txtFiyat.Text);
                    bs.FilmNo = Convert.ToInt32(txtFilmNo.Text);
                    bs.KoltukNo = txtSecilenKoltuk.Text;
                    bs.KullaniciNo = Convert.ToInt32(txtKullaniciNo.Text);
                    bs.SalonNo = Convert.ToInt32(txtSalonNo.Text);
                    bs.SeansNo = Convert.ToInt32(txtSeansNo.Text);
                    bs.Tarih = Convert.ToDateTime(txttarih.Text);
                    sonuc = bs.BiletSatisEkle(bs);
                    if (sonuc)
                    {
                        MessageBox.Show("Bilet Satışınız Tamamlandı");
                        this.Close();

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Koltuk Seçiniz");
            }
                  
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            frmBiletAl frm = new frmBiletAl();
            this.Close();
            frm.ShowDialog();
        }

        private void cbTam_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTam.Checked == true)
            {
                cbOgrenci.Checked = false;
                txtFiyat.Text = "20.00";
            }else if(cbOgrenci.Checked == true)
            {
                cbTam.Checked = false;
                txtFiyat.Text = "10.00";
            }
        }

        private void cbOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTam.Checked == true)
            {
                cbOgrenci.Checked = false;
                txtFiyat.Text = "20.00";
            }
            else if (cbOgrenci.Checked == true)
            {
                cbTam.Checked = false;
                txtFiyat.Text = "10.00";
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txttarih.Text = dtpTarih.Value.ToShortDateString();
            bool sonuc = bs.KoltukKontrol(btn1, txttarih.Text, Convert.ToInt32(txtSalonNo.Text), Convert.ToInt32(txtSeansNo.Text));
            if (sonuc)
            {
                btn1.BackColor = Color.Red;
            }
        }
    }
}
