using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
    class cKullanicilar
    {
        private int _kullaniciNo;
        private string _kullaniciAd;
        private string _kullaniciSoyad;
        private string _mail;
        private string _sifre;
        private string _telefon;
        private string _adres;

        #region Properties
        public int KullaniciNo
        {
            get
            {
                return _kullaniciNo;
            }

            set
            {
                _kullaniciNo = value;
            }
        }

        public string KullaniciAd
        {
            get
            {
                return _kullaniciAd;
            }

            set
            {
                _kullaniciAd = value;
            }
        }

        public string KullaniciSoyad
        {
            get
            {
                return _kullaniciSoyad;
            }

            set
            {
                _kullaniciSoyad = value;
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

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool KullaniciKontrol(string mail, string sifre)
        {
            bool Varmi = true;
            SqlCommand comm = new SqlCommand("Select mail, sifre from Kullanıcılar where mail=@mail and sifre=@sifre", conn);
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

        public bool KullaniciEkle(cKullanicilar k)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Kullanıcılar (kullaniciAd, kullaniciSoyad, mail, sifre, telefon, adres) values(@kullaniciAd, @kullaniciSoyad, @mail, @sifre, @telefon, @adres)", conn);
            comm.Parameters.Add("@kullaniciAd", SqlDbType.VarChar).Value = k._kullaniciAd;
            comm.Parameters.Add("@kullaniciSoyad", SqlDbType.VarChar).Value = k._kullaniciSoyad;
            comm.Parameters.Add("@mail", SqlDbType.VarChar).Value = k._mail;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = k._sifre;
            comm.Parameters.Add("@telefon", SqlDbType.VarChar).Value = k._telefon;
            comm.Parameters.Add("@adres", SqlDbType.VarChar).Value = k._adres;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }

        public void KullaniciNoGetir(string mail, TextBox kullaniciNo)
        {
            SqlCommand comm = new SqlCommand("select kullaniciNo from Kullanıcılar where mail=@mail", conn);
            comm.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                kullaniciNo.Text = dr[0].ToString();
            }
            conn.Close();

        }




    }
}
