using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Hospital.Management
{
    public partial class FrmDoctorInfoEdit : Form
    {
        public FrmDoctorInfoEdit()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();
        public string TCno;

        private void FrmDoctorInfoEdit_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand cmd = new SqlCommand("Select * From Doctors where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                CmbBranch.Text = dr[3].ToString();
                TxtPassword.Text = dr[5].ToString();
            }
            connection1.Connection().Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Doctors set Name=@p1,Surname=@p2,Branch=@p3,Password=@p4 where Doctor=@p5", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p5", MskTC.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Doctor Record Updated");
        }
    }
}
