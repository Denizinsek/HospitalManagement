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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }

        SqlConnection1 connection1 = new SqlConnection1();

        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Branches", connection1.Connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Branches (Name) values(@b1)", connection1.Connection());
            cmd.Parameters.AddWithValue("@b1", TxtBranchName.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Branch Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtBranchName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete From Branches where ID=@b1", connection1.Connection());
            cmd.Parameters.AddWithValue("@b1", TxtID.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Branch Deleted!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Branches set Name=@p1 where ID=p2", connection1.Connection());
            cmd.Parameters.AddWithValue("@p1", TxtBranchName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtID.Text);
            cmd.ExecuteNonQuery();
            connection1.Connection().Close();
            MessageBox.Show("Branch Updated");
        }
    }
}
