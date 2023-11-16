using System;

namespace WindowsFormsApp3.GUI
{
    partial class frmDocGia
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tienno = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hotendocgia = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lsvDG = new System.Windows.Forms.ListView();
            this.MaDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtp_nhh = new System.Windows.Forms.DateTimePicker();
            this.dtp_nlt = new System.Windows.Forms.DateTimePicker();
            this.btn_huy = new System.Windows.Forms.Button();
            this.repo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền Nợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Lập Thẻ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Hết Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 195);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Họ Tên Độc Gỉa";
            // 
            // txt_tienno
            // 
            this.txt_tienno.Location = new System.Drawing.Point(167, 249);
            this.txt_tienno.Name = "txt_tienno";
            this.txt_tienno.Size = new System.Drawing.Size(198, 29);
            this.txt_tienno.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(167, 198);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(332, 29);
            this.txt_email.TabIndex = 13;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(167, 118);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(198, 29);
            this.txt_diachi.TabIndex = 14;
            // 
            // txt_hotendocgia
            // 
            this.txt_hotendocgia.Location = new System.Drawing.Point(167, 50);
            this.txt_hotendocgia.Name = "txt_hotendocgia";
            this.txt_hotendocgia.Size = new System.Drawing.Size(198, 29);
            this.txt_hotendocgia.TabIndex = 15;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(341, 300);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(99, 40);
            this.btn_Them.TabIndex = 16;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsvDG
            // 
            this.lsvDG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDocGia,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvDG.FullRowSelect = true;
            this.lsvDG.HideSelection = false;
            this.lsvDG.Location = new System.Drawing.Point(25, 346);
            this.lsvDG.Name = "lsvDG";
            this.lsvDG.Size = new System.Drawing.Size(1304, 220);
            this.lsvDG.TabIndex = 18;
            this.lsvDG.UseCompatibleStateImageBehavior = false;
            this.lsvDG.View = System.Windows.Forms.View.Details;
            this.lsvDG.SelectedIndexChanged += new System.EventHandler(this.lsvDG_SelectedIndexChanged);
            // 
            // MaDocGia
            // 
            this.MaDocGia.Text = "Mã Độc Gỉa";
            this.MaDocGia.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên Độc Gỉa";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Lập Thẻ";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ngày Hết Hạn";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tiền Nợ";
            this.columnHeader8.Width = 100;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(446, 300);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(99, 40);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(551, 300);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(99, 40);
            this.btn_xoa.TabIndex = 20;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(656, 300);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(99, 40);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(866, 300);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 40);
            this.btn_thoat.TabIndex = 22;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(704, 44);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(255, 29);
            this.dtpNgaySinh.TabIndex = 23;
            // 
            // dtp_nhh
            // 
            this.dtp_nhh.Location = new System.Drawing.Point(704, 120);
            this.dtp_nhh.Name = "dtp_nhh";
            this.dtp_nhh.Size = new System.Drawing.Size(255, 29);
            this.dtp_nhh.TabIndex = 24;
            // 
            // dtp_nlt
            // 
            this.dtp_nlt.Location = new System.Drawing.Point(704, 195);
            this.dtp_nlt.Name = "dtp_nlt";
            this.dtp_nlt.Size = new System.Drawing.Size(255, 29);
            this.dtp_nlt.TabIndex = 25;
            this.dtp_nlt.ValueChanged += new System.EventHandler(this.dtp_nlt_ValueChanged);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(761, 300);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(99, 40);
            this.btn_huy.TabIndex = 26;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // repo
            // 
            this.repo.Location = new System.Drawing.Point(197, 300);
            this.repo.Name = "repo";
            this.repo.Size = new System.Drawing.Size(75, 38);
            this.repo.TabIndex = 27;
            this.repo.Text = "Báo Cáo";
            this.repo.UseVisualStyleBackColor = true;
            this.repo.Click += new System.EventHandler(this.repo_Click_1);
            // 
            // frmDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 586);
            this.Controls.Add(this.repo);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.dtp_nlt);
            this.Controls.Add(this.dtp_nhh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.lsvDG);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_hotendocgia);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_tienno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDocGia";
            this.Text = "Lập Thẻ Độc Gỉa";
            this.Load += new System.EventHandler(this.frmdocgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tienno;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hotendocgia;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        //private QLThuVienDataSet DataSet1;
        private System.Windows.Forms.ListView lsvDG;
        private System.Windows.Forms.ColumnHeader MaDocGia;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtp_nhh;
        private System.Windows.Forms.DateTimePicker dtp_nlt;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button repo;
        //private EventHandler repo_Click;
    }
}

