/*
 * Creado por SharpDevelop.
 * Usuario: miguel
 * Fecha: 26/02/2016
 * Hora: 09:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ControlPrestamoHerramientas.Formularios
{
	partial class sel_herr
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sel_herr));
            this.btn_ch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.btn_asig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ch
            // 
            this.btn_ch.Image = global::ControlPrestamoHerramientas.Properties.Resources.herramienta;
            this.btn_ch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ch.Location = new System.Drawing.Point(44, 12);
            this.btn_ch.Name = "btn_ch";
            this.btn_ch.Size = new System.Drawing.Size(156, 42);
            this.btn_ch.TabIndex = 0;
            this.btn_ch.Text = "Cuarto herramientas";
            this.btn_ch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ch.UseVisualStyleBackColor = true;
            this.btn_ch.Click += new System.EventHandler(this.Btn_chClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.btn_asig);
            this.panel1.Controls.Add(this.btn_ch);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 158);
            this.panel1.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(107, 108);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(93, 39);
            this.salir.TabIndex = 2;
            this.salir.Text = "&Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.SalirClick);
            // 
            // btn_asig
            // 
            this.btn_asig.Image = global::ControlPrestamoHerramientas.Properties.Resources.caja_de_herramientas;
            this.btn_asig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asig.Location = new System.Drawing.Point(44, 60);
            this.btn_asig.Name = "btn_asig";
            this.btn_asig.Size = new System.Drawing.Size(156, 42);
            this.btn_asig.TabIndex = 1;
            this.btn_asig.Text = "Para asignar";
            this.btn_asig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_asig.UseVisualStyleBackColor = true;
            this.btn_asig.Click += new System.EventHandler(this.Btn_asigClick);
            // 
            // sel_herr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 178);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sel_herr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion Herramientas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btn_asig;
		private System.Windows.Forms.Button salir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_ch;
	}
}
