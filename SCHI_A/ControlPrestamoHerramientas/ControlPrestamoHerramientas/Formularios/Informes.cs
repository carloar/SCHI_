using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlPrestamoHerramientas.Formularios
{
    public partial class Informes : Form
    {
        public static DateTime fech_ini;
        public static DateTime fech_fin;
        public static string[] ficha_trab = new string[4];
        public static string status = "";
        public static string status2 = "";
        public Informes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {

            Reportes.ReportesTrabajadores form = new Reportes.ReportesTrabajadores();
            form.Show();
        }
        
        private void btn_herr_Click(object sendeform , EventArgs e)
        {
            Reportes.ReportesHerramientas form = new Reportes.ReportesHerramientas();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            status = cb_phxfe.Text;
            if (fech_ini.ToShortDateString() == "")
            {
                fech_ini= dtpfi.Value;
            }
            else if (fech_fin.ToShortDateString() == "")
            {
                fech_fin = dtpff.Value;
            }
            if (fech_fin < fech_ini) {
                //MessageBox.Show("La fecha final no puede ser menor que la fecha inicial");
                MessageBox.Show("La fecha final no puede ser menor que la fecha inicial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cb_phxfe.Text==""){
                //MessageBox.Show("El campo estatus no puede estar en blanco");
                MessageBox.Show("El campo estatus no puede estar en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
            Reportes.ReportePrestamosHerr form = new Reportes.ReportePrestamosHerr();
            form.Show();}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ficha_trab[0]=tb_ficha.Text;

            if (ficha_trab[0] == "")
            {
                MessageBox.Show("Debe introducir una ficha registrada para realizar la consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Reportes.ReporteHerramientasAsignadasxFicha form = new Reportes.ReporteHerramientasAsignadasxFicha();
                form.Show();
            }
        }

        private void dtpfi_ValueChanged(object sender, EventArgs e)
        {
            fech_ini = dtpfi.Value;
            
        }

        private void dtpff_ValueChanged(object sender, EventArgs e)
        {
            fech_fin= dtpff.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reportes.ReporteGeneralPrestamos form = new Reportes.ReporteGeneralPrestamos();
            form.Show();
        }

        private void btn_hasignacion_Click(object sender, EventArgs e)
        {
            Reportes.ReporteHerramientasAsignacion form = new Reportes.ReporteHerramientasAsignacion();
            form.Show();
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            fech_ini = dtpfi.Value;
            fech_fin = fech_ini;
            status = cb_ep.Text;
            cb_ep.SelectedIndex = 0;
            cb_phxfe.SelectedIndex = 0;
            if (Formularios.prestamos_herramientas.swrep == 1) {

                btn_emp.Enabled = false;
                btn_hasignacion.Enabled = false;
                btn_herr.Enabled = false;
                btn_ph.Enabled = true;
                btn_rhaf.Enabled = false;
                
                gbrhsf.Enabled = false;
               
                Formularios.prestamos_herramientas.swrep = 0;
            }

            if (Formularios.herramientas_asignadas.swrep == 1)
            {
                gbphxf.Enabled = false;
                gbphxft.Enabled = false;

                btn_emp.Enabled = false;
                btn_hasignacion.Enabled = false;
                btn_herr.Enabled = false;
                btn_ph.Enabled = false;
                btn_rhaf.Enabled = true;

                //gbrhsf.Enabled = false;

                Formularios.herramientas_asignadas.swrep = 0;
            }
            
        }

        private void btn_rhaf_Click(object sender, EventArgs e)
        {
            Reportes.ReporteHerramientasAsignadas form = new Reportes.ReporteHerramientasAsignadas();
            form.Show();
        }

        private void btn_phxf_Click(object sender, EventArgs e)
        {
            ficha_trab[1] = tb_ficha_t.Text;
            status = cb_ep.Text;

            if (ficha_trab[1] == "")
            {
                MessageBox.Show("Debe introducir una ficha registrada para realizar la consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (status == "")
            {
                MessageBox.Show("El campo estatus no puede estar en blanco, seleccione Prestado o Devuelto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
            else
            {


                Reportes.ReportePrestamoHerramientaxFicha form = new Reportes.ReportePrestamoHerramientaxFicha();
                form.Show();
            }
        }

        private void cb_ep_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cb_ep.Text;
        }

        private void cb_phxfe_SelectedIndexChanged(object sender, EventArgs e)
        {
            status2 = cb_phxfe.Text;
        }

       
    }
}
