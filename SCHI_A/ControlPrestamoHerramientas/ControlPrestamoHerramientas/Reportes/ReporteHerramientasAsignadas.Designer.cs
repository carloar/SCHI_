namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteHerramientasAsignadas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSHerramientasAsignadas = new ControlPrestamoHerramientas.DSHerramientasAsignadas();
            this.herramientasasignadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herramientas_asignadasTableAdapter = new ControlPrestamoHerramientas.DSHerramientasAsignadasTableAdapters.herramientas_asignadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvha
            // 
            this.rvha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSHA";
            reportDataSource2.Value = this.herramientasasignadasBindingSource;
            this.rvha.LocalReport.DataSources.Add(reportDataSource2);
            this.rvha.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteHerramientasAsignadas.rdlc";
            this.rvha.Location = new System.Drawing.Point(0, 0);
            this.rvha.Name = "rvha";
            this.rvha.Size = new System.Drawing.Size(746, 374);
            this.rvha.TabIndex = 0;
            // 
            // dSHerramientasAsignadas
            // 
            this.dSHerramientasAsignadas.DataSetName = "DSHerramientasAsignadas";
            this.dSHerramientasAsignadas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // herramientasasignadasBindingSource
            // 
            this.herramientasasignadasBindingSource.DataMember = "herramientas_asignadas";
            this.herramientasasignadasBindingSource.DataSource = this.dSHerramientasAsignadas;
            // 
            // herramientas_asignadasTableAdapter
            // 
            this.herramientas_asignadasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteHerramientasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 374);
            this.Controls.Add(this.rvha);
            this.Name = "ReporteHerramientasAsignadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteHerramientasAsignadas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteHerramientasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvha;
        private DSHerramientasAsignadas dSHerramientasAsignadas;
        private System.Windows.Forms.BindingSource herramientasasignadasBindingSource;
        private DSHerramientasAsignadasTableAdapters.herramientas_asignadasTableAdapter herramientas_asignadasTableAdapter;
    }
}