namespace ControlPrestamoHerramientas.Formularios
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ha = new System.Windows.Forms.Button();
            this.btn_conf = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.btntrab = new System.Windows.Forms.Button();
            this.btn_prest = new System.Windows.Forms.Button();
            this.btn_herr = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ha);
            this.groupBox1.Controls.Add(this.btn_conf);
            this.groupBox1.Controls.Add(this.salir);
            this.groupBox1.Controls.Add(this.btntrab);
            this.groupBox1.Controls.Add(this.btn_prest);
            this.groupBox1.Controls.Add(this.btn_herr);
            this.groupBox1.Controls.Add(this.btn_admin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Administrador";
            // 
            // btn_ha
            // 
            this.btn_ha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ha.Image = global::ControlPrestamoHerramientas.Properties.Resources.worker;
            this.btn_ha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ha.Location = new System.Drawing.Point(18, 142);
            this.btn_ha.Name = "btn_ha";
            this.btn_ha.Size = new System.Drawing.Size(142, 40);
            this.btn_ha.TabIndex = 16;
            this.btn_ha.Text = "Herramientas Asignadas\r\n";
            this.btn_ha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ha.UseVisualStyleBackColor = true;
            this.btn_ha.Click += new System.EventHandler(this.Btn_haClick);
            // 
            // btn_conf
            // 
            this.btn_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conf.Image = global::ControlPrestamoHerramientas.Properties.Resources.configurar;
            this.btn_conf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conf.Location = new System.Drawing.Point(173, 141);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(142, 41);
            this.btn_conf.TabIndex = 15;
            this.btn_conf.Text = "Configuracion";
            this.btn_conf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_conf.UseVisualStyleBackColor = true;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salir.Location = new System.Drawing.Point(220, 196);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(95, 41);
            this.salir.TabIndex = 14;
            this.salir.Text = "&Salir";
            this.salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // btntrab
            // 
            this.btntrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrab.Image = global::ControlPrestamoHerramientas.Properties.Resources.supplier;
            this.btntrab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrab.Location = new System.Drawing.Point(178, 25);
            this.btntrab.Name = "btntrab";
            this.btntrab.Size = new System.Drawing.Size(137, 40);
            this.btntrab.TabIndex = 8;
            this.btntrab.Text = "Trabajadores";
            this.btntrab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntrab.UseVisualStyleBackColor = true;
            this.btntrab.Click += new System.EventHandler(this.btnempl_Click);
            // 
            // btn_prest
            // 
            this.btn_prest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prest.Image = global::ControlPrestamoHerramientas.Properties.Resources.caja_de_herramientas;
            this.btn_prest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prest.Location = new System.Drawing.Point(178, 82);
            this.btn_prest.Name = "btn_prest";
            this.btn_prest.Size = new System.Drawing.Size(137, 41);
            this.btn_prest.TabIndex = 7;
            this.btn_prest.Text = "Prestamos";
            this.btn_prest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_prest.UseVisualStyleBackColor = true;
            this.btn_prest.Click += new System.EventHandler(this.btn_prest_Click);
            // 
            // btn_herr
            // 
            this.btn_herr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_herr.Image = global::ControlPrestamoHerramientas.Properties.Resources.ico_herramientas;
            this.btn_herr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_herr.Location = new System.Drawing.Point(18, 82);
            this.btn_herr.Name = "btn_herr";
            this.btn_herr.Size = new System.Drawing.Size(142, 40);
            this.btn_herr.TabIndex = 6;
            this.btn_herr.Text = "Herramientas";
            this.btn_herr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_herr.UseVisualStyleBackColor = true;
            this.btn_herr.Click += new System.EventHandler(this.btn_herr_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Image = global::ControlPrestamoHerramientas.Properties.Resources.key_512;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.Location = new System.Drawing.Point(18, 25);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(142, 40);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Administradores";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ControlPrestamoHerramientas.Properties.Resources.worker;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(18, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Herramientas Asignación\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 313);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btn_ha;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_prest;
        private System.Windows.Forms.Button btn_herr;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btntrab;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button btn_conf;
        private System.Windows.Forms.Button button1;
    }
}