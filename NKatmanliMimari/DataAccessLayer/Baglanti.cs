using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Baglanti
    {

        public static SqlConnection bgl=new SqlConnection(@"Data Source=DESKTOP-9TE47SL\SQLEXPRESS;Initial Catalog=DbPersonel;Integrated Security=True;");

    }
}
