namespace ControlPrestamoHerramientas.Formularios
{
    partial class configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dt_ps = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_bd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nom_emp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tit_sist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.dt_ps);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_bd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_tm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nom_emp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_tit_sist);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Location = new System.Drawing.Point(13, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 283);
            this.panel1.TabIndex = 0;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(279, 220);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 36);
            this.btncancel.TabIndex = 17;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(158, 221);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 36);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Modificar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dt_ps
            // 
            this.dt_ps.CustomFormat = "";
            this.dt_ps.Enabled = false;
            this.dt_ps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ps.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ps.Location = new System.Drawing.Point(160, 170);
            this.dt_ps.Name = "dt_ps";
            this.dt_ps.Size = new System.Drawing.Size(171, 22);
            this.dt_ps.TabIndex = 10;
            this.dt_ps.ValueChanged += new System.EventHandler(this.dt_ps_ValueChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Registro:";
            // 
            // cb_bd
            // 
            this.cb_bd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_bd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cb_bd.Enabled = false;
            this.cb_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bd.FormattingEnabled = true;
            this.cb_bd.Items.AddRange(new object[] {
            "MySql",
            "Access"});
            this.cb_bd.Location = new System.Drawing.Point(161, 131);
            this.cb_bd.Name = "cb_bd";
            this.cb_bd.Size = new System.Drawing.Size(172, 24);
            this.cb_bd.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Base de Datos:";
            // 
            // cb_tm
            // 
            this.cb_tm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cb_tm.Enabled = false;
            this.cb_tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tm.FormattingEnabled = true;
            this.cb_tm.Location = new System.Drawing.Point(161, 95);
            this.cb_tm.Name = "cb_tm";
            this.cb_tm.Size = new System.Drawing.Size(172, 24);
            this.cb_tm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo de Mora:";
            // 
            // tb_nom_emp
            // 
            this.tb_nom_emp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_nom_emp.Enabled = false;
            this.tb_nom_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom_emp.Location = new System.Drawing.Point(161, 59);
            this.tb_nom_emp.Name = "tb_nom_emp";
            this.tb_nom_emp.Size = new System.Drawing.Size(377, 22);
            this.tb_nom_emp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Empresa:";
            // 
            // tb_tit_sist
            // 
            this.tb_tit_sist.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tb_tit_sist.Enabled = false;
            this.tb_tit_sist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tit_sist.Location = new System.Drawing.Point(160, 24);
            this.tb_tit_sist.Name = "tb_tit_sist";
            this.tb_tit_sist.Size = new System.Drawing.Size(378, 22);
            this.tb_tit_sist.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo del Sistema:";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(461, 222);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 34);
            this.btn_salir.TabIndex = 0;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 318);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros Sistema";
            this.Load += new System.EventHandler(this.configuracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nom_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tit_sist;
        private System.Windows.Forms.ComboBox cb_tm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_bd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_ps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
    }
}