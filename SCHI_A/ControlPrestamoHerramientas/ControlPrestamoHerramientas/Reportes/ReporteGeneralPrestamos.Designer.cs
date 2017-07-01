namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteGeneralPrestamos
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
            this.rvrgp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosPrestamos = new ControlPrestamoHerramientas.DatosPrestamos();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter = new ControlPrestamoHerramientas.DatosPrestamosTableAdapters.prestamoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvrgp
            // 
            this.rvrgp.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSP";
            reportDataSource1.Value = this.prestamoBindingSource;
            this.rvrgp.LocalReport.DataSources.Add(reportDataSource1);
            this.rvrgp.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReportePrestamosGeneral.rdlc";
            this.rvrgp.Location = new System.Drawing.Point(0, 0);
            this.rvrgp.Name = "rvrgp";
            this.rvrgp.Size = new System.Drawing.Size(745, 386);
            this.rvrgp.TabIndex = 0;
            // 
            // datosPrestamos
            // 
            this.datosPrestamos.DataSetName = "DatosPrestamos";
            this.datosPrestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "prestamo";
            this.prestamoBindingSource.DataSource = this.datosPrestamos;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneralPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 386);
            this.Controls.Add(this.rvrgp);
            this.Name = "ReporteGeneralPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteGeneralPrestamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteGeneralPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvrgp;
        private DatosPrestamos datosPrestamos;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private DatosPrestamosTableAdapters.prestamoTableAdapter prestamoTableAdapter;
    }
}