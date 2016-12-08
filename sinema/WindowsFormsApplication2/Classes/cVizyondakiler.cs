using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class cVizyondakiler
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private DateTime _vizyonTarihi;
        private float _puan;

        #region Properties
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

        public string FilmAd
        {
            get
            {
                return _filmAd;
            }

            set
            {
                _filmAd = value;
            }
        }

        public int FilmTurNo
        {
            get
            {
                return _filmTurNo;
            }

            set
            {
                _filmTurNo = value;
            }
        }

        public string Yonetmen
        {
            get
            {
                return _yonetmen;
            }

            set
            {
                _yonetmen = value;
            }
        }

        public string Oyuncular
        {
            get
            {
                return _oyuncular;
            }

            set
            {
                _oyuncular = value;
            }
        }

        public DateTime VizyonTarihi
        {
            get
            {
                return _vizyonTarihi;
            }

            set
            {
                _vizyonTarihi = value;
            }
        }

        public float Puan
        {
            get
            {
                return _puan;
            }

            set
            {
                _puan = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public bool FilmKontrol(string filmAd)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select filmAd from Vizyondakiler where filmAd = @filmAd", conn);
            comm.Parameters.Add("@filmAd", SqlDbType.VarChar).Value = filmAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;

            dr.Close();
            conn.Close();
            return Varmi;
        }

        public bool FilmEkle(cVizyondakiler v )
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Vizyondakiler(filmAd, filmTurNo, yonetmen, oyuncular, vizyonTarih, puan) values(@filmAd, @turNo, @yonetmen, @oyuncular, @vizyonTarih, @puan)", conn);
            comm.Parameters.Add("@filmAd", SqlDbType.VarChar).Value = v._filmAd;
            comm.Parameters.Add("@turNo", SqlDbType.Int).Value = v._filmTurNo;
            comm.Parameters.Add("@yonetmen", SqlDbType.VarChar).Value = v._yonetmen;
            comm.Parameters.Add("@oyuncular", SqlDbType.VarChar).Value = v._oyuncular;
            comm.Parameters.Add("@vizyonTarih", SqlDbType.DateTime).Value = v._vizyonTarihi;
            comm.Parameters.Add("@puan", SqlDbType.Float).Value = v._puan;

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
    }
}
