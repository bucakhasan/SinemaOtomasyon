using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class cSeanslar
    {
        private int _seansNo;
        private string _seansSaat;

        #region Properties
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

        public string SeansSaat
        {
            get
            {
                return _seansSaat;
            }

            set
            {
                _seansSaat = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);
    }
}
