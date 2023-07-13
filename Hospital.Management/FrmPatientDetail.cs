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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string tc;
        SqlConnection1 connection1 = new SqlConnection1();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;


            //  Pulling Name Surname 
            SqlCommand cmd = new SqlCommand("Select Name,Surname From Patients where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            connection1.Connection().Close();

            // Appointment history
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Appointments where PatientTC=" + tc, connection1.Connection());
            da.Fill(dt);
            dataGridViewHistory.DataSource = dt;

            // Pulling Branches

            SqlCommand cmd2 = new SqlCommand("Select Name From Branches", connection1.Connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            connection1.Connection().Close();
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand cmd = new SqlCommand("Select Name,Surname From Doctors where Branch=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbDoctor.Items.Add(dr[0] + " " + dr[1]);
            }
            connection1.Connection().Close();
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Appointments where Branch= '" + CmbBranch.Text + "'" + " and Doctor='" + CmbDoctor.Text + "' and Status=0", connection1.Connection());
            da.Fill(dt);
            dataGridViewActive.DataSource = dt;

        }

        private void LnkInfoEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientInfoEdit frm = new FrmPatientInfoEdit();
            frm.TCno = LblTC.Text;
            frm.Show();
        }

        private void dataGridViewActive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridViewActive.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridViewActive.Rows[selected].Cells[0].Value.ToString();
        }

        private void BtnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Appointments Set Status=1,PatientTC=@p1,PatientComplaint=@p2 where ID=@p3", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            cmd.Parameters.AddWithValue("@p2", RchComplaint.Text);
            cmd.Parameters.AddWithValue("@p3", TxtID.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Appointment made", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
