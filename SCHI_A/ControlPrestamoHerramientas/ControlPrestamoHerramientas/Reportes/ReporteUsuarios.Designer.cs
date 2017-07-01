namespace ControlPrestamoHerramientas.Reportes
{
    partial class ReporteUsuarios
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
            this.rvusu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetUsuarios = new ControlPrestamoHerramientas.DataSetUsuarios();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new ControlPrestamoHerramientas.DataSetUsuariosTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvusu
            // 
            this.rvusu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSUSU";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.rvusu.LocalReport.DataSources.Add(reportDataSource1);
            this.rvusu.LocalReport.ReportEmbeddedResource = "ControlPrestamoHerramientas.Reportes.ReporteUsuariosSistema.rdlc";
            this.rvusu.Location = new System.Drawing.Point(0, 0);
            this.rvusu.Name = "rvusu";
            this.rvusu.Size = new System.Drawing.Size(717, 402);
            this.rvusu.TabIndex = 0;
            this.rvusu.Load += new System.EventHandler(this.rvusu_Load);
            // 
            // dataSetUsuarios
            // 
            this.dataSetUsuarios.DataSetName = "DataSetUsuarios";
            this.dataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dataSetUsuarios;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 402);
            this.Controls.Add(this.rvusu);
            this.Name = "ReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvusu;
        private DataSetUsuarios dataSetUsuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSetUsuariosTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}