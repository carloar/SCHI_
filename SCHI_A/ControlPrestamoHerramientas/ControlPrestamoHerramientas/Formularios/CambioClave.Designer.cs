namespace ControlPrestamoHerramientas.Formularios
{
    partial class CambioClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioClave));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_nva_clave2 = new System.Windows.Forms.TextBox();
            this.tb_nva_clave = new System.Windows.Forms.TextBox();
            this.tb_pass_actual = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.etiq_pass = new System.Windows.Forms.Label();
            this.etiq_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_nva_clave2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_nva_clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.tb_pass_actual);
            this.panel1.Controls.Add(this.etiq_pass);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.etiq_user);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 233);
            this.panel1.TabIndex = 2;
            // 
            // tb_nva_clave2
            // 
            this.tb_nva_clave2.Location = new System.Drawing.Point(194, 140);
            this.tb_nva_clave2.Name = "tb_nva_clave2";
            this.tb_nva_clave2.PasswordChar = '*';
            this.tb_nva_clave2.Size = new System.Drawing.Size(172, 20);
            this.tb_nva_clave2.TabIndex = 11;
            // 
            // tb_nva_clave
            // 
            this.tb_nva_clave.Location = new System.Drawing.Point(194, 103);
            this.tb_nva_clave.Name = "tb_nva_clave";
            this.tb_nva_clave.PasswordChar = '*';
            this.tb_nva_clave.Size = new System.Drawing.Size(172, 20);
            this.tb_nva_clave.TabIndex = 9;
            // 
            // tb_pass_actual
            // 
            this.tb_pass_actual.Location = new System.Drawing.Point(194, 67);
            this.tb_pass_actual.Name = "tb_pass_actual";
            this.tb_pass_actual.PasswordChar = '*';
            this.tb_pass_actual.Size = new System.Drawing.Size(172, 20);
            this.tb_pass_actual.TabIndex = 3;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(194, 31);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(172, 20);
            this.tb_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::ControlPrestamoHerramientas.Properties.Resources.change_password;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repetir contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::ControlPrestamoHerramientas.Properties.Resources.change_password;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva contraseña:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_16x16_32;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(290, 180);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(76, 28);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Image = global::ControlPrestamoHerramientas.Properties.Resources.symbol_check;
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_entrar.Location = new System.Drawing.Point(194, 180);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(73, 28);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "&Aceptar";
            this.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // etiq_pass
            // 
            this.etiq_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiq_pass.Image = global::ControlPrestamoHerramientas.Properties.Resources._lock;
            this.etiq_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etiq_pass.Location = new System.Drawing.Point(32, 59);
            this.etiq_pass.Name = "etiq_pass";
            this.etiq_pass.Size = new System.Drawing.Size(161, 34);
            this.etiq_pass.TabIndex = 2;
            this.etiq_pass.Text = "Contraseña anterior:";
            this.etiq_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etiq_user
            // 
            this.etiq_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiq_user.Image = global::ControlPrestamoHerramientas.Properties.Resources.user;
            this.etiq_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etiq_user.Location = new System.Drawing.Point(97, 26);
            this.etiq_user.Name = "etiq_user";
            this.etiq_user.Size = new System.Drawing.Size(91, 29);
            this.etiq_user.TabIndex = 0;
            this.etiq_user.Text = "Usuario:";
            this.etiq_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CambioClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 254);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambioClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Clave";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_nva_clave2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nva_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox tb_pass_actual;
        private System.Windows.Forms.Label etiq_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label etiq_user;
    }
}