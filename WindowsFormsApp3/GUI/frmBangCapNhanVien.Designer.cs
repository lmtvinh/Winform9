namespace WindowsFormsApp3.GUI
{
    partial class frmBangCapNhanVien
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLThuVienDataSet = new WindowsFormsApp3.QLThuVienDataSet();
<<<<<<< Updated upstream
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
=======
            this.qLThuVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetBindingSource)).BeginInit();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rBangCapNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
<<<<<<< Updated upstream
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLThuVienDataSet;
=======
            // qLThuVienDataSetBindingSource
            // 
            this.qLThuVienDataSetBindingSource.DataSource = this.qLThuVienDataSet;
            this.qLThuVienDataSetBindingSource.Position = 0;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLThuVienDataSetBindingSource;
>>>>>>> Stashed changes
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangCapNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBangCapNhanVien";
            this.Text = "frmBangCapNhanVien";
            this.Load += new System.EventHandler(this.frmBangCapNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
<<<<<<< Updated upstream
=======
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSetBindingSource)).EndInit();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.BindingSource qLThuVienDataSetBindingSource;
>>>>>>> Stashed changes
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLThuVienDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}