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
    public partial class frmParolamiUnuttum : Form
    {
        public frmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifreGonder_Click(object sender, EventArgs e)
        {
            if(txtMail.Text.Trim() != "")
            {
                MessageBox.Show("Şifreniz E-Posta Adresinize Gönderildi.");
                this.Close();
            }else
            {
                MessageBox.Show("Lütfen E-Posta Adresinizi Giriniz.");
            }
        }

        private void frmParolamiUnuttum_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
    }
}
