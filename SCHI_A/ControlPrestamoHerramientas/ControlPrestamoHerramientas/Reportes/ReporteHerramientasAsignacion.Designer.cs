namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteHerramientasAsignacion
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
            this.rvha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSHerramientasAsignacion = new ControlPrestamoHerramientas.DSHerramientasAsignacion();
            this.herramientasasignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herramientas_asignacionTableAdapter = new ControlPrestamoHerramientas.DSHerramientasAsignacionTableAdapters.herramientas_asignacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvha
            // 
            this.rvha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DHASIGNACION";
            reportDataSource1.Value = this.herramientasasignacionBindingSource;
            this.rvha.LocalReport.DataSources.Add(reportDataSource1);
            this.rvha.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteGeneralHerramientasAsinacion.rdlc";
            this.rvha.Location = new System.Drawing.Point(0, 0);
            this.rvha.Name = "rvha";
            this.rvha.Size = new System.Drawing.Size(718, 371);
            this.rvha.TabIndex = 0;
            // 
            // dSHerramientasAsignacion
            // 
            this.dSHerramientasAsignacion.DataSetName = "DSHerramientasAsignacion";
            this.dSHerramientasAsignacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herramientasasignacionBindingSource
            // 
            this.herramientasasignacionBindingSource.DataMember = "herramientas_asignacion";
            this.herramientasasignacionBindingSource.DataSource = this.dSHerramientasAsignacion;
            // 
            // herramientas_asignacionTableAdapter
            // 
            this.herramientas_asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteHerramientasAsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 371);
            this.Controls.Add(this.rvha);
            this.Name = "ReporteHerramientasAsignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteHerramientasAsignacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteHerramientasAsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvha;
        private DSHerramientasAsignacion dSHerramientasAsignacion;
        private System.Windows.Forms.BindingSource herramientasasignacionBindingSource;
        private DSHerramientasAsignacionTableAdapters.herramientas_asignacionTableAdapter herramientas_asignacionTableAdapter;
    }
}