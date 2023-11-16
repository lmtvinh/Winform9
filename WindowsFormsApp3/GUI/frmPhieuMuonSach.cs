using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.GUI
{
    public partial class frmPhieuMuonSach : Form
    {
        public bool themmoi = false;
        BLL.Sach sa = new BLL.Sach();
        BLL.DocGia dg = new BLL.DocGia();
        BLL.PhieuMuonSach pm = new BLL.PhieuMuonSach();
        BLL.ChiTietPhieuMuon ctpm = new BLL.ChiTietPhieuMuon();
        public frmPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void FrmMuonSach_Load(object sender, EventArgs e)
        {
            setNull(); setButton(true);
            HienthiPhieuMuon();
        }

        void setNull()
        {
            txtID.Text = ""; txtCus.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val; btnXoa.Enabled = val; btnSua.Enabled = val; btnThoat.Enabled = val; btnLuu.Enabled = !val; btnHuy.Enabled = !val;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
            {
                MessageBox.Show("Bạn  phải  chọn  mẫu  tin  cập  nhật",
                "Sửa mẫu tin");
            }
        }
        void HienthiPhieuMuon()
        {
            txtCus.DataSource = dg.layDSDG();
            txtCus.DisplayMember = "MaDocGia";
            txtCus.ValueMember = "MaDocGia";
            txtIDBook.DataSource = sa.LayDSSach();
            txtIDBook.DisplayMember = "MaSach";
            txtIDBook.ValueMember = "MaSach";
            listView1.Items.Clear();
            DataTable dt = pm.LayDSPM();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
            }
        }
        void HienthiChiTietPhieuMuon()
        {
            listView1.Items.Clear();
            DataTable dt = ctpm.LayDSCTPM();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themmoi)
            {
                pm.ThemPhieuMuon(dt.Text, txtCus.Text);
                ctpm.ThemChiTietPhieuMuon(txtIDBook.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                pm.CapNhatPhieuMuon(
                listView1.SelectedItems[0].SubItems[0].Text, dt.Text, txtCus.Text);
                ctpm.CapNhatChiTietPhieuMuon(txtID.Text,txtIDBook.Text);

                MessageBox.Show("Cập  nhật  thành  công");
            }
            HienthiPhieuMuon();
            HienthiChiTietPhieuMuon();
            setNull();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                txtID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dt.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtCus.SelectedValue = listView1.SelectedItems[0].SubItems[2].Text;
                //txtIDBook.SelectedValue = listView1.SelectedItems[0].SubItems[3].Text;
                /*                txtIDBook.Text=pm.LayCTPM(txtIDBook.Text);
                                lblBook.Text=pm.hienThiBook(txtIDBook.Text);
                                lblCus.Text=pm.hienThiCus(txtCus.Text).ToString();*/
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            themmoi = true;
            setButton(false);
            dt.Focus();
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
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa phiếu mượn", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pm.XoaPhieuMuon(listView1.SelectedItems[0].SubItems[0].Text);
                    ctpm.XoaChiTietPhieuMuon(listView1.SelectedItems[0].SubItems[0].Text);
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fRPhieuMuon form = new fRPhieuMuon();
            form.Show();
        }
    }
}
