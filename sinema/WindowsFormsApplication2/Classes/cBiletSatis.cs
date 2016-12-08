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
    class cBiletSatis
    {
        private int _satisNo;
        private DateTime _tarih;
        private int _filmNo;
        private int _kullaniciNo;
        private int _salonNo;
        private int _seansNo;
        private string _koltukNo;
        private double _birimFiyat;

        #region Properties
        public int SatisNo
        {
            get
            {
                return _satisNo;
            }

            set
            {
                _satisNo = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public int FilmNo
        {
            get
            {
                return _filmNo;
            }

            set
            {
                _filmNo = value;
            }
        }

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

        public int SalonNo
        {
            get
            {
                return _salonNo;
            }

            set
            {
                _salonNo = value;
            }
        }

        public int SeansNo
        {
            get
            {
                return _seansNo;
            }

            set
            {
                _seansNo = value;
            }
        }

        public string KoltukNo
        {
            get
            {
                return _koltukNo;
            }

            set
            {
                _koltukNo = value;
            }
        }

        public double BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }

            set
            {
                _birimFiyat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
        
        public bool BiletSatisKontrol(string koltukNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select koltukNo from biletSatis where koltukNo=@koltukNo", conn);
            comm.Parameters.Add("@koltukNo", SqlDbType.VarChar).Value = koltukNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;

            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool BiletSatisEkle(cBiletSatis bs)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into biletSatis(tarih, filmNo, kullaniciNo, salonNo, seansNo, koltukNo, birimFiyat) values(@tarih, @filmNo, @kullaniciNo, @salonNo, @seansNo, @koltukNo, @birimFiyat)", conn);
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = bs._tarih;
            comm.Parameters.Add("@filmNo", SqlDbType.Int).Value = bs._filmNo;
            comm.Parameters.Add("@kullaniciNo", SqlDbType.Int).Value = bs._kullaniciNo;
            comm.Parameters.Add("@salonNo", SqlDbType.Int).Value = bs._salonNo;
            comm.Parameters.Add("@seansNo", SqlDbType.Int).Value = bs._seansNo;
            comm.Parameters.Add("@koltukNo", SqlDbType.VarChar).Value = bs._koltukNo;
            comm.Parameters.Add("@birimFiyat", SqlDbType.Money).Value = bs._birimFiyat;
            if(conn.State == ConnectionState.Closed) conn.Open();
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

        public bool KoltukKontrol(Button koltuk, string tarih, int salonNo, int seansNo)
        {
            bool varmi = false;
            SqlCommand comm = new SqlCommand("select koltukNo=@koltukNo from biletSatis where CONVERT(varchar, tarih, 104)=@tarih and salonNo=@salonNo and seansNo=@seansNo", conn);
            comm.Parameters.Add("@koltukNo", SqlDbType.VarChar).Value = koltuk.Text;
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = tarih;
            comm.Parameters.Add("@salonNo", SqlDbType.Int).Value = salonNo;
            comm.Parameters.Add("@seansNo", SqlDbType.Int).Value = seansNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                varmi = true;

            dr.Close();
            conn.Close();
            return varmi;

        }
    }
}
