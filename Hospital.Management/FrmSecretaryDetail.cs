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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlConnection1 connection1 = new SqlConnection1();
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCno;

            // Name surname

            SqlCommand cmd = new SqlCommand("Select NameSurname From Secretaries where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0].ToString();
            }
            connection1.Connection().Close();

            // Transferring branches to DataGrid
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Branches", connection1.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Adding Doctors to the List
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (Name + ' ' + Surname) AS FullName,Branch From Doctors", connection1.Connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            // Importing branch into ComboBox
            SqlCommand cmd2 = new SqlCommand("Select Name From Branches", connection1.Connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            connection1.Connection().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand save = new SqlCommand("insert into Appointments(Date,Time,Branch,Doctor) values (@a1,@a2,@a3,@a4)", connection1.Connection());
            save.Parameters.AddWithValue("@a1", MskDate.Text);
            save.Parameters.AddWithValue("@a2", MskTime.Text);
            save.Parameters.AddWithValue("@a3", CmbBranch.Text);
            save.Parameters.AddWithValue("@a4", CmbDoctor.Text);
            save.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Appointment Created");
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand cmd = new SqlCommand("Select Name,Surname From Doctors Where Branch=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            connection1.Connection().Close();
        }

        private void BtnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Announcements (Announcement) values (@announc1)", connection1.Connection());
            cmd.Parameters.AddWithValue("@announc1", RchAnnouncement.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Announcement Created!");
        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel frm = new FrmDoctorPanel();
            frm.Show();
        }

        private void BtnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel frm = new FrmBranchPanel();
            frm.Show();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frm = new FrmAppointmentList();
            frm.Show();
        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnoncements frm = new FrmAnnoncements();
            frm.Show();
        }
    }
}
