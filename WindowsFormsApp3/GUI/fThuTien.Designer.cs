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
            this.pHIEUTHUTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLThuVienDataSet = new WindowsFormsApp3.QLThuVienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLThuVienDataSet1 = new WindowsFormsApp3.QLThuVienDataSet();
            this.qLThuVienDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUTHUTIENTableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.PHIEUTHUTIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pHIEUTHUTIENBindingSource
            // 
            this.pHIEUTHUTIENBindingSource.DataMember = "PHIEUTHUTIEN";
            this.pHIEUTHUTIENBindingSource.DataSource = this.qLThuVienDataSet;
            // 
            // qLThuVienDataSet
            // 
            this.qLThuVienDataSet.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsPhieuThu";
            reportDataSource1.Value = this.pHIEUTHUTIENBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rThuTien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1211, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLThuVienDataSet1
            // 
            this.qLThuVienDataSet1.DataSetName = "QLThuVienDataSet";
            this.qLThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLThuVienDataSet1BindingSource
            // 
            this.qLThuVienDataSet1BindingSource.DataSource = this.qLThuVienDataSet1;
            this.qLThuVienDataSet1BindingSource.Position = 0;
            // 
            // pHIEUTHUTIENBindingSource1
            // 
            this.pHIEUTHUTIENBindingSource1.DataMember = "PHIEUTHUTIEN";
            this.pHIEUTHUTIENBindingSource1.DataSource = this.qLThuVienDataSet1BindingSource;
            // 
            // pHIEUTHUTIENTableAdapter
            // 
            this.pHIEUTHUTIENTableAdapter.ClearBeforeFill = true;
            // 
            // fThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 579);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fThuTien";
            this.Text = "fThuTien";
            this.Load += new System.EventHandler(this.fThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLThuVienDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUTHUTIENBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLThuVienDataSet qLThuVienDataSet;
        private System.Windows.Forms.BindingSource pHIEUTHUTIENBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLThuVienDataSet qLThuVienDataSet1;
        private System.Windows.Forms.BindingSource qLThuVienDataSet1BindingSource;
        private System.Windows.Forms.BindingSource pHIEUTHUTIENBindingSource1;
        private QLThuVienDataSetTableAdapters.PHIEUTHUTIENTableAdapter pHIEUTHUTIENTableAdapter;
    }
}