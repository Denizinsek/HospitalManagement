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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Secretaries where TC=@p1 and Password=@p2", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetail detail = new FrmSecretaryDetail();
                detail.TCno = MskTC.Text;
                detail.Show();
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
