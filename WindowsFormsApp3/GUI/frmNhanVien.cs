using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BLL;

namespace WindowsFormsApp3.GUI
{
    public partial class frmNhanVien : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        BangCap bc = new BangCap();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        public bool checkTxtPhonenumber()
        {
            string input = txtSoDienThoai.Text;
            bool isValid = Regex.IsMatch(input, "^[0-9]{10}$");

            if (!isValid)
            {
                // Hiển thị thông báo lỗi hoặc xử lý tùy ý
                MessageBox.Show("Vui lòng chỉ nhập 10 chữ số và không nhập ký tự hoặc chữ cái.");

                // Xóa các ký tự không hợp lệ từ TextBox
                txtSoDienThoai.Text = Regex.Replace(input, "[^0-9]", "");
                return false;
            }
            return true;
        }

        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }
        }
        void setNull()
        {
            txtHoTen.Text = ""; txtDiaChi.Text = ""; txtSoDienThoai.Text = "";
        }
        void setButton(bool val)
        {
            btnAdd.Enabled = val;
            btnDelete.Enabled = val;
            btnUpdate.Enabled = val;
            btnExit.Enabled = val;
            btnSave.Enabled = !val;
            btnCancel.Enabled = !val;
        }
        void HienthiBangcap()
        {
            DataTable dt = bc.LayDSBC();
            cboBangCap.DataSource = dt;
            cboBangCap.DisplayMember = "TenBangcap";
            cboBangCap.ValueMember = "MaBangcap";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienthiNhanvien();
            HienthiBangcap();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Equals("") || txtDiaChi.Text.Equals("") || txtSoDienThoai.Text.Equals("") || !checkTxtPhonenumber())
            {
                MessageBox.Show("Vui lòng nhập đủ các trường thông tin.", "Thông báo lỗi", MessageBoxButtons.OK);
            }
            else
            {
                themmoi = true;
                setButton(false);
                txtHoTen.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lsvNhanVien.Items.Clear();
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            //Định  dạng  ngày  tương  ứng  với  trong  CSDL  SQLserver
            if (themmoi)
            {
                nv.ThemNhanVien(txtHoTen.Text, ngay, txtDiaChi.Text, txtSoDienThoai.Text, cboBangCap.SelectedValue.ToString());
                MessageBox.Show("Thêm  mới  thành  công");
            }
            else
            {
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txtHoTen.Text, ngay, txtDiaChi.Text, txtSoDienThoai.Text, cboBangCap.SelectedValue.ToString());
                MessageBox.Show("Cập  nhật  thành  công");
            }
            HienthiNhanvien();
            setNull();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn  có  chắc  xóa  không?", "Xóa nhân viên", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                    lsvNhanVien.Items.RemoveAt(lsvNhanVien.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkTxtPhonenumber())
            {
                if (lsvNhanVien.SelectedIndices.Count > 0)
                {
                    themmoi = false;
                    setButton(false);
                }
                else
                {
                    MessageBox.Show("Bạn  phải  chọn  mẫu  tin  cập  nhật", "Sửa mẫu tin");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtpNgaySinh.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                txtSoDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                //Tìm  vị  trí  của  Tên  bằng  cấp  trong  Combobox
                cboBangCap.SelectedIndex = cboBangCap.FindString(lsvNhanVien.SelectedItems[0].SubItems[5].Text);
            }
        }
    }
}
