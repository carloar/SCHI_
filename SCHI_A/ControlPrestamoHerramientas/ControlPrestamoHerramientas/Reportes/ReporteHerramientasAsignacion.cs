﻿using System;
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
    public partial class ReporteHerramientasAsignacion : Form
    {
        public static int totregistros = 0;
        public ReporteHerramientasAsignacion()
        {
            InitializeComponent();
        }

        private void ReporteHerramientasAsignacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSHerramientasAsignacion.herramientas_asignacion' Puede moverla o quitarla según sea necesario.
            conexionbd.command.CommandText = "SELECT COUNT(*) FROM herramientas_asignacion";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            totregistros = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();

            ReportParameter[] parameters = new ReportParameter[1];
            //ReportParameter fecha = new ReportParameter("fechainicio", Formularios.Informes.fech_ini.ToShortDateString());
            parameters[0] = new ReportParameter("registros", "Registros:" + totregistros.ToString());
            
            this.herramientas_asignacionTableAdapter.llenarHerramientasAsignacion(this.dSHerramientasAsignacion.herramientas_asignacion);
            rvha.LocalReport.SetParameters(parameters);
            this.rvha.RefreshReport();
            this.rvha.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
