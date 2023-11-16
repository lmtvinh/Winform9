namespace WindowsFormsApp3
{
    partial class fDMSach
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsThuVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsThuVien = new WindowsFormsApp3.QLThuVienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sACHTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVien)).BeginInit();
            this.SuspendLayout();
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.dsThuVienBindingSource;
            // 
            // dsThuVienBindingSource
            // 
            this.dsThuVienBindingSource.DataSource = this.dsThuVien;
            this.dsThuVienBindingSource.Position = 0;
            // 
            // dsThuVien
            // 
            this.dsThuVien.DataSetName = "dsThuVien";
            this.dsThuVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSach";
            reportDataSource1.Value = this.sACHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rDMSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1256, 802);
            this.reportViewer1.TabIndex = 0;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // fDMSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 802);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fDMSach";
            this.Text = "fDMSach";
            this.Load += new System.EventHandler(this.fDMSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsThuVienBindingSource;
        private QLThuVienDataSet dsThuVien;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLThuVienDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}