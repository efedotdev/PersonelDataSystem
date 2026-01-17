namespace WindowsFormsApp1
{
    partial class Frmrapor
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
            this.personeldataDataSet = new WindowsFormsApp1.PersoneldataDataSet();
            this.personeldataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personeldataDataSet1 = new WindowsFormsApp1.PersoneldataDataSet1();
            this.personeldataDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTabloTableAdapter = new WindowsFormsApp1.PersoneldataDataSetTableAdapters.PersonelTabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTabloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personelTabloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(738, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // personeldataDataSet
            // 
            this.personeldataDataSet.DataSetName = "PersoneldataDataSet";
            this.personeldataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personeldataDataSetBindingSource
            // 
            this.personeldataDataSetBindingSource.DataSource = this.personeldataDataSet;
            this.personeldataDataSetBindingSource.Position = 0;
            // 
            // personeldataDataSet1
            // 
            this.personeldataDataSet1.DataSetName = "PersoneldataDataSet1";
            this.personeldataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personeldataDataSet1BindingSource
            // 
            this.personeldataDataSet1BindingSource.DataSource = this.personeldataDataSet1;
            this.personeldataDataSet1BindingSource.Position = 0;
            // 
            // personelTabloBindingSource
            // 
            this.personelTabloBindingSource.DataMember = "PersonelTablo";
            this.personelTabloBindingSource.DataSource = this.personeldataDataSetBindingSource;
            // 
            // personelTabloTableAdapter
            // 
            this.personelTabloTableAdapter.ClearBeforeFill = true;
            // 
            // Frmrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frmrapor";
            this.Text = "da";
            this.Load += new System.EventHandler(this.Frmrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldataDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTabloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personeldataDataSetBindingSource;
        private PersoneldataDataSet personeldataDataSet;
        private System.Windows.Forms.BindingSource personeldataDataSet1BindingSource;
        private PersoneldataDataSet1 personeldataDataSet1;
        private System.Windows.Forms.BindingSource personelTabloBindingSource;
        private PersoneldataDataSetTableAdapters.PersonelTabloTableAdapter personelTabloTableAdapter;
    }
}