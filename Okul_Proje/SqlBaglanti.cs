using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Proje
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9TE47SL\\SQLEXPRESS;Initial Catalog=OkulProje;Integrated Security=True;");
            baglanti.Open();
            return baglanti;
        }
    }
}
