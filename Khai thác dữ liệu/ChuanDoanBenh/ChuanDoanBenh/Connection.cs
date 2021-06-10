using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenh
{
    public class Connection
    {
        public SqlConnection consql;

        public Connection()
        {
            string chuoiketnoi = "Data Source = ADMIN; Initial Catalog = DULIEUBENH1; User ID = sa; Password = sa2012";
            consql = new SqlConnection(chuoiketnoi);
        }

        public int MoKetNoi()
        {
            if (consql.State.ToString() == "Closed")
            {
                consql.Open();
                return 1;
            }
            return 0;
        }

        public void DongKetNoi()
        {
            if (consql.State.ToString() == "Open")
            {
                consql.Close();
            }
        }
    }
}
