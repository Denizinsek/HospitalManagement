using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
