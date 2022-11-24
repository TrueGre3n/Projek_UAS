using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiBa_Lib;
using MySql.Data.MySqlClient;

namespace DiBa_Lib
{
    public class Pangkat
    {
        #region data members
        string kodePangkat;
        string jenisPangkat;
        #endregion

        #region constructors
        public Pangkat(string kodePangkat, string jenisPangkat)
        {
            KodePangkat = kodePangkat;
            JenisPangkat = jenisPangkat;
        }
        #endregion

        #region properties
        public string KodePangkat { get => kodePangkat; set => kodePangkat = value; }
        public string JenisPangkat { get => jenisPangkat; set => jenisPangkat = value; }
        #endregion
    }
}