using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Kitaplik_Proje
{
    internal class SqlBaglanti
    {

        public SqlConnection baglanti() { 
        
        SqlConnection baglanti= new SqlConnection("Data Source=DESKTOP-9TE47SL\\SQLEXPRESS;Initial Catalog=KitaplikProje;Integrated Security=True;");
            baglanti.Open();   
            return baglanti;
        
        }


    }
}
