using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp3.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3.GUI
{
    public partial class frmThuTien : Form
    {
        public bool themmoi = false;
        PhieuThuTien ptt = new PhieuThuTien();
        public frmThuTien()
        {
            InitializeComponent();
        }
        void HienthiPhieuThu()
        {
            cbbDocGia.DataSource = ptt.LayDocGia();
            cbbDocGia.DisplayMember = "HoTenDocGia";
            cbbDocGia.ValueMember = "MaDocGia";
            cbbNhanVien.DataSource = ptt.LayNhanVien();
            cbbNhanVien.DisplayMember = "HoTenNhanVien";
            cbbNhanVien.ValueMember = "MaNhanVien";
            lsvPhieuThu.FullRowSelect = true; //cho phép chọn 1 dòng
            lsvPhieuThu.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            lsvPhieuThu.Items.Clear();
            DataTable dt = ptt.LayDSPhieuThu();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvPhieuThu.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void setNull()
        {
            txtSoTienNo.Text = "";
            txtSoTienThu.Text = "";
            txtDocGia.Text = "";
            txtNhanVien.Text = "";
            cbbDocGia.SelectedItem = null;
            cbbNhanVien.SelectedItem = null;
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

        bool checkValue()
        {
            int valueThu;
            if (txtSoTienThu.Text == "")
            {
                MessageBox.Show("Số tiền thu không được trống", "Báo lỗi");
                return false;
            }
            else if (!int.TryParse(txtSoTienThu.Text, out valueThu))
            {
                MessageBox.Show("Số tiền thu phải là số", "Báo lỗi");
                return false;
            }
            else if (int.Parse(txtSoTienNo.Text) < valueThu)
            {
                MessageBox.Show("Không thu quá số tiền nợ", "Báo lỗi");
                return false;
            }
            return true;
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            setButton(true);
            HienthiPhieuThu();
            setNull();
        }
        private void lsvPhieuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPhieuThu.SelectedIndices.Count > 0)
            {
                txtSoTienNo.Text = lsvPhieuThu.SelectedItems[0].SubItems[1].Text;
                txtSoTienThu.Text = lsvPhieuThu.SelectedItems[0].SubItems[2].Text;
                cbbDocGia.SelectedValue = lsvPhieuThu.SelectedItems[0].SubItems[3].Text;
                cbbNhanVien.SelectedValue = lsvPhieuThu.SelectedItems[0].SubItems[4].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setNull();
            themmoi = true;
            setButton(false);
            txtSoTienNo.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvPhieuThu.SelectedIndices.Count > 0)
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
            if (lsvPhieuThu.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa phiếu thu", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ptt.XoaPhieuThu(
                    lsvPhieuThu.SelectedItems[0].SubItems[0].Text);
                    lsvPhieuThu.Items.RemoveAt(
                    lsvPhieuThu.SelectedIndices[0]);
                    MessageBox.Show("Xóa thành công");
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkValue())
            {
                if (themmoi)
                {
                    ptt.ThemPhieuThu(txtSoTienNo.Text, txtSoTienThu.Text, txtDocGia.Text, txtNhanVien.Text);
                    ptt.CapNhatTienNo(txtDocGia.Text, txtSoTienNo.Text, txtSoTienThu.Text);
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    ptt.CapNhatPhieuThu(lsvPhieuThu.SelectedItems[0].SubItems[0].Text, txtSoTienNo.Text, txtSoTienThu.Text, txtDocGia.Text, txtNhanVien.Text);
                    ptt.CapNhatTienNo(txtDocGia.Text, txtSoTienNo.Text, txtSoTienThu.Text);
                    MessageBox.Show("Cập nhật thành công");
                }
                setButton(true);
                HienthiPhieuThu();
                setNull();
            }
        }

        private void cbbDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDocGia.SelectedItem != null)
            {
                txtDocGia.Text = cbbDocGia.SelectedValue.ToString();
                cbbDocGia.ValueMember = "TienNo";
                txtSoTienNo.Text = cbbDocGia.SelectedValue.ToString();
                cbbDocGia.ValueMember = "MaDocGia";
            }
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNhanVien.SelectedItem != null)
            {
                txtNhanVien.Text = cbbNhanVien.SelectedValue.ToString();
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            fThuTien form = new fThuTien();
            form.Show();
        }
    }
}
