namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteTrabajadores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetTrabajadores = new ControlPrestamoHerramientas.DataSetTrabajadores();
            this.dataSetTrabajadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrabajadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrabajadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 269);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DST";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 269);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetTrabajadores
            // 
            this.dataSetTrabajadores.DataSetName = "DataSetTrabajadores";
            this.dataSetTrabajadores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetTrabajadoresBindingSource
            // 
            this.dataSetTrabajadoresBindingSource.DataSource = this.dataSetTrabajadores;
            this.dataSetTrabajadoresBindingSource.Position = 0;
            // 
            // ReporteTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 362);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteTrabajadores";
            this.Text = "ReporteTrabajadores";
            this.Load += new System.EventHandler(this.ReporteTrabajadores_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrabajadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTrabajadoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetTrabajadores dataSetTrabajadores;
        private System.Windows.Forms.BindingSource dataSetTrabajadoresBindingSource;
    }
}