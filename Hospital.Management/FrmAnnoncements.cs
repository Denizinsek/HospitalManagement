using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital.Management
{
    public partial class FrmAnnoncements : Form
    {
        public FrmAnnoncements()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void FrmAnnoncements_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Announcements", connection1.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
