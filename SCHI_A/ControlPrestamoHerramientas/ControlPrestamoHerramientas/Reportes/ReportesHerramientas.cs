using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ControlPrestamoHerramientas.Reportes
{
    public partial class ReportesHerramientas : Form
    {
        public static int totregistros = 0;
        public ReportesHerramientas()
        {

            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
        }

        private void ReportesHerramientas_Load(object sender, EventArgs e)
        {
            conexionbd.command.CommandText = "SELECT COUNT(*) FROM herramientas";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            totregistros = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();
            // TODO: esta línea de código carga datos en la tabla 'prestamo_herramientasDataSet.herramientas' Puede moverla o quitarla según sea necesario.
            ReportParameter[] parameters = new ReportParameter[1];
            //parameters[0] = new ReportParameter("registros", totregistros);
            parameters[0] = new ReportParameter("registros", "Registros:" + totregistros.ToString());
            
            
            
            
            
            this.herramientasTableAdapter.Fill(this.prestamo_herramientasDataSet.herramientas);
            reportViewer1.LocalReport.SetParameters(parameters); 

            this.reportViewer1.RefreshReport();

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
