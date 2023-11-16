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
    public partial class fRPhieuMuon : Form
    {
        public fRPhieuMuon()
        {
            InitializeComponent();
        }

        private void fRPhieuMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLThuVienDataSet.CHITIETPHIEUMUON' table. You can move, or remove it, as needed.
            this.cHITIETPHIEUMUONTableAdapter.Fill(this.qLThuVienDataSet.CHITIETPHIEUMUON);
            // TODO: This line of code loads data into the 'qLThuVienDataSet.PHIEUMUONSACH' table. You can move, or remove it, as needed.
            this.pHIEUMUONSACHTableAdapter.Fill(this.qLThuVienDataSet.PHIEUMUONSACH);

            this.reportViewer1.RefreshReport();
        }
    }
}
