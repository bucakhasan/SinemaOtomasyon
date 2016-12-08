using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class cYoneticiler
    {
        private int _yoneticiNo;
        private string _yoneticiAd;
        private string _yoneticiSoyad;
        private string _mail;
        private string _sifre;
        private string _telefon;

        #region Properties
        public int YoneticiNo
        {
            get
            {
                return _yoneticiNo;
            }

            set
            {
                _yoneticiNo = value;
            }
        }

        public string YoneticiAd
        {
            get
            {
                return _yoneticiAd;
            }

            set
            {
                _yoneticiAd = value;
            }
        }

        public string YoneticiSoyad
        {
            get
            {
                return _yoneticiSoyad;
            }

            set
            {
                _yoneticiSoyad = value;
            }
        }

        public string Mail
        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
            }
        }

        public string Sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool YoneticiKontrol(string mail, string sifre)
        {
            bool Varmi = true;
            SqlCommand comm = new SqlCommand("Select mail, sifre from Yöneticiler where mail=@mail and sifre=@sifre", conn);
            comm.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = false;

            dr.Close();
            conn.Close();
            return Varmi;
        }
    }
}
