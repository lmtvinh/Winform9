namespace WindowsFormsApp3
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
            this.dsdocgiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdocgia = new LapTheDocGia.dsdocgia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOCGIATableAdapter = new LapTheDocGia.dsdocgiaTableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dOCGIABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LapTheDocGia.rDocgiaNotien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.dsdocgiaBindingSource;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // FDocgiaNotien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FDocgiaNotien";
            this.Text = "FDocgiaNotien";
            this.Load += new System.EventHandler(this.FDocgiaNotien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsdocgiaBindingSource;
        private dsdocgia dsdocgia;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private dsdocgiaTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
    }
}