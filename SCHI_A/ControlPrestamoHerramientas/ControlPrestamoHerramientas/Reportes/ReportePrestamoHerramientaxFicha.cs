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
    public partial class ReportePrestamoHerramientaxFicha : Form
    {
        public static int totregistros = 0;
        public ReportePrestamoHerramientaxFicha()
        {
            InitializeComponent();
        }

        private void ReportePrestamoHerramientaxFicha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosPrestamos.prestamo' Puede moverla o quitarla según sea necesario.
            conexionbd.command.CommandText = "SELECT COUNT(*) FROM prestamo where ficha_emp='" + Formularios.Informes.ficha_trab[1] + "' and estatus='" + Formularios.Informes.status + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            totregistros = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();

            ReportParameter[] parameters = new ReportParameter[4];
            //ReportParameter fecha = new ReportParameter("fechainicio", Formularios.Informes.fech_ini.ToShortDateString());
            parameters[0] = new ReportParameter("registros", "Registros:" + totregistros.ToString());
            parameters[1] = new ReportParameter("ficha", Formularios.Informes.ficha_trab[1].ToString());
            parameters[2] = new ReportParameter("status", Formularios.Informes.status.ToString());
            parameters[3] = new ReportParameter("t_mora", Formularios.acceso.datos_conf[2]);
           
            this.prestamoTableAdapter.llenarPrestamos(this.datosPrestamos.prestamo);
            rvphxf.LocalReport.SetParameters(parameters);
            
            this.rvphxf.RefreshReport();
            this.rvphxf.SetDisplayMode(DisplayMode.PrintLayout);

        }
    }
}
