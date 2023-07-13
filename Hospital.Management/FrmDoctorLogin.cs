using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital.Management
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Doctors where TC=@p1 and Password=@p2", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail frm = new FrmDoctorDetail();
                frm.TC = MskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect TC or Password");
            }
            connection1.Connection().Close();

        }
    }
}
