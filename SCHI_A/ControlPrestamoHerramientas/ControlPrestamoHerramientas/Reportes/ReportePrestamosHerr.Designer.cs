namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReportePrestamosHerr
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
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosPrestamos = new ControlPrestamoHerramientas.DatosPrestamos();
            this.rvp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prestamoTableAdapter = new ControlPrestamoHerramientas.DatosPrestamosTableAdapters.prestamoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "prestamo";
            this.prestamoBindingSource.DataSource = this.datosPrestamos;
            // 
            // datosPrestamos
            // 
            this.datosPrestamos.DataSetName = "DatosPrestamos";
            this.datosPrestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvp
            // 
            this.rvp.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSP";
            reportDataSource1.Value = this.prestamoBindingSource;
            this.rvp.LocalReport.DataSources.Add(reportDataSource1);
            this.rvp.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReportePrestamos.rdlc";
            this.rvp.Location = new System.Drawing.Point(0, 0);
            this.rvp.Name = "rvp";
            this.rvp.Size = new System.Drawing.Size(798, 382);
            this.rvp.TabIndex = 0;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamosHerr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 382);
            this.Controls.Add(this.rvp);
            this.Name = "ReportePrestamosHerr";
            this.Text = "ReportePrestamos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvp;
        private DatosPrestamos datosPrestamos;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private DatosPrestamosTableAdapters.prestamoTableAdapter prestamoTableAdapter;
    }
}