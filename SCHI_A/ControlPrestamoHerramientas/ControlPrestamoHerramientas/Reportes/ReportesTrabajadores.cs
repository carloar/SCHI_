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
    public partial class ReportesTrabajadores : Form
    {
        public static int totregistros = 0;
        public ReportesTrabajadores()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
        }

        private void ReportesTrabajadores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamo_herramientasDataSet.empleados' Puede moverla o quitarla según sea necesario.
            conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
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
            
            
            
            this.empleadosTableAdapter.Fill(this.prestamo_herramientasDataSet.empleados);
            rvtrab.LocalReport.SetParameters(parameters); 
            this.rvtrab.RefreshReport();
            this.rvtrab.SetDisplayMode(DisplayMode.PrintLayout);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
