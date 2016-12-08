using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class cSalonlar
    {
        private int _salonNo;
        private string _salonAd;
        private int _kontenjan;

        #region Properties
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

        public string SalonAd
        {
            get
            {
                return _salonAd;
            }

            set
            {
                _salonAd = value;
            }
        }

        public int Kontenjan
        {
            get
            {
                return _kontenjan;
            }

            set
            {
                _kontenjan = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
    }
}
