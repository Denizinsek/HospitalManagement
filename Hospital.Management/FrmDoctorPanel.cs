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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Doctors", connection1.Connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            // Importing branch into ComboBox

            SqlCommand cmd = new SqlCommand("Select Name From Branches", connection1.Connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CmbBranch.Items.Add(dr[0]);
            }
            connection1.Connection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Doctors (Name,Surname,Branch,TC,Password) values (@d1,@d2,@d3,@d4,@d5)", connection1.Connection());
            cmd.Parameters.AddWithValue("@d1", TxtName.Text);
            cmd.Parameters.AddWithValue("@d2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@d3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@d4", MskTC.Text);
            cmd.Parameters.AddWithValue("@d5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Doctor Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbBranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Doctors where TC=@p1", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Doctor Record Deleted!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Doctors Set Name=@d1,Surname=@d2,Branch=@d3,Password=@d5 where TC=@d4", connection1.Connection());
            cmd.Parameters.AddWithValue("@d1", TxtName.Text);
            cmd.Parameters.AddWithValue("@d2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@d3", CmbBranch.Text);
            cmd.Parameters.AddWithValue("@d4", MskTC.Text);
            cmd.Parameters.AddWithValue("@d5", TxtPassword.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Doctor Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
