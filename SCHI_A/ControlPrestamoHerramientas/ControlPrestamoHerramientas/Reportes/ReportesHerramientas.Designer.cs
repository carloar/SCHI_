namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReportesHerramientas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamo_herramientasDataSet = new ControlPrestamoHerramientas.prestamo_herramientasDataSet();
            this.herramientasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herramientasTableAdapter = new ControlPrestamoHerramientas.prestamo_herramientasDataSetTableAdapters.herramientasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_herramientasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DSH";
            reportDataSource3.Value = this.herramientasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteHerramientas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(983, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // prestamo_herramientasDataSet
            // 
            this.prestamo_herramientasDataSet.DataSetName = "prestamo_herramientasDataSet";
            this.prestamo_herramientasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herramientasBindingSource
            // 
            this.herramientasBindingSource.DataMember = "herramientas";
            this.herramientasBindingSource.DataSource = this.prestamo_herramientasDataSet;
            // 
            // herramientasTableAdapter
            // 
            this.herramientasTableAdapter.ClearBeforeFill = true;
            // 
            // ReportesHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 401);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportesHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesHerramientas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportesHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_herramientasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private prestamo_herramientasDataSet prestamo_herramientasDataSet;
        private System.Windows.Forms.BindingSource herramientasBindingSource;
        private prestamo_herramientasDataSetTableAdapters.herramientasTableAdapter herramientasTableAdapter;
    }
}