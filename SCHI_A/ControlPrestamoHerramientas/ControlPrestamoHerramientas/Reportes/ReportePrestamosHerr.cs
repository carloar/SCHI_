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
    public partial class ReportePrestamosHerr : Form
    {
        public static int totregistros = 0;
        public DateTime fecha_ini;
        public DateTime fecha_fin;
        public string[] fechas=new string[2];
        public ReportePrestamosHerr()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            fecha_ini = Formularios.Informes.fech_ini;
            
            //conexionbd.command.CommandText = "SELECT COUNT(fecha) FROM prestamo where (Format(fecha,'dd/MM/yyyy') between '" + fecha_ini.ToString("dd/MM/yyyy") + "' and '" + Formularios.Informes.fech_fin.ToString("dd/MM/yyyy") + "') and estatus= '" + Formularios.Informes.status2 + "'";
            conexionbd.command.CommandText = "SELECT COUNT(fecha) FROM prestamo where (Format(fecha,'dd/MM/yyyy') >= '" + fecha_ini.ToString("dd/MM/yyyy") + "' or Format(fecha,'dd/MM/yyyy') <= '" + fecha_fin.ToString("dd/MM/yyyy") + "') and estatus= '" + Formularios.Informes.status2 + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM prestamo where estatus= '" + Formularios.Informes.status2 + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM prestamo where Format(fecha,'dd/MM/yyyy') = '" + fecha_ini.ToString("dd/MM/yyyy") + "' ";
            TimeSpan t = Formularios.Informes.fech_fin - Formularios.Informes.fech_ini;
            //MessageBox.Show(t.Days.ToString());

            //if (Formularios.Informes.fech_fin > Formularios.Informes.fech_ini) { MessageBox.Show("correcto"); }
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery(); 

            totregistros = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();            
           
            // TODO: esta línea de código carga datos en la tabla 'prestamo_herramientasDataSet.herramientas' Puede moverla o quitarla según sea necesario.
            
            ReportParameter[] parameters = new ReportParameter[5];
            //ReportParameter fecha = new ReportParameter("fechainicio", Formularios.Informes.fech_ini.ToShortDateString());
            parameters[0] = new ReportParameter("registros", "Registros:" + totregistros.ToString());
            parameters[1] = new ReportParameter("fechainicio", Formularios.Informes.fech_ini.ToShortDateString());
            parameters[2] = new ReportParameter("fechafin", Formularios.Informes.fech_fin.ToShortDateString());
            parameters[3] = new ReportParameter("status", Formularios.Informes.status2.ToString());
            parameters[4] = new ReportParameter("t_mora", Formularios.acceso.datos_conf[2]);
            
            this.prestamoTableAdapter.llenarPrestamos(this.datosPrestamos.prestamo);
           
            rvp.LocalReport.SetParameters(parameters);
            //rvp.LocalReport.SetParameters(fecha);
 
            this.rvp.RefreshReport();

            this.rvp.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
