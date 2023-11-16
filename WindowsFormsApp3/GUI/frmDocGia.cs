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
    public partial class frmDocGia : Form
    {
        public bool themmoi = false;
        NhanVien nv = new NhanVien();
        BangCap bangCap = new BangCap();
        public frmDocGia()
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
            DataTable dt = bangCap.LayDSBC();
            cboBangCap.DataSource = dt;
            cboBangCap.DisplayMember = "TenBangcap";
            cboBangCap.ValueMember = "MaBangcap";
        }
    }
}
