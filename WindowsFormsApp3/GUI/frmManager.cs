using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.GUI
{
    public partial class frmManager : Form
    {
        private Form activeForm = null;
        public frmManager()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSach());
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDocGia());
        }

        private void btnBangCap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBangCap());
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThuTien());
        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuMuonSach());
        }
    }
}
