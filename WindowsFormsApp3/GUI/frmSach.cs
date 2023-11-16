using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BLL;
using WindowsFormsApp3.GUI;

namespace WindowsFormsApp3.GUI
{
    public partial class frmSach : Form
    {
        public bool themmoi = false;
        Sach sa = new Sach();
        public frmSach()
        {
            InitializeComponent();
        }
        void HienthiSach()
        {
            lsvSach.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvSach.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvSach.Items.Clear();
            DataTable dt = sa.LayDSSach();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSach.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
            lsvSach.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        void setNull()
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtNamXuatBan.Text = "";
            txtNhaXuatBan.Text = "";
            txtTriGia.Text = "";
        }

        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiSach();
        }
        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSach.SelectedIndices.Count > 0)
            {
                txtTenSach.Text = lsvSach.SelectedItems[0].SubItems[1].Text;
                txtTacGia.Text = lsvSach.SelectedItems[0].SubItems[2].Text;
                txtNamXuatBan.Text = lsvSach.SelectedItems[0].SubItems[3].Text;
                txtNhaXuatBan.Text = lsvSach.SelectedItems[0].SubItems[4].Text;
                txtTriGia.Text = lsvSach.SelectedItems[0].SubItems[5].Text;
                dtpNgayNhap.Value = DateTime.Parse(lsvSach.SelectedItems[0].SubItems[6].Text);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            themmoi = true;
            setButton(false);
            txtTenSach.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSach.SelectedIndices.Count > 0)
            {
                themmoi = false;
                setButton(false);
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
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
            if (lsvSach.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa sách", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sa.XoaSach(
                    lsvSach.SelectedItems[0].SubItems[0].Text);
                    lsvSach.Items.RemoveAt(
                    lsvSach.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgayNhap.Value);
            //Định dạng ngày tương ứng với trong CSDL SQLserver
            if (themmoi)
            {
                sa.ThemSach(txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtTriGia.Text, ngay); MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                sa.CapNhatSach(lsvSach.SelectedItems[0].SubItems[0].Text, txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtTriGia.Text, ngay); MessageBox.Show("Cập nhật thành công");
            }
            setButton(true);
            HienthiSach();
            setNull();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            fDMSach form = new fDMSach();
            form.Show();
        }
    }
}