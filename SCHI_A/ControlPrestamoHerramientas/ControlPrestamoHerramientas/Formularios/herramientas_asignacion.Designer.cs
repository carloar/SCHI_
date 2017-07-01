/*
 * Creado por SharpDevelop.
 * Usuario: miguel
 * Fecha: 26/02/2016
 * Hora: 09:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ControlPrestamoHerramientas.Formularios
{
	partial class herramientas_asignacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(herramientas_asignacion));
            this.label18 = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.registros = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ha = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.Insertar = new System.Windows.Forms.GroupBox();
            this.tb_observ = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_stocka = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cod_herr = new System.Windows.Forms.TextBox();
            this.cbtipoherr = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtfr = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_stocki = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbubic = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imprimirpersonal = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.tb_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ha)).BeginInit();
            this.Insertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(202, 303);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Buscar por:";
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Location = new System.Drawing.Point(284, 301);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(138, 24);
            this.cmbbuscar.TabIndex = 27;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.CmbbuscarSelectedIndexChanged);
            // 
            // registros
            // 
            this.registros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registros.Location = new System.Drawing.Point(88, 693);
            this.registros.Name = "registros";
            this.registros.Size = new System.Drawing.Size(40, 20);
            this.registros.TabIndex = 25;
            this.registros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 695);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Registros";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(693, 686);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 35);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ha);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 354);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla Herramientas";
            // 
            // dgv_ha
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_ha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ha.EnableHeadersVisualStyles = false;
            this.dgv_ha.Location = new System.Drawing.Point(21, 27);
            this.dgv_ha.Name = "dgv_ha";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ha.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ha.RowHeadersVisible = false;
            this.dgv_ha.Size = new System.Drawing.Size(710, 306);
            this.dgv_ha.TabIndex = 5;
            this.dgv_ha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_haCellContentClick);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(14, 302);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(159, 22);
            this.txtbuscar.TabIndex = 26;
            this.txtbuscar.TextChanged += new System.EventHandler(this.TxtbuscarTextChanged);
            // 
            // Insertar
            // 
            this.Insertar.Controls.Add(this.tb_observ);
            this.Insertar.Controls.Add(this.label19);
            this.Insertar.Controls.Add(this.label7);
            this.Insertar.Controls.Add(this.tb_stocka);
            this.Insertar.Controls.Add(this.label11);
            this.Insertar.Controls.Add(this.cb_marca);
            this.Insertar.Controls.Add(this.cod_herr);
            this.Insertar.Controls.Add(this.cbtipoherr);
            this.Insertar.Controls.Add(this.label17);
            this.Insertar.Controls.Add(this.pictureBox1);
            this.Insertar.Controls.Add(this.dtfr);
            this.Insertar.Controls.Add(this.label15);
            this.Insertar.Controls.Add(this.label4);
            this.Insertar.Controls.Add(this.tb_stocki);
            this.Insertar.Controls.Add(this.label3);
            this.Insertar.Controls.Add(this.label14);
            this.Insertar.Controls.Add(this.cbubic);
            this.Insertar.Controls.Add(this.label13);
            this.Insertar.Controls.Add(this.label12);
            this.Insertar.Controls.Add(this.label10);
            this.Insertar.Controls.Add(this.label9);
            this.Insertar.Controls.Add(this.imprimirpersonal);
            this.Insertar.Controls.Add(this.btncancel);
            this.Insertar.Controls.Add(this.label8);
            this.Insertar.Controls.Add(this.btndelete);
            this.Insertar.Controls.Add(this.btnupdate);
            this.Insertar.Controls.Add(this.label6);
            this.Insertar.Controls.Add(this.label5);
            this.Insertar.Controls.Add(this.btninsertar);
            this.Insertar.Controls.Add(this.tb_descrip);
            this.Insertar.Controls.Add(this.label2);
            this.Insertar.Controls.Add(this.label1);
            this.Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertar.Location = new System.Drawing.Point(14, 17);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(754, 275);
            this.Insertar.TabIndex = 21;
            this.Insertar.TabStop = false;
            this.Insertar.Text = "Ficha Herramientas";
            // 
            // tb_observ
            // 
            this.tb_observ.Location = new System.Drawing.Point(107, 154);
            this.tb_observ.Name = "tb_observ";
            this.tb_observ.Size = new System.Drawing.Size(446, 22);
            this.tb_observ.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Observaciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(308, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "*";
            // 
            // tb_stocka
            // 
            this.tb_stocka.Location = new System.Drawing.Point(405, 122);
            this.tb_stocka.Name = "tb_stocka";
            this.tb_stocka.Size = new System.Drawing.Size(148, 22);
            this.tb_stocka.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(319, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Stock Actual:";
            // 
            // cb_marca
            // 
            this.cb_marca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(107, 86);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(167, 24);
            this.cb_marca.TabIndex = 33;
            // 
            // cod_herr
            // 
            this.cod_herr.Enabled = false;
            this.cod_herr.Location = new System.Drawing.Point(405, 21);
            this.cod_herr.Name = "cod_herr";
            this.cod_herr.Size = new System.Drawing.Size(148, 22);
            this.cod_herr.TabIndex = 32;
            // 
            // cbtipoherr
            // 
            this.cbtipoherr.FormattingEnabled = true;
            this.cbtipoherr.Location = new System.Drawing.Point(106, 21);
            this.cbtipoherr.Name = "cbtipoherr";
            this.cbtipoherr.Size = new System.Drawing.Size(167, 24);
            this.cbtipoherr.TabIndex = 31;
            this.cbtipoherr.Text = "    -------Seleccione------";
            this.cbtipoherr.SelectedIndexChanged += new System.EventHandler(this.CbtipoherrSelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(44, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(579, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 155);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // dtfr
            // 
            this.dtfr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfr.Location = new System.Drawing.Point(405, 184);
            this.dtfr.Name = "dtfr";
            this.dtfr.Size = new System.Drawing.Size(148, 22);
            this.dtfr.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(353, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "*";
            // 
            // tb_stocki
            // 
            this.tb_stocki.Location = new System.Drawing.Point(107, 122);
            this.tb_stocki.Name = "tb_stocki";
            this.tb_stocki.Size = new System.Drawing.Size(166, 22);
            this.tb_stocki.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Stock Inicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(318, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "*";
            // 
            // cbubic
            // 
            this.cbubic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbubic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbubic.FormattingEnabled = true;
            this.cbubic.Location = new System.Drawing.Point(405, 86);
            this.cbubic.Name = "cbubic";
            this.cbubic.Size = new System.Drawing.Size(148, 24);
            this.cbubic.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(336, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(11, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(53, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(105, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "* Campos obligatorios";
            // 
            // imprimirpersonal
            // 
            this.imprimirpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirpersonal.Image = global::ControlPrestamoHerramientas.Properties.Resources.printer;
            this.imprimirpersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirpersonal.Location = new System.Drawing.Point(582, 225);
            this.imprimirpersonal.Name = "imprimirpersonal";
            this.imprimirpersonal.Size = new System.Drawing.Size(105, 34);
            this.imprimirpersonal.TabIndex = 17;
            this.imprimirpersonal.Text = "&Imprimir";
            this.imprimirpersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirpersonal.UseVisualStyleBackColor = true;
            this.imprimirpersonal.Click += new System.EventHandler(this.imprimirpersonal_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Image = global::ControlPrestamoHerramientas.Properties.Resources.close_24x24_32;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(467, 223);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 36);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Codigo:";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(346, 223);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 36);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Eliminar";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.BtndeleteClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.Image")));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(226, 223);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 36);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Modificar";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.BtnupdateClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ubicación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo:";
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Image = ((System.Drawing.Image)(resources.GetObject("btninsertar.Image")));
            this.btninsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsertar.Location = new System.Drawing.Point(108, 223);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(100, 36);
            this.btninsertar.TabIndex = 4;
            this.btninsertar.Text = "Nuevo";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.BtninsertarClick);
            // 
            // tb_descrip
            // 
            this.tb_descrip.Location = new System.Drawing.Point(107, 55);
            this.tb_descrip.Name = "tb_descrip";
            this.tb_descrip.Size = new System.Drawing.Size(446, 22);
            this.tb_descrip.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // herramientas_asignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 734);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbbuscar);
            this.Controls.Add(this.registros);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.Insertar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "herramientas_asignacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramientas para asignacion";
            this.Load += new System.EventHandler(this.Herramientas_asignacionLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ha)).EndInit();
            this.Insertar.ResumeLayout(false);
            this.Insertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_descrip;
		private System.Windows.Forms.Button btninsertar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnupdate;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button imprimirpersonal;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbubic;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_stocki;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker dtfr;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cbtipoherr;
		private System.Windows.Forms.TextBox cod_herr;
		private System.Windows.Forms.ComboBox cb_marca;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tb_stocka;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tb_observ;
		private System.Windows.Forms.GroupBox Insertar;
		private System.Windows.Forms.TextBox txtbuscar;
		private System.Windows.Forms.DataGridView dgv_ha;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label registros;
		private System.Windows.Forms.ComboBox cmbbuscar;
		private System.Windows.Forms.Label label18;
	}
}
