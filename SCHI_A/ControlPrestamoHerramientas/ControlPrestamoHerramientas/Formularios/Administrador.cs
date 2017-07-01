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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnempl_Click(object sender, EventArgs e)
        {
            Formularios.empleados form = new Formularios.empleados();
            form.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_herr_Click(object sender, EventArgs e)
        {
            Formularios.herramientas form = new Formularios.herramientas();
            form.Show();
        }

        private void btn_prest_Click(object sender, EventArgs e)
        {
            Formularios.prestamos_herramientas form = new Formularios.prestamos_herramientas();
            form.Show();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Formularios.usuarios form = new Formularios.usuarios();
            form.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            Formularios.configuracion form = new Formularios.configuracion();
            form.Show();
        }
        

        

        
        
        void Btn_haClick(object sender, EventArgs e)
        {
        	Formularios.herramientas_asignadas form=new Formularios.herramientas_asignadas();
        	form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.herramientas_asignacion form = new Formularios.herramientas_asignacion();
            form.Show();
        }
    }
}
