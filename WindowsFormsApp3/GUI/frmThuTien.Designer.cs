using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.GUI
{
    partial class frmThuTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbbDocGia = new System.Windows.Forms.ComboBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvPhieuThu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(273, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU THU TIỀN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtDocGia);
            this.groupBox1.Controls.Add(this.cbbNhanVien);
            this.groupBox1.Controls.Add(this.cbbDocGia);
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.txtSoTienNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(362, 112);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(103, 22);
            this.txtNhanVien.TabIndex = 9;
            // 
            // txtDocGia
            // 
            this.txtDocGia.Enabled = false;
            this.txtDocGia.Location = new System.Drawing.Point(362, 84);
            this.txtDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(103, 22);
            this.txtDocGia.TabIndex = 8;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(114, 113);
            this.cbbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(222, 24);
            this.cbbNhanVien.TabIndex = 7;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            // 
            // cbbDocGia
            // 
            this.cbbDocGia.FormattingEnabled = true;
            this.cbbDocGia.Location = new System.Drawing.Point(114, 84);
            this.cbbDocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDocGia.Name = "cbbDocGia";
            this.cbbDocGia.Size = new System.Drawing.Size(222, 24);
            this.cbbDocGia.TabIndex = 6;
            this.cbbDocGia.SelectedIndexChanged += new System.EventHandler(this.cbbDocGia_SelectedIndexChanged);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(114, 55);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(222, 22);
            this.txtSoTienThu.TabIndex = 5;
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Location = new System.Drawing.Point(114, 26);
            this.txtSoTienNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(222, 22);
            this.txtSoTienNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đọc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tiền thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số tiền nợ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 227);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(298, 227);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 38);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(398, 227);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(498, 227);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 38);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(598, 227);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 38);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(698, 227);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvPhieuThu);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(776, 262);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // lsvPhieuThu
            // 
            this.lsvPhieuThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvPhieuThu.HideSelection = false;
            this.lsvPhieuThu.Location = new System.Drawing.Point(6, 21);
            this.lsvPhieuThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvPhieuThu.Name = "lsvPhieuThu";
            this.lsvPhieuThu.Size = new System.Drawing.Size(764, 237);
            this.lsvPhieuThu.TabIndex = 0;
            this.lsvPhieuThu.UseCompatibleStateImageBehavior = false;
            this.lsvPhieuThu.SelectedIndexChanged += new System.EventHandler(this.lsvPhieuThu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Phiếu";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Tiền Nợ";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Tiền Thu";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Đọc Giả";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Nhân Viên";
            this.columnHeader5.Width = 100;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(18, 227);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(94, 38);
            this.btnBaoCao.TabIndex = 9;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // frmThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThuTien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtNhanVien;
        private TextBox txtDocGia;
        private ComboBox cbbNhanVien;
        private ComboBox cbbDocGia;
        private TextBox txtSoTienThu;
        private TextBox txtSoTienNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private GroupBox groupBox2;
        private ListView lsvPhieuThu;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnBaoCao;
    }
}