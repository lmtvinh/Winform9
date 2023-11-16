using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class fDMSach : Form
    {
        public fDMSach()
        {
            InitializeComponent();
        }

        private void fDMSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsThuVien.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dsThuVien.SACH);

            this.reportViewer1.RefreshReport();
        }
    }
}
