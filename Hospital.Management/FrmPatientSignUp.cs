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
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Patients(Name,Surname,TC,Telephone,Password,Gender) values(@p1,@p2,@p3,@p4,@p5,@p6)", connection1.Connection());
            command.Parameters.AddWithValue("@p1", TxtName.Text);
            command.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command.Parameters.AddWithValue("@p3", MskTC.Text);
            command.Parameters.AddWithValue("@p4", MskTelephone.Text);
            command.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command.Parameters.AddWithValue("@p6", CmbGender.Text);
            command.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Your registration has been completed. Your password is: "+TxtPassword.Text, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
