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
    public partial class fThuTien : Form
    {
        public fThuTien()
        {
            InitializeComponent();
        }

        private void fThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet1.PHIEUTHUTIEN' table. You can move, or remove it, as needed.
            this.pHIEUTHUTIENTableAdapter.Fill(this.qLThuVienDataSet1.PHIEUTHUTIEN);
            // TODO: This line of code loads data into the 'qLThuVienDataSet.PHIEUTHUTIEN' table. You can move, or remove it, as needed.
            this.pHIEUTHUTIENTableAdapter.Fill(this.qLThuVienDataSet.PHIEUTHUTIEN);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
