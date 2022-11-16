using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class sqlbağlantısı
    {
        public SqlConnection bağlantı()
        {
            SqlConnection bağlantı = new SqlConnection("Data Source = MONSTER; Initial Catalog = Kullanici; Integrated Security = True");
            bağlantı.Open();
            return bağlantı;
        }
        
    }
}
