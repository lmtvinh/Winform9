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
    public partial class FDocgiaNotien : Form
    {
        public FDocgiaNotien()
        {
            InitializeComponent();
        }

        private void FDocgiaNotien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsdocgia.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.dsdocgia.DOCGIA);
           
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
