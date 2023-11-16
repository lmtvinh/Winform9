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

namespace WindowsFormsApp3.GUI
{
    public partial class frmdocgia : Form
    {

        public bool themmoi = false;
        DocGia dg = new DocGia();
        public frmdocgia()
        {
            InitializeComponent();
        }

        void HienThiDocGia()
        {
            lsvDG.Items.Clear();
            DataTable dt = dg.layDSDG();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi =
                lsvDG.Items.Add(dt.Rows[i][0].ToString()); lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
            }

        }

        

        void setNull()
        {

            txt_hotendocgia.Text = "";
            txt_diachi.Text = "";
            txt_email.Text = "";
            txt_tienno.Text = "";

        }
        void setButton(bool val)
        {
            btn_Them.Enabled = val;
            btn_xoa.Enabled = val;
            btn_sua.Enabled = val;
            btn_thoat.Enabled = val;
            btn_luu.Enabled = !val;
            btn_huy.Enabled = !val;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            themmoi = true;
            setButton(false);
            txt_hotendocgia.Focus();

        }

       

        private void frmdocgia_Load(object sender, EventArgs e)
        {
            setNull();
            setButton(true);
            HienThiDocGia();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh.Value);
            string ngaylapthe = String.Format("{0:MM/dd/yyyy}", dtp_nlt.Value);
            string ngayhethan = String.Format("{0:MM/dd/yyyy}", dtp_nhh.Value);

            if (themmoi)
            {
                dg.ThemDG(txt_hotendocgia.Text, ngay, txt_diachi.Text, txt_email.Text, ngaylapthe, ngayhethan, txt_tienno.Text);
                MessageBox.Show("Thêm  mới  thành  công");
            }
            else
            {
                dg.CapNhatDG(lsvDG.SelectedItems[0].SubItems[0].Text, txt_hotendocgia.Text, ngay, txt_diachi.Text, txt_email.Text, ngaylapthe, ngayhethan,txt_tienno.Text);
                MessageBox.Show("Cập  nhật  thành  công");

            }
            HienThiDocGia();
            setNull();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lsvDG.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không?", "Xóa  bằng  cấp", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dg.XoaDocGia(
                    lsvDG.SelectedItems[0].SubItems[0].Text);
                    lsvDG.Items.RemoveAt(lsvDG.SelectedIndices[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn  phải  chọn  mẩu  tin  cần  xóa");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setButton(true);
        }

        private void lsvDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDG.SelectedIndices.Count > 0)
            {
                txt_hotendocgia.Text = lsvDG.SelectedItems[0].SubItems[1].Text;
                //Chuyen sang kieu dateTime
                dtpNgaySinh.Value = DateTime.Parse(lsvDG.SelectedItems[0].SubItems[2].Text);
                txt_diachi.Text = lsvDG.SelectedItems[0].SubItems[3].Text;
                txt_email.Text = lsvDG.SelectedItems[0].SubItems[4].Text;
                dtp_nlt.Value = DateTime.Parse(lsvDG.SelectedItems[0].SubItems[5].Text);
                dtp_nhh.Value = DateTime.Parse(lsvDG.SelectedItems[0].SubItems[6].Text);
                txt_tienno.Text = lsvDG.SelectedItems[0].SubItems[7].Text;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lsvDG.SelectedIndices.Count > 0)
            {
                themmoi = false; 
                setButton(false);
            }
            else
            MessageBox.Show("Bạn  phải  chọn  mẫu  tin  cập  nhật",
            "Sửa mẫu tin");

        }

        private void repo_Click_1(object sender, EventArgs e)
        {
            
            FDocgiaNotien f = new FDocgiaNotien();
            f.Show();

        }

        private void dtp_nlt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
