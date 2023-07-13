using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital.Management
{
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        SqlConnection1 connection1 = new SqlConnection1();

        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Appointments", connection1.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
