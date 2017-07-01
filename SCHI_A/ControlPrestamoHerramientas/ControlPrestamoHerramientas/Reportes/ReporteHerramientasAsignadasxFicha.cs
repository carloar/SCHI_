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
    public partial class ReporteHerramientasAsignadasxFicha : Form
    {
        public static int totregistros = 0;
        public ReporteHerramientasAsignadasxFicha()
        {
            InitializeComponent();
        }

        private void ReporteHerramientasAsignadasxFicha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSHerramientasAsignadas.herramientas_asignadas' Puede moverla o quitarla según sea necesario.
            conexionbd.command.CommandText = "SELECT COUNT(*) FROM herramientas_asignadas where ficha_emp='"+Formularios.Informes.ficha_trab[0]+"'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            totregistros = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();

            ReportParameter[] parameters = new ReportParameter[2];
            //ReportParameter fecha = new ReportParameter("fechainicio", Formularios.Informes.fech_ini.ToShortDateString());
            parameters[0] = new ReportParameter("registros", "Registros:" + totregistros.ToString());
            
            
            parameters[1] = new ReportParameter("ficha", Formularios.Informes.ficha_trab[0].ToString());
            
            
            
            this.herramientas_asignadasTableAdapter.llenarHerramientasAsignadas(this.dSHerramientasAsignadas.herramientas_asignadas);
            rvhaf.LocalReport.SetParameters(parameters);
            this.rvhaf.RefreshReport();
            
            this.rvhaf.SetDisplayMode(DisplayMode.PrintLayout);

        }
    }
}
