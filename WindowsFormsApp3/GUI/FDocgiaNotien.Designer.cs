namespace WindowsFormsApp3.GUI
{
    partial class FDocgiaNotien
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
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdocgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdocgia = new WindowsFormsApp3.QLThuVienDataSet();
            this.dOCGIATableAdapter = new WindowsFormsApp3.QLThuVienDataSetTableAdapters.DOCGIATableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dOCGIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.dsdocgiaBindingSource;
            // 
            // dsdocgiaBindingSource
            // 
            this.dsdocgiaBindingSource.DataSource = this.dsdocgia;
            this.dsdocgiaBindingSource.Position = 0;
            // 
            // dsdocgia
            // 
            this.dsdocgia.DataSetName = "dsdocgia";
            this.dsdocgia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dOCGIABindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.rDocgiaNotien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // dOCGIABindingSource1
            // 
            this.dOCGIABindingSource1.DataMember = "DOCGIA";
            this.dOCGIABindingSource1.DataSource = this.dsdocgia;
            // 
            // FDocgiaNotien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FDocgiaNotien";
            this.Text = "FDocgiaNotien";
            this.Load += new System.EventHandler(this.FDocgiaNotien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dsdocgiaBindingSource;
        private QLThuVienDataSet dsdocgia;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QLThuVienDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dOCGIABindingSource1;
    }
}