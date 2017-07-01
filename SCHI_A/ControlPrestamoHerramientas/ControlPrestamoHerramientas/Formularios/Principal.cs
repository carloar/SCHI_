using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlPrestamoHerramientas
{
    public partial class Principal : Form
    {
        public string encriptado = string.Empty;

        public string admin = "";
        public static int  cargar=0;
        public Principal()
        {
            InitializeComponent();
            
        }

        
        

        private void salirsqlgrupos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnempl_Click(object sender, EventArgs e)
        {
           
            Formularios.empleados form = new Formularios.empleados();
            form.Show();
        
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            titulo.Text = Formularios.acceso.datos_conf[0] + " " + Formularios.acceso.datos_conf[1];
            cargar = 1;
            //textBox1.Text=Clases.SeguridadAES.Encriptar(Clases.SeguridadAES.Desencriptar(Formularios.acceso.datosbd[3]));
            //textBox1.Text = Clases.SeguridadAES.Encriptar("marianis");
            timer1.Start();
            //Clases.SeguridadAES.AES();
            //Clases.SeguridadAES.resultado;
            /*Clases.Seguridad.Encriptar(Formularios.acceso.datosbd[3]);
            MessageBox.Show(Clases.Seguridad.result, "Información Herramientas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Clases.Seguridad.DesEncriptar(Clases.Seguridad.result);
            MessageBox.Show(Clases.Seguridad.result, "Desencriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //Set  = Elcontrol.Container;
           // if (Formularios.acceso.datosbd[1] == "Administrador" && Formularios.acceso.datosbd[0]=="6414")
            if (Formularios.acceso.datosbd[1] == "Administrador")
            {
                btnadmin.Enabled = true;
            }
            else
            {
                btnadmin.Enabled = false;
            }

            label2.Text = "Usuario:" + Formularios.acceso.datosbd[4] + " " + Formularios.acceso.datosbd[5] + "  " + "Tipo:" + Formularios.acceso.datosbd[1];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            //TIMER_CLICK
            label1.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();

       
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            
                Formularios.Administrador form = new Formularios.Administrador();
                form.Show();
            
        }

        private void btn_herr_Click(object sender, EventArgs e)
        {
            Formularios.sel_herr form = new Formularios.sel_herr();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.prestamos_herramientas form = new Formularios.prestamos_herramientas();
            form.Show();
        }

        private void herr_asig_Click(object sender, EventArgs e)
        {
            Formularios.herramientas_asignadas form = new Formularios.herramientas_asignadas();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_cambiar_usu_Click(object sender, EventArgs e)
        {
            cargar = 1;
            Formularios.acceso form = new Formularios.acceso();
            form.Show();
            //this.Visible = false;
            this.Close();
        }

       
        
        
        void SalirToolStripMenuItemClick(object sender, EventArgs e)
        {
        	Application.Exit();
        }
        
        void EditarToolStripMenuItem1Click(object sender, EventArgs e)
        {
        	Formularios.empleados form = new Formularios.empleados();
            form.Show();
        }
        
        void EditarToolStripMenuItem2Click(object sender, EventArgs e)
        {
        	Formularios.herramientas form = new Formularios.herramientas();
            form.Show();
        }
        
        void EditarToolStripMenuItem3Click(object sender, EventArgs e)
        {
        	Formularios.herramientas_asignadas form = new Formularios.herramientas_asignadas();
            form.Show();
        }
        
        void EditarToolStripMenuItem4Click(object sender, EventArgs e)
        {
        	Formularios.prestamos_herramientas form = new Formularios.prestamos_herramientas();
            form.Show();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Formularios.Informes form = new Formularios.Informes();
            form.Show();
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReportesTrabajadores form = new Reportes.ReportesTrabajadores();
            form.Show();
        }

        private void herramientasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes.ReportesHerramientas form = new Reportes.ReportesHerramientas();
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reportes.ReporteHerramientasAsignacion form = new Reportes.ReporteHerramientasAsignacion();
            form.Show();
        }

        private void tsmiha_Click(object sender, EventArgs e)
        {
            Reportes.ReporteHerramientasAsignadas form = new Reportes.ReporteHerramientasAsignadas();
            form.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteGeneralPrestamos form = new Reportes.ReporteGeneralPrestamos();
            form.Show();
        }

        private void editarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Formularios.herramientas_asignacion form = new Formularios.herramientas_asignacion();
            form.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca form = new Acerca();
            form.Show();
        }
    }
}
