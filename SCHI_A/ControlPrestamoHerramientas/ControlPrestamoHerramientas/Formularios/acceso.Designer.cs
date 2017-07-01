namespace ControlPrestamoHerramientas.Formularios
{
    partial class acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.etiq_pass = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.etiq_user = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_entrar);
            this.panel1.Controls.Add(this.tb_pass);
            this.panel1.Controls.Add(this.etiq_pass);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.etiq_user);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 179);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(162, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cambiar contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_16x16_32;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(215, 112);
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
            this.btn_entrar.Location = new System.Drawing.Point(119, 112);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(73, 28);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "&Aceptar";
            this.btn_entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(119, 67);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(172, 20);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pass_KeyPress);
            // 
            // etiq_pass
            // 
            this.etiq_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiq_pass.Image = global::ControlPrestamoHerramientas.Properties.Resources.change_password;
            this.etiq_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etiq_pass.Location = new System.Drawing.Point(2, 59);
            this.etiq_pass.Name = "etiq_pass";
            this.etiq_pass.Size = new System.Drawing.Size(116, 34);
            this.etiq_pass.TabIndex = 2;
            this.etiq_pass.Text = "Contraseña:";
            this.etiq_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(119, 31);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(172, 20);
            this.tb_user.TabIndex = 1;
            this.tb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_user_KeyPress);
            // 
            // etiq_user
            // 
            this.etiq_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiq_user.Image = global::ControlPrestamoHerramientas.Properties.Resources.user;
            this.etiq_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.etiq_user.Location = new System.Drawing.Point(22, 26);
            this.etiq_user.Name = "etiq_user";
            this.etiq_user.Size = new System.Drawing.Size(91, 29);
            this.etiq_user.TabIndex = 0;
            this.etiq_user.Text = "Usuario:";
            this.etiq_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 196);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.acceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label etiq_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label etiq_user;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}