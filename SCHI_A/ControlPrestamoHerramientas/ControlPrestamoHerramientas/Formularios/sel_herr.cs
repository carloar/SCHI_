/*
 * Creado por SharpDevelop.
 * Usuario: miguel
 * Fecha: 26/02/2016
 * Hora: 09:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlPrestamoHerramientas.Formularios
{
	/// <summary>
	/// Description of sel_herr.
	/// </summary>
	public partial class sel_herr : Form
	{
		public sel_herr()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Btn_asigClick(object sender, EventArgs e)
		{
			Formularios.herramientas_asignacion form = new Formularios.herramientas_asignacion();
            form.Show();
            this.Close();           
		}
		
		void Btn_chClick(object sender, EventArgs e)
		{
			
            
            Formularios.herramientas form = new Formularios.herramientas();
            form.Show();
			this.Close();    
		}
	}
}
