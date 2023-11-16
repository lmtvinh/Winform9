namespace WindowsFormsApp3.GUI
{
    partial class fRPhieuMuon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLThuVienDataSet = new WindowsFormsApp3.QLThuVienDataSet();
            this.pHIEUMUONSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUMUONSACHTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.PHIEUMUONSACHTableAdapter();
            this.cHITIETPHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETPHIEUMUONTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.CHITIETPHIEUMUONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pHIEUMUONSACHBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.cHITIETPHIEUMUONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rPhieuMuonSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1159, 673);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUMUONSACHBindingSource
            // 
            this.pHIEUMUONSACHBindingSource.DataMember = "PHIEUMUONSACH";
            this.pHIEUMUONSACHBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // pHIEUMUONSACHTableAdapter
            // 
            this.pHIEUMUONSACHTableAdapter.ClearBeforeFill = true;
            // 
            // cHITIETPHIEUMUONBindingSource
            // 
            this.cHITIETPHIEUMUONBindingSource.DataMember = "CHITIETPHIEUMUON";
            this.cHITIETPHIEUMUONBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // cHITIETPHIEUMUONTableAdapter
            // 
            this.cHITIETPHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // fRPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 673);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fRPhieuMuon";
            this.Text = "fRPhieuMuon";
            this.Load += new System.EventHandler(this.fRPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETPHIEUMUONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUMUONSACHBindingSource;
        private QLThuVienDataSetTableAdapters.PHIEUMUONSACHTableAdapter pHIEUMUONSACHTableAdapter;
        private System.Windows.Forms.BindingSource cHITIETPHIEUMUONBindingSource;
        private QLThuVienDataSetTableAdapters.CHITIETPHIEUMUONTableAdapter cHITIETPHIEUMUONTableAdapter;
    }
}