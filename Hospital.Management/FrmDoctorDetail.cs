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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();
        public string TC;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoEdit frm = new FrmDoctorInfoEdit();
            frm.TCno = LblTC.Text;
            frm.Show();
        }

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            // Doctor Name Surname 
            SqlCommand cmd = new SqlCommand("Select Name,Surname From Doctors where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            connection1.Connection().Close();

            // Appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Appointments where Doctor='" + LblNameSurname.Text + "'", connection1.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnAnnoncements_Click(object sender, EventArgs e)
        {
            FrmAnnoncements frm = new FrmAnnoncements();
            frm.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
