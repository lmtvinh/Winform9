namespace WindowsFormsApp3.GUI
{
    partial class frmManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnBangCap = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThuTien = new System.Windows.Forms.Button();
            this.btnPhieuMuon = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChild);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 588);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPhieuMuon);
            this.panel2.Controls.Add(this.btnThuTien);
            this.panel2.Controls.Add(this.btnSach);
            this.panel2.Controls.Add(this.btnBangCap);
            this.panel2.Controls.Add(this.btnDocGia);
            this.panel2.Controls.Add(this.btnQLNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 588);
            this.panel2.TabIndex = 0;
            // 
            // btnDocGia
            // 
            this.btnDocGia.Location = new System.Drawing.Point(0, 128);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(146, 52);
            this.btnDocGia.TabIndex = 1;
            this.btnDocGia.Text = "Độc Giả";
            this.btnDocGia.UseVisualStyleBackColor = true;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 70);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(146, 52);
            this.btnQLNhanVien.TabIndex = 0;
            this.btnQLNhanVien.Text = "Nhân Viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnBangCap
            // 
            this.btnBangCap.Location = new System.Drawing.Point(0, 186);
            this.btnBangCap.Name = "btnBangCap";
            this.btnBangCap.Size = new System.Drawing.Size(146, 52);
            this.btnBangCap.TabIndex = 2;
            this.btnBangCap.Text = "Bằng Cấp";
            this.btnBangCap.UseVisualStyleBackColor = true;
            this.btnBangCap.Click += new System.EventHandler(this.btnBangCap_Click);
            // 
            // btnSach
            // 
            this.btnSach.Location = new System.Drawing.Point(1, 12);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(146, 52);
            this.btnSach.TabIndex = 3;
            this.btnSach.Text = "Sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnThuTien
            // 
            this.btnThuTien.Location = new System.Drawing.Point(0, 244);
            this.btnThuTien.Name = "btnThuTien";
            this.btnThuTien.Size = new System.Drawing.Size(146, 52);
            this.btnThuTien.TabIndex = 4;
            this.btnThuTien.Text = "Thu Tiền";
            this.btnThuTien.UseVisualStyleBackColor = true;
            this.btnThuTien.Click += new System.EventHandler(this.btnThuTien_Click);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.Location = new System.Drawing.Point(0, 302);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(146, 52);
            this.btnPhieuMuon.TabIndex = 3;
            this.btnPhieuMuon.Text = "Mượn Sách";
            this.btnPhieuMuon.UseVisualStyleBackColor = true;
            this.btnPhieuMuon.Click += new System.EventHandler(this.btnPhieuMuon_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(150, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(783, 588);
            this.panelChild.TabIndex = 1;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnBangCap;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnThuTien;
        private System.Windows.Forms.Button btnPhieuMuon;
        private System.Windows.Forms.Panel panelChild;
    }
}