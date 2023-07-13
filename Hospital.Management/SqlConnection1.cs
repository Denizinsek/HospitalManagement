using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital.Management
{
    internal class SqlConnection1
    {
        public SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DENIZINSEK\\SQLEXPRESS;Initial Catalog=HospitalManagement;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
