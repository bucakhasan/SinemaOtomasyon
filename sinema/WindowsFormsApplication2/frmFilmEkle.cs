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
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            if(txtFilmAdi.Text.Trim() != "" && txtKategori.Text.Trim() != "" && txtOyuncular.Text.Trim() != "" && txtTarih.Text.Trim() != "" && txtTurNo.Text.Trim() != "")
            {
                if(txtKategori.Text == "Vizyondakiler")
                {
                    cVizyondakiler v = new cVizyondakiler();
                    bool sonuc = v.FilmKontrol(txtFilmAdi.Text);
                    if (sonuc)
                    {
                        MessageBox.Show("Bu Film Kayıtlıdır");
                        txtFilmAdi.Focus();
                    }
                    else
                    {
                        v.FilmAd = txtFilmAdi.Text;
                        v.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                        v.Oyuncular = txtOyuncular.Text;
                        v.Puan = float.Parse(txtPuan.Text);
                        v.VizyonTarihi = Convert.ToDateTime(txtTarih.Text);
                        v.Yonetmen = txtYonetmen.Text;
                        sonuc = v.FilmEkle(v);
                        if (sonuc)
                        {
                            MessageBox.Show("Film Bilgileri Kayıt Edildi");
                            Temizle();
                        }
                    }

                }

                if(txtKategori.Text == "Yakındakiler")
                {
                    cYakindakiler y = new cYakindakiler();
                    bool sonuc = y.FilmKontrol(txtFilmAdi.Text);
                    if (sonuc)
                    {
                        MessageBox.Show("Bu Film Kayıtlıdır");
                        txtFilmAdi.Focus();
                    }else
                    {
                        y.FilmAd = txtFilmAdi.Text;
                        y.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                        y.Oyuncular = txtOyuncular.Text;
                        y.VizyonTarihi = Convert.ToDateTime(txtTarih.Text);
                        y.Yonetmen = txtYonetmen.Text;
                        sonuc = y.FilmEkle(y);
                        if (sonuc)
                        {
                            MessageBox.Show("Film Bilgileri Kayıt Edildi");
                            Temizle();
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKategori.Text = cbKategori.SelectedItem.ToString();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtKategori.Clear();
            txtOyuncular.Clear();
            txtPuan.Clear();
            txtTarih.Clear();
            txtTurNo.Clear();
            txtYonetmen.Clear();
            txtFilmAdi.Focus();
        }
    }
}
