namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteHerramientasAsignadasxFicha
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
            this.rvhaf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSHerramientasAsignadas = new ControlPrestamoHerramientas.DSHerramientasAsignadas();
            this.herramientasasignadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.herramientas_asignadasTableAdapter = new ControlPrestamoHerramientas.DSHerramientasAsignadasTableAdapters.herramientas_asignadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvhaf
            // 
            this.rvhaf.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSHA";
            reportDataSource1.Value = this.herramientasasignadasBindingSource;
            this.rvhaf.LocalReport.DataSources.Add(reportDataSource1);
            this.rvhaf.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteHerramientasAsignadasFicha.rdlc";
            this.rvhaf.Location = new System.Drawing.Point(0, 0);
            this.rvhaf.Name = "rvhaf";
            this.rvhaf.Size = new System.Drawing.Size(710, 386);
            this.rvhaf.TabIndex = 0;
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
            // ReporteHerramientasAsignadasxFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 386);
            this.Controls.Add(this.rvhaf);
            this.Name = "ReporteHerramientasAsignadasxFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteHerramientasAsignadasxFicha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteHerramientasAsignadasxFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSHerramientasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.herramientasasignadasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvhaf;
        private DSHerramientasAsignadas dSHerramientasAsignadas;
        private System.Windows.Forms.BindingSource herramientasasignadasBindingSource;
        private DSHerramientasAsignadasTableAdapters.herramientas_asignadasTableAdapter herramientas_asignadasTableAdapter;
    }
}