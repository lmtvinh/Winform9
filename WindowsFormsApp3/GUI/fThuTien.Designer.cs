namespace WindowsFormsApp3.GUI
{
    partial class fThuTien
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
            this.pHIEUTHUTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTIENTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.PHIEUTHUTIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPhieuThu";
            reportDataSource1.Value = this.pHIEUTHUTIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rThuTien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1188, 650);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUTHUTIENBindingSource
            // 
            this.pHIEUTHUTIENBindingSource.DataMember = "PHIEUTHUTIEN";
            this.pHIEUTHUTIENBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // pHIEUTHUTIENTableAdapter
            // 
            this.pHIEUTHUTIENTableAdapter.ClearBeforeFill = true;
            // 
            // fThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 650);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fThuTien";
            this.Text = "fThuTien";
            this.Load += new System.EventHandler(this.fThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTHUTIENBindingSource;
        private QLThuVienDataSetTableAdapters.PHIEUTHUTIENTableAdapter pHIEUTHUTIENTableAdapter;
    }
}