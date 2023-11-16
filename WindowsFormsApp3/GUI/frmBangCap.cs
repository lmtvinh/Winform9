using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp3.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.GUI
{
    public partial class frmBangCap : Form
    {
        public frmBangCap()
        {
            InitializeComponent();
        }

        private void frmBangCapReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet1.BANGCAP' table. You can move, or remove it, as needed.
            this.bANGCAPTableAdapter.Fill(this.qLTHUVIENDataSet1.BANGCAP);
        }
        public bool themmoi = false; BangCap bc = new BangCap();

        void HienthiBangCap()
        {
            listView1.Items.Clear(); DataTable dt = bc.LayDSBC();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                /*                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                                lvi.SubItems.Add(dt.Rows[i][5].ToString());*/
            }
        }
        void setNull()
        {
            txtID.Text = ""; txtName.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val; btnXoa.Enabled = val; btnSua.Enabled = val; btnThoat.Enabled = val; btnLuu.Enabled = !val; btnHuy.Enabled = !val;
        }

        private void frmBangCap_Load(object sender, EventArgs e)
        {
            setNull(); setButton(true);
            HienthiBangCap();
        }

        private void lsvBangCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txtName.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                themmoi = false; setButton(false);
            }
            else
            {
                MessageBox.Show("Bạn  phải  chọn  mẫu  tin  cập  nhật",
                "Sửa mẫu tin");
            }



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  bằng  cấp", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bc.XoaBangCap(
                    listView1.SelectedItems[0].SubItems[0].Text); listView1.Items.RemoveAt(
                    listView1.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                bc.ThemBangCap(txtName.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                bc.CapNhatBangCap(
                listView1.SelectedItems[0].SubItems[0].Text, txtName.Text);

                MessageBox.Show("Cập  nhật  thành  công");
            }
            HienthiBangCap();
            setNull();
        }
    }
}
