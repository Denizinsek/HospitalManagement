using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital.Management
{
    public partial class FrmPatientInfoEdit : Form
    {
        public FrmPatientInfoEdit()
        {
            InitializeComponent();
        }

        public string TCno;

        SqlConnection1 connection1 = new SqlConnection1();
        private void FrmPatientInfoEdit_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand cmd = new SqlCommand("Select * From Patients where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskTelephone.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();
            }
            connection1.Connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Patients set Name=@p1,Surname=@p2,Telephone=@p3,Password=@p4,Gender=@p5 where TC=@p6", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", MskTelephone.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", CmbGender.Text);
            cmd.Parameters.AddWithValue("@p6", MskTC.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Your information has been updated: ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
