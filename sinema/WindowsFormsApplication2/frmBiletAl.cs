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
    public partial class frmBiletAl : Form
    {
        public frmBiletAl()
        {
            InitializeComponent();
        }

        frmSinemaSalonu frm = new frmSinemaSalonu();
        private void frmBiletAl_Load(object sender, EventArgs e)
        {
            frm.txtKullaniciNo.Text = txtkullanici.Text;
            this.Top = 0;
            this.Left = 0;
            frm.txtSalonNo.Text = "1";
            cbSecilenFilm.SelectedIndex = 0;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans1.Text);
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans2.Text);
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans3.Text);
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans4.Text);
            }
        }

        private void btnBiletal_Click(object sender, EventArgs e)
        {
            if(rbseans1.Checked == true || rbseans2.Checked == true || rbseans3.Checked == true || rbseans4.Checked == true)
            {
                
                frm.Show();
                frm.txtSalon.Text = lbBilet.Items[1].ToString();
                frm.txtSeans.Text = lbBilet.Items[2].ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "1";
            frm.txtFilmNo.Text = "4";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 0;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            } else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            } else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 1");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "2";
            frm.txtFilmNo.Text = "8";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 1;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 2");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 2");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 2");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 2");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "3";
            frm.txtFilmNo.Text = "1";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 2;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 3");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 3");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 3");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 3");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "4";
            frm.txtFilmNo.Text = "11";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 3;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 4");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 4");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 4");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 4");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "5";
            frm.txtFilmNo.Text = "3";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 4;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 5");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 5");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 5");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 5");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "6";
            frm.txtFilmNo.Text = "6";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 5;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 6");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 6");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 6");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 6");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "7";
            frm.txtFilmNo.Text = "7";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 6;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 7");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 7");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 7");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 7");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "8";
            frm.txtFilmNo.Text = "9";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 7;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 8");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 8");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 8");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 8");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "9";
            frm.txtFilmNo.Text = "5";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 8;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 9");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 9");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 9");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 9");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "10";
            frm.txtFilmNo.Text = "12";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 9;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 10");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 10");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 10");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 10");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "11";
            frm.txtFilmNo.Text = "10";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 10;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 11");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 11");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 11");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 11");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            frm.txtSalonNo.Text = "12";
            frm.txtFilmNo.Text = "2";
            lbBilet.Items.Clear();
            cbSecilenFilm.SelectedIndex = 11;
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void rbseans1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void rbseans2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void rbseans3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }

        private void rbseans4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbseans1.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans1.Text);
                frm.txtSeansNo.Text = "1";
            }
            else if (rbseans2.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans2.Text);
                frm.txtSeansNo.Text = "2";
            }
            else if (rbseans3.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans3.Text);
                frm.txtSeansNo.Text = "3";
            }
            else if (rbseans4.Checked == true)
            {
                lbBilet.Items.Clear();
                lbBilet.Items.Add(cbSecilenFilm.SelectedItem);
                lbBilet.Items.Add("Salon 12");
                lbBilet.Items.Add(rbseans4.Text);
                frm.txtSeansNo.Text = "4";
            }
        }
    }
}
