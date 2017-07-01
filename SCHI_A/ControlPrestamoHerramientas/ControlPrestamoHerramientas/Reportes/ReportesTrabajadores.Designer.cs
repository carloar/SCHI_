namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReportesTrabajadores
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
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamo_herramientasDataSet = new ControlPrestamoHerramientas.prestamo_herramientasDataSet();
            this.empleadosTableAdapter = new ControlPrestamoHerramientas.prestamo_herramientasDataSetTableAdapters.empleadosTableAdapter();
            this.rvtrab = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_herramientasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.prestamo_herramientasDataSet;
            // 
            // prestamo_herramientasDataSet
            // 
            this.prestamo_herramientasDataSet.DataSetName = "prestamo_herramientasDataSet";
            this.prestamo_herramientasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // rvtrab
            // 
            this.rvtrab.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.empleadosBindingSource;
            this.rvtrab.LocalReport.DataSources.Add(reportDataSource1);
            this.rvtrab.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteTrabajadores.rdlc";
            this.rvtrab.Location = new System.Drawing.Point(0, 0);
            this.rvtrab.Name = "rvtrab";
            this.rvtrab.Size = new System.Drawing.Size(753, 392);
            this.rvtrab.TabIndex = 0;
            // 
            // ReportesTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 392);
            this.Controls.Add(this.rvtrab);
            this.Name = "ReportesTrabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesTrabajadores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportesTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamo_herramientasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private prestamo_herramientasDataSet prestamo_herramientasDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private prestamo_herramientasDataSetTableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvtrab;
    }
}