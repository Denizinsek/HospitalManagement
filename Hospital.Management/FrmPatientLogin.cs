using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital.Management
{
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();
        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp frm = new FrmPatientSignUp();
            frm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Patients Where TC=@p1 and Password=@p2", connection1.Connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FrmPatientDetail frm = new FrmPatientDetail();
                frm.tc = MskTC.Text;
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
