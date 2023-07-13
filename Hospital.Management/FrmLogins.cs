using System;
using System.Windows.Forms;

namespace Hospital.Management
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void BtnPatientLogin_Click(object sender, EventArgs e)
        {
            FrmPatientLogin frm = new FrmPatientLogin();
            frm.Show();
            this.Hide();
        }

        private void BtnDoctorLogin_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frm = new FrmDoctorLogin();
            frm.Show();
            this.Hide();
        }

        private void BtnSecretaryLogin_Click(object sender, EventArgs e)
        {
            FrmSecretaryLogin frm = new FrmSecretaryLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmLogins_Load(object sender, EventArgs e)
        {

        }
    }
}
