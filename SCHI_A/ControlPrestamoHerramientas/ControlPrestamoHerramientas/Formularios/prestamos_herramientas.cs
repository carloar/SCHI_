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
    public partial class prestamos_herramientas : Form
    {
        //VARIALBLES

        public static String[] titulos = { "Codigo", "Descripción","Ubicación","Cantidad","Estatus", "Observación", "Fecha" };

        public static String[] camposbd = new string[titulos.Length];
        public static int[] ancho_col = { 80, 150, 100, 80, 80, 150, 100 };
        public static int swtab = 0;

        public static String[] datosform = new string[15];
        public string dato="";
        public int res=0;
        public int res2 = 0;
        public int cc = 0;
        public String nom_tabla_bd="prestamo";
        public String ficha_trab = "";
        public String ficha_t = "";
        public String ficha_buscar = "";
        public String cadena_cont = "";
        public int sel_col = 0;
        public String status = "";
        public String status2 = "";
        public int modif = 0;
        public static Double[] cantidad = new Double[15];
        public int cont_prest = 0;
        public static int swrep = 0;
        //public String campo = "";

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        public prestamos_herramientas()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
            //cb_estatus.SelectedItem = 1;
            cb_estatus.SelectedIndex = 0;
            btn_nvo.Focus();

            for (int j = 0; j <= 100; j++) {

                cb_cant_prest.Items.Add(j);
                cb_cant_dev.Items.Add(j);
            }

            cmbbuscar.SelectedIndex = 0;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            limpiar();
            for (int i = 0; i <= datosform.Length - 1; i++)
            {
                datosform[i] = "";
            }
            swtab = 0;
        }

        public void mensaje(string texto)
        {
            MessageBox.Show("El campo" + " " + texto + " esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string campovacio()
        {
            dato = "";
            if (tbficha.Text == "")
            {
                dato = "Ficha";
                tbficha.Focus();
                return dato;
            }


            if (tbcod_herr.Text == "")
            {
                dato = "Codigo Herramienta";
                tbcod_herr.Focus();
                return dato;
            }

            if (cb_estatus.Text == "")
            {
                dato = "Estatus";
                cb_estatus.Focus();
                return dato;
            }

            if (swtab == 3)
            {
                if (cb_cant_prest.Text == "" || cb_cant_prest.Text=="0")
                {
                    dato = "Cantidad Prestada";
                    cb_cant_prest.Focus();
                    return dato;
                }
            }
            else {
                if (cb_cant_dev.Text == "")
                {
                    dato = "Cantidad Devuelta";
                    cb_cant_dev.Focus();
                    return dato;
                }
            
            
            
            }

            
            return "";
        }

        public void limpiar() {

            for (int i = 0; i <= datosform.Length-1; i++)
            {
               // datosform[i] = "";
            }



            

            
            tbcod_herr.Text = "";
            tipo_herr.Text = "";
            tb_descrip.Text = "";
            cb_estatus.Text = "";
            tb_ubic.Text = "";
            tb_stocka.Text = "0";
            cb_cant_prest.Text = "0";
            cb_cant_dev.Text = "0";
            txtbuscar.Text = "";
            tb_observ.Text = "";
            ficha_trab = "";

        }

        public void habilitar() 
        {
            bool estado;
            estado = true;
            tbficha.Enabled = estado;
            tbficha.BackColor = Color.White;
            //tbcod_herr.Enabled = estado;
            //tbcod_herr.BackColor = Color.White;
            //cb_estatus.Enabled = estado;
            //cb_estatus.BackColor = Color.White;
            cb_cant_prest.Enabled = estado;
            cb_cant_prest.BackColor = Color.White;
            tb_observ.Enabled = estado;
            tb_observ.BackColor = Color.White;
            dtfr.Enabled = estado;
            btnempl.Enabled = estado;
           btn_herr.Enabled = estado;

        }

        public void inhabilitar()
        {
            bool estado;
            estado = false;
            tbficha.Enabled = estado;
            tbficha.BackColor = DefaultBackColor;
            tbcod_herr.Enabled = estado;
            tbcod_herr.BackColor = DefaultBackColor;
            tipo_herr.Enabled = estado;
            tipo_herr.BackColor = DefaultBackColor;
            cb_estatus.Enabled = estado;
            cb_estatus.BackColor = DefaultBackColor;
            cb_cant_prest.Enabled = estado;
            cb_cant_prest.BackColor = DefaultBackColor;
            tb_observ.Enabled = estado;
            tb_observ.BackColor = DefaultBackColor;
            dtfr.Enabled = estado;
            btnempl.Enabled = estado;
            btn_herr.Enabled = estado;
        }

        private void prestamos_herramientas_Load(object sender, EventArgs e)
        {
           // status = "Prestado";
            //ficha_trab = tbficha.Text;
            inhabilitar();
            btn_mod.Enabled = false;
            btn_elim.Enabled = false;
            dgvherr_prest.ColumnCount = titulos.Length;
            dgvherr_prest.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvherr_prest.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Colocar nombres a los encabezados de las columnas
            for (int i = 0; i <= titulos.Length - 1; i++)
            {
                dgvherr_prest.Columns[i].HeaderText = titulos[i];
                dgvherr_prest.Columns[i].Width = ancho_col[i];
            }

            dgvherr_prest.Rows.Clear();//Limpiar registros de la tabla

            limpiar();
            tmora.Text = "Tiempo de Mora: " + acceso.datos_conf[2]+ " dias";
            txtnombre.Text = "";
            txtapellido.Text = "";
            if (swtab == 0) { }
            else
            {
                tbficha.Text = datosform[0];
                txtnombre.Text = datosform[1];
                txtapellido.Text = datosform[2];

                tbcod_herr.Text = datosform[6];
                tipo_herr.Text = datosform[7];
                tb_descrip.Text = datosform[8];
                tb_ubic.Text = datosform[9];
                tb_stocka.Text = datosform[10];
            }
            //status2=cb_estatus.Text;
            btn_nvo.Text = "Nuevo";

            if (swtab == 1 || swtab == 2)
            {
                habilitar();
                btn_herr.Enabled = true;
                btn_nvo.Text = "Agregar";
                ficha_trab = tbficha.Text;
                status = "Prestado";
                cargartabla("Ficha");
            }

            if (swtab == 2)
            {
                cantidad[2] = Convert.ToDouble(tb_stocka.Text);
            }

            
            btn_nvo.Focus();

            if (tb_stocka.Text == "0" && swtab!=0)
            {
                MessageBox.Show("Esa herramienta tiene Stock 0", "Información Herramientas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                cb_cant_prest.Enabled = false;
                cb_cant_prest.BackColor = DefaultBackColor;
                //btn_nvo.Text = "Nuevo";
                limpiar();
                tbcod_herr.Focus();
                
            }
            //cb_cant_dev.Text = "0";
            //cb_cant_prest.Text = "0";

            //mensaje_alarma.Text = swtab.ToString();
        }

       

        

       
        private void button2_Click(object sender, EventArgs e)
        {
            inhabilitar();
            btn_nvo.Text = "Nuevo";
        }

        private void dgvherr_prest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_cant_prest.Enabled = false;
            cb_cant_dev.Enabled = true;
        }

        public void contarreg() {

            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd;
            conexionbd.command.CommandText = cadena_cont;
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();


            res = Convert.ToInt32(conexionbd.command.ExecuteScalar())-1;

            conexionbd.connection.Close();
        
        
        }

        public void cargartabla(string campo) {
            dgvherr_prest.Rows.Clear();//Limpiar registros de la tabla
            cc = 0;
           cont_prest = 0;
            mensaje_alarma.Text = "";
            try
            {
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha_emp = '" + ficha_trab + "'";
                //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();




                switch (campo)
                {

                    /*case "":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " ORDER BY nombre ASC";
                        
                        break;*/

                    case "Ficha":

                        if (res == 0)
                        {
                            conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus,prestamo.observacion,prestamo.fecha,empleados.nombre,empleados.apellido FROM (prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr) INNER JOIN empleados ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "'";
                        }
                        else
                        {
                            conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus,prestamo.observacion,prestamo.fecha,empleados.nombre,empleados.apellido FROM (prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr) INNER JOIN empleados ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "' and estatus='" + status + "'";
                        }
                        break;

                    case "Codigo":
                       
                        conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus, prestamo.observacion, prestamo.fecha FROM prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr WHERE prestamo.ficha_emp = '" + ficha_trab + "' and prestamo.cod_herr like '%" + txtbuscar.Text + "%'";
                        
                        break;

                    case "Descripcion":

                        conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus, prestamo.observacion, prestamo.fecha FROM prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr WHERE ficha_emp = '" + ficha_trab + "' and herramientas.descripcion like '%" + txtbuscar.Text + "%'";
                        
                        break;

                    case "Ubicacion":

                        conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus, prestamo.observacion, prestamo.fecha FROM prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr WHERE ficha_emp = '" + ficha_trab + "' and herramientas.ubicacion like '%" + txtbuscar.Text + "%'";
                       
                        break;

                    case "Estatus":

                        conexionbd.command.CommandText = "SELECT herramientas.cod_herr,herramientas.descripcion,herramientas.ubicacion,prestamo.ficha_emp,prestamo.cantidad,prestamo.estatus, prestamo.observacion, prestamo.fecha FROM prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr WHERE ficha_emp = '" + ficha_trab + "' and prestamo.estatus like '%" + txtbuscar.Text + "%'";
                        break;

                    case "Fecha":

                        //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cargo like '%" + txtbuscar.Text + "%'ORDER BY cargo ASC";
                        
                        break;

                }

                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();


                conexionbd.reader = conexionbd.command.ExecuteReader();


                if (conexionbd.reader.HasRows)
                {

                    while (conexionbd.reader.Read())
                    {
                        /*if (cb_estatus.Text == "")
                        {
                            txtnombre.Text = conexionbd.reader["nombre"].ToString();
                            txtapellido.Text = conexionbd.reader["apellido"].ToString();
                        }
                        else
                        {*/
                        camposbd[0] = conexionbd.reader["cod_herr"].ToString();
                        camposbd[1] = conexionbd.reader["descripcion"].ToString();
                        camposbd[2] = conexionbd.reader["ubicacion"].ToString();
                        camposbd[3] = conexionbd.reader["cantidad"].ToString();
                        camposbd[4] = conexionbd.reader["estatus"].ToString();
                        camposbd[5] = conexionbd.reader["Observacion"].ToString();
                        camposbd[6] = conexionbd.reader.GetDateTime(7).ToShortDateString();
                        if (campo == "Ficha")
                        {
                            txtnombre.Text = conexionbd.reader["nombre"].ToString();
                            txtapellido.Text = conexionbd.reader["apellido"].ToString();
                            prestamos_herramientas.datosform[0] = tbficha.Text;
                            prestamos_herramientas.datosform[1] = txtnombre.Text;
                            prestamos_herramientas.datosform[2] = txtapellido.Text;
                        }
                        //}

                        dgvherr_prest.Rows.Add(camposbd);
                       

                        cc++;

                    }

                    if (cc == 0)
                    {
                        dgvherr_prest.Rows.Clear();//Limpiar registros de la tabla}
                    }
                }
                else {
                	
                	//MessageBox.Show("prueba");
                    conexionbd.connection.Close();

                    //conexionbd.command.CommandText = "SELECT empleados.nombre,empleados.apellido FROM prestamos INNER JOIN empleados ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "'";
                    //conexionbd.command.CommandText = "SELECT empleados.nombre,empleados.apellido FROM empleados INNER JOIN prestamo ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "'";
                    conexionbd.command.CommandText = "SELECT nombre,apellido FROM empleados where ficha_emp = '" + ficha_trab + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();


                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    while (conexionbd.reader.Read())
                    {
                        txtnombre.Text = conexionbd.reader["nombre"].ToString();
                        txtapellido.Text = conexionbd.reader["apellido"].ToString();
                        prestamos_herramientas.datosform[0] = tbficha.Text;
                        prestamos_herramientas.datosform[1] = txtnombre.Text;
                        prestamos_herramientas.datosform[2] = txtapellido.Text;
                    }
                }
                
                    
                



            }

            catch (Exception)
            {
                
                MessageBox.Show("Error de conexion con la base de datos C:\\prestamo_herramientas.accdb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception("Error de conexion", e);
                throw;
            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }

            if (res == 0) {
                registros.Text = "";
            }
            else
            {

                //registros.Text = res.ToString();
                registros.Text = cc.ToString();
                tot_reg.Text = (Convert.ToDouble(res)-cc).ToString();
                //tmora.Text = "Tiempo de Mora: "+acceso.datos_conf[2];

                TimeSpan ts;
                //dgvherr_prest.DataSource = FacturasEEntity.ObtenerFacturasTabla(Año, Serie, NumCliente, False, FechaDesde, FechaHasta, CobradoTotal)
                /*foreach (DataGridViewRow row in dgvherr_prest.Rows)
                {
                    //row.Cells[0].Value.ToString();
                    //celcol = dgvherr_prest[0, celda].Value.ToString();
                   if (row.Cells[0].Value.ToString() == "Prestado")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (row.Cells[0].Value.ToString() == "Devuelto")
                    {
                        row.DefaultCellStyle.BackColor = Color.White;

                    }

                }*/
               String celda = "";
                //int column = 0;
                String celcol = "";
                
                for (int i = 0; i <= cc-1; i++)
                {
                    celcol = dgvherr_prest[4, i].Value.ToString();
                    celda = dgvherr_prest[6, i].Value.ToString();

                    ts = DateTime.Now - Convert.ToDateTime(celda);
                    //MessageBox.Show(celda);
                    //MessageBox.Show(ts.ToString());
                    if (celcol == "Prestado" && ts.Days >= int.Parse(acceso.datos_conf[2]))
                    {
                        for (int j = 0; j <= titulos.Length - 1; j++)
                        {
                            dgvherr_prest.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        }
                        
                        cont_prest++;

                        mensaje_alarma.Text = "El trabajador tiene " + cont_prest.ToString() + " herramientas fuera del tiempo de mora";
                    }
                    else { }
                    

                    if (celcol == "Devuelto")
                    {

                        
                        dgvherr_prest.RowsDefaultCellStyle.BackColor = Color.White;
                        dgvherr_prest.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;


                    }

                }

                
            }
        }

        public void datoduplicado() {

            conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " where cod_herr='" + tbcod_herr.Text + "' and ficha_emp='" + tbficha.Text + "' and estatus='" + "prestado" + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            res= Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();
        
        }

        private void btn_nvo_Click(object sender, EventArgs e)
        {
            status = "Prestado";

            //btn_nvo.Text = "Guardar";
            swtab = 3;

            
            if (btn_nvo.Text == "Agregar")
            {
                status = "Prestado";

                campovacio();
                if (dato != "")
                {
                    mensaje(dato);
                }


                else
                {
                    

                    Clases.consultasSQL.sw[0] = "prestamo";
                    Clases.consultasSQL.sw[1] = "insertar";
                    Clases.consultasSQL.campos_bd[0] = tbficha.Text;
                    Clases.consultasSQL.campos_bd[1] = tbcod_herr.Text;
                    Clases.consultasSQL.camposdouble[0] = int.Parse(cb_cant_prest.Text);
                    //Clases.consultasSQL.campos_bd[3] = cmbdepartamento.Text;
                    Clases.consultasSQL.campos_bd[2] = tb_observ.Text;
                    Clases.consultasSQL.fecha[0] = dtfr.Value;
                    Clases.consultasSQL.campos_bd[3] = cb_estatus.Text;
                    Clases.consultasSQL.campos_bd[4] = Formularios.acceso.datosbd[2];

                    datoduplicado();
                    if (res == 0)//Verifica si no hay duplicados
                    {
                        Clases.consultasSQL.insertar();
                        Clases.consultasSQL.sw[1] = "";
                        MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        Clases.consultasSQL.sw[0] = "herramientas";
                        Clases.consultasSQL.sw[2] = "update";

                        //Actualizar datos en la tabla
                        Clases.consultasSQL.campos_bd[0] = tbcod_herr.Text;
                        Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(datosform[11]);
                        Clases.consultasSQL.campos_bd[1] = tb_descrip.Text;
                        Clases.consultasSQL.campos_bd[2] = tipo_herr.Text;
                        Clases.consultasSQL.campos_bd[3] = datosform[12];
                        Clases.consultasSQL.campos_bd[4] = tb_ubic.Text;
                        Clases.consultasSQL.camposdouble[1] = Convert.ToDouble(datosform[13]);
                        Clases.consultasSQL.camposdouble[2] = Convert.ToDouble(tb_stocka.Text);
                        Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                        Clases.consultasSQL.fecha[0] = dtfr.Value;
                        Clases.consultasSQL.campos_bd[5] = tb_observ.Text;
                        Clases.consultasSQL.campos_bd[7] = tbcod_herr.Text;

                        Clases.consultasSQL.update();
                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[2] = "";
                    }

                    else {

                        MessageBox.Show("Ya usted tiene esa Herramienta prestada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    //Clases.consultasSQL.insertar(txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");


                    cargartabla("Ficha");//Cargar datos en la tabla

                    //MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btn_nvo.Text = "Nuevo";
                    btn_mod.Enabled = true;
                    btn_elim.Enabled = true;
                    limpiar();
                    
                    inhabilitar();
                    btn_herr.Enabled = true;
                }

            }
            else {
                limpiar();
                for (int i = 0; i <= datosform.Length - 1; i++)
                {
                    datosform[i] = "";
                }
                btn_nvo.Text = "Agregar";
                habilitar();
                tbficha.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                tbficha.Focus();
                cmbbuscar.SelectedIndex = 0;
                tot_reg.Text = "";
            
            }

            if (registros.Text == "0")
            {
                mensaje_alarma.Text = "El trabajador no tiene prestamos";
            }
            else
            {
                mensaje_alarma.Text = "";

            }
        
        }

        private void btnempl_Click(object sender, EventArgs e)
        {
            Formularios.empleados form = new Formularios.empleados();
            form.Show();
            swtab = 1;
            this.Close();
        }

        private void btn_herr_Click(object sender, EventArgs e)
        {
            Formularios.herramientas form = new Formularios.herramientas();
            form.Show();

            swtab = 2;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            limpiar();
            tbficha.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            tot_reg.Text = "";
            inhabilitar();
            btn_nvo.Text = "Nuevo";
            cargartabla("Ficha");
            cmbbuscar.SelectedIndex = 0;
            swtab =0;
            
            
        }

        private void cb_cant_prest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sel_col == 1) {
                sel_col = 0;
            }
            else if(btn_nvo.Text=="Agregar" || btn_mod.Text=="Guardar")

            {
                

               if (Convert.ToDouble(cb_cant_prest.Text)==(cantidad[1]))
                {
                    tb_stocka.Text = (cantidad[2]).ToString();
                }

               else if (Convert.ToDouble(cb_cant_prest.Text) > (cantidad[1]))
                {
                    //cantidad[2] = cantidad[2] + cantidad[0];
                    tb_stocka.Text = (cantidad[2] - (Convert.ToDouble(cb_cant_prest.Text)-cantidad[1])).ToString();
                }
                /*
               else if (Convert.ToDouble(cb_cant_prest.Text) < (cantidad[1]))
               {
                   //cantidad[2] = cantidad[2] + cantidad[0];
                   tb_stocka.Text = (cantidad[2] + (cantidad[1]-Convert.ToDouble(cb_cant_prest.Text))).ToString();
               }*/



               else if (cantidad[2] < 0)
                {
                    MessageBox.Show("usted no puede prestar mas del status actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else
                //{
                   // cantidad[2] = cantidad[2] + cantidad[0];
                    //tb_stocka.Text = cantidad[2].ToString();
                //}
            }



            if (cb_cant_prest.Text == "0")
            {
                cb_estatus.Text = "Devuelto";

            }
            else { cb_estatus.Text = "Prestado"; }
            }

        private void cb_cant_dev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modif == 1)


            {

                cantidad[0] = Convert.ToDouble(cb_cant_dev.Text);
                //cantidad[1] = Convert.ToDouble(cb_cant_prest.Text);
               // cantidad[2] = Convert.ToDouble(tb_stocka.Text);

                if (cantidad[0] <= cantidad[1])
                {
                   
                    cb_cant_prest.Text = (cantidad[1] - cantidad[0]).ToString();
                    tb_stocka.Text = (cantidad[2] + cantidad[0]).ToString();
                }
                else
                {
                    MessageBox.Show("Usted no puede devolver mas de lo prestado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            
            
            }
            //modif = 0;
            }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            status = "prestado";
            

            if (txtbuscar.Text == "")
            {
                ficha_trab = tbficha.Text;
                cargartabla("Ficha");
            }
            else if (cmbbuscar.Text=="Ficha")
            {
                ficha_trab = txtbuscar.Text;
                cargartabla("Ficha");
            }
            else  {
                ficha_trab = tbficha.Text;
                cargartabla(cmbbuscar.Text);
            }

            if (registros.Text == "0")
            {
                mensaje_alarma.Text = "El trabajador no tiene prestamos";
            }
            else {
                //mensaje_alarma.Text = "";
            
            }

        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbuscar.SelectedIndex == 1)
            {
                limpiar();
                tbficha.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                inhabilitar();
                btn_nvo.Text = "Nuevo";
                cargartabla("Ficha");
                txtbuscar.Focus();
            }

            if (cmbbuscar.SelectedIndex == 2 || cmbbuscar.SelectedIndex == 3 || cmbbuscar.SelectedIndex == 4 || cmbbuscar.SelectedIndex == 5 || cmbbuscar.SelectedIndex == 6)
            {
                limpiar();
                ficha_trab = tbficha.Text;
                tbficha.Enabled = true;
                tbficha.BackColor = Color.White;
                txtbuscar.Text = "";
                //txtnombre.Text = "";
                //txtapellido.Text = "";
                tbficha.Focus();

            }

            
        }

        private void tbficha_TextChanged(object sender, EventArgs e)
        {
            status = "Prestado";
            ficha_trab = tbficha.Text;
            cargartabla("Ficha");
            //prestamos_herramientas.datosform[1] = txtnombre.Text;
            //prestamos_herramientas.datosform[2] = txtapellido.Text;
            if (registros.Text == "0")
            {
                mensaje_alarma.Text = "El trabajador no tiene prestamos";
            }
            else
            {
                //mensaje_alarma.Text = "";

            }
            status = "";
            if (tbficha.Text == "")
            {
                limpiar();
                txtnombre.Text = "";
                txtapellido.Text = "";

            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                /*ficha_trab = tbficha.Text;
                cargartabla("Codigo");
                label7.Text = txtbuscar.Text+ficha_trab; */


            }
        }

        private void tbficha_KeyPress(object sender, KeyPressEventArgs e)
        {

        	if (e.KeyChar == 13 || e.KeyChar ==Convert.ToChar(Keys.Enter))
            {
                if (cmbbuscar.Text == "Codigo" || cmbbuscar.Text == "Descripcion" || cmbbuscar.Text == "Ubicacion" || cmbbuscar.Text == "Fecha" || cmbbuscar.Text == "Estatus")
                {

                    txtbuscar.Focus();
                }


            }
        }

        

        public void buscar(string codherr)
        {
            //ConnectTo();
            //dgvherr_prest.Rows.Clear();//Limpiar registros de la tabla}
           
            try
            {
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "' and ficha_emp='" + ficha_trab + "' AND estatus='" + status + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();
                
                //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "' AND ficha_emp='" + txtbuscar.Text + "'";
                conexionbd.command.CommandText = "SELECT herramientas.descripcion,herramientas.id_herr,herramientas.marca,herramientas.tipo_herr,herramientas.ubicacion,herramientas.stock_actual,herramientas.stock_ini,prestamo.cantidad,prestamo.estatus,prestamo.observacion,prestamo.fecha, prestamo.id_prestamo FROM prestamo INNER JOIN herramientas ON prestamo.cod_herr=herramientas.cod_herr WHERE (prestamo.cod_herr = '" + codherr + "' AND prestamo.ficha_emp='" + ficha_trab + "' AND prestamo.estatus='" + status + "')";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                conexionbd.reader = conexionbd.command.ExecuteReader();

                //MessageBox.Show("SQL", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //int i = 0;
                if (conexionbd.reader.Read())
                {

                    //MessageBox.Show("prueba" + res.ToString() + Convert.ToDateTime(conexionbd.reader["fecha"].ToString()), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //dtfr.Value = Convert.ToDateTime(conexionbd.reader["fecha"].ToString());
                    tb_descrip.Text = conexionbd.reader["descripcion"].ToString();
                    tipo_herr.Text = conexionbd.reader["tipo_herr"].ToString();
                    tb_ubic.Text = conexionbd.reader["ubicacion"].ToString();
                    tb_stocka.Text = conexionbd.reader["stock_actual"].ToString();
                    cb_estatus.Text = conexionbd.reader["estatus"].ToString();
                    if (status == "Devuelto")
                    {
                        cb_cant_dev.Text = conexionbd.reader["cantidad"].ToString();
                    }
                    else { cb_cant_prest.Text = conexionbd.reader["cantidad"].ToString(); }
                    tb_observ.Text = conexionbd.reader["observacion"].ToString();
                    datosform[11] = conexionbd.reader["id_herr"].ToString();
                    datosform[12] = conexionbd.reader["marca"].ToString();
                    datosform[13] = conexionbd.reader["stock_ini"].ToString();
                    datosform[14] = conexionbd.reader["id_prestamo"].ToString();
                    //tbficha.Text = conexionbd.reader["ficha_emp"].ToString();
                   
                    if (res == 0)
                    {
                        
                    }
                    else
                    {
                        
                        dtfr.Value = Convert.ToDateTime(conexionbd.reader["fecha"].ToString());
                    }

                }


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }
        }

        private void dgvherr_prest_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (btn_nvo.Text == "Nuevo")
            {
                
                status = "";
                int celda = 0;
                int celda2 = 0;
                int column = 0;

                String celcol = "";
                sel_col = 1;
               
                cb_cant_dev.Text = "0";
                cb_cant_prest.Text = "0";
                celda = dgvherr_prest.CurrentRow.Index;
                column = dgvherr_prest.CurrentCell.ColumnIndex;

                celcol = dgvherr_prest[0, celda].Value.ToString();
                status = dgvherr_prest[4, celda2].Value.ToString();
                status2 = status;
                //ficha_trab = tbficha.Text;
                tbcod_herr.Text = celcol;
                if (txtbuscar.Text == "")
                {
                    ficha_trab = tbficha.Text;
                    cargartabla("Ficha");
                }
                else if (cmbbuscar.Text == "Ficha")
                {
                    ficha_trab = txtbuscar.Text;
                    cargartabla("Ficha");
                }
                else
                {
                    ficha_trab = tbficha.Text;
                    cargartabla(cmbbuscar.Text);
                }

                if (registros.Text == "0")
                {
                    mensaje_alarma.Text = "El trabajador no tiene prestamos";
                }
                else
                {
                    //mensaje_alarma.Text = "";

                }
                cb_estatus.Text = "";
                buscar(tbcod_herr.Text);
                cantidad[1] = Convert.ToDouble(cb_cant_prest.Text);
                cantidad[2] = Convert.ToDouble(tb_stocka.Text);
                inhabilitar();
                if (status == "Prestado")
                {
                    btn_mod.Text = "Modificar";
                    btn_nvo.Text = "Nuevo";
                    btn_mod.Enabled = true;

                    if (Formularios.acceso.datosbd[1] == "Administrador")
                    {
                        btn_elim.Enabled = true;
                    }
                    else
                    {
                        btn_elim.Enabled = false;
                    }
                    //btn_elim.Enabled = true;
                }
                else
                {
                    btn_mod.Enabled = false;
                    btn_elim.Enabled = false;
                }

                status = "Prestado";
            }
        
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            modif = 1;

                btn_nvo.Enabled = false;
                btn_elim.Enabled = false;
                //btn_mod.Text = "Guardar";
                tb_observ.Enabled = true;
                tb_observ.BackColor = Color.White;
                cb_cant_dev.Enabled = true;
                cb_cant_dev.BackColor = Color.White;
                cb_cant_prest.Enabled = true;
                cb_cant_prest.BackColor = Color.White;


                if (btn_mod.Text == "Guardar")
                {
                    modif = 0;
                    Clases.consultasSQL.sw[0] = "herramientas";
                    Clases.consultasSQL.sw[2] = "update";


                    Clases.consultasSQL.campos_bd[0] = tbcod_herr.Text;
                    Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(datosform[11]);
                    Clases.consultasSQL.campos_bd[1] = tb_descrip.Text;
                    Clases.consultasSQL.campos_bd[2] = tipo_herr.Text;
                    Clases.consultasSQL.campos_bd[3] = datosform[12];
                    Clases.consultasSQL.campos_bd[4] = tb_ubic.Text;
                    Clases.consultasSQL.camposdouble[1] = Convert.ToDouble(datosform[13]);
                    Clases.consultasSQL.camposdouble[2] = Convert.ToDouble(tb_stocka.Text);
                    Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                    Clases.consultasSQL.fecha[0] = dtfr.Value;
                    Clases.consultasSQL.campos_bd[5] = tb_observ.Text;
                    Clases.consultasSQL.campos_bd[7] = tbcod_herr.Text;

                    Clases.consultasSQL.update();
                    Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[2] = "";

                    Clases.consultasSQL.sw[0] = "prestamo";
                    Clases.consultasSQL.sw[2] = "update";
                    if (txtbuscar.Text == "")
                    {
                        Clases.consultasSQL.campos_bd[0] = tbficha.Text;
                        ficha_trab = tbficha.Text;
                        mensaje_alarma.Text = ficha_trab;
                    }
                    else
                    {
                        Clases.consultasSQL.campos_bd[0] = txtbuscar.Text;
                        ficha_trab = txtbuscar.Text;
                        //txtbuscar.Text = ficha_trab;
                    }
                    Clases.consultasSQL.campos_bd[1] = tbcod_herr.Text;
                    if (cb_estatus.Text == "Devuelto")
                    {
                        Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(cb_cant_dev.Text);
                    }
                    else { Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(cb_cant_prest.Text); }
                    //Clases.consultasSQL.campos_bd[3] = cmbdepartamento.Text;
                    Clases.consultasSQL.campos_bd[2] = tb_observ.Text;
                    if (cb_estatus.Text == "Devuelto")
                    {
                        Clases.consultasSQL.fecha[0] = DateTime.Today;
                    }
                    else { Clases.consultasSQL.fecha[0] = dtfr.Value; }
                    Clases.consultasSQL.campos_bd[3] = cb_estatus.Text;
                    Clases.consultasSQL.campos_bd[5] = status2;
                    Clases.consultasSQL.campos_bd[4] = Formularios.acceso.datosbd[2];
                    
                    Clases.consultasSQL.update();
                    Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[2] = "";
                    
                    //*********************************************************************

                    if (Convert.ToDouble(cb_cant_dev.Text) >=1 && Convert.ToDouble(cb_cant_dev.Text)<cantidad[1] && cb_estatus.Text=="Prestado")
                    {
                        Clases.consultasSQL.sw[0] = "prestamo";
                        Clases.consultasSQL.sw[1] = "insertar";
                        if (txtbuscar.Text == "")
                        {
                            Clases.consultasSQL.campos_bd[0] = tbficha.Text;
                            ficha_trab = tbficha.Text;
                        }
                        else
                        {
                            Clases.consultasSQL.campos_bd[0] = txtbuscar.Text;
                            ficha_trab = txtbuscar.Text;
                            txtbuscar.Text = ficha_trab;
                        }
                        Clases.consultasSQL.campos_bd[1] = tbcod_herr.Text;
                        Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(cb_cant_dev.Text);
                        Clases.consultasSQL.campos_bd[2] = tb_observ.Text;
                        Clases.consultasSQL.fecha[0] = DateTime.Today;
                        Clases.consultasSQL.campos_bd[3] = "Devuelto";
                        Clases.consultasSQL.campos_bd[4] = Formularios.acceso.datosbd[2];

                        Clases.consultasSQL.insertar();
                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[1] = "";
                    }


                    //*********************************************************************
                    //if (Clases.consultasSQL.status_consulta == 1)
                    //{
                    mensaje_alarma.Text = cb_estatus.Text;
                    MessageBox.Show("Prestamo actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clases.consultasSQL.status_consulta = 0;
                    //}
                    /*else
                    {
                        MessageBox.Show("No se pudo modificar la herramienta prestada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }*/
                    ficha_t = txtbuscar.Text;
                    btn_mod.Text = "Modificar";
                    btn_nvo.Enabled = true;
                    btn_elim.Enabled = true;
                    cargartabla("Ficha");
                    limpiar();
                    inhabilitar();
                    txtbuscar.Text = ficha_t;
                    //dgvherr_prest.Rows.Clear();//Limpiar registros de la tabla}
                    //cargartabla("Ficha");
                    //ficha_t = "";


                }
                else { btn_mod.Text = "Guardar"; }
            }

        //Fin



        
        
        void Btn_elimClick(object sender, EventArgs e)
        {
        	
        }

        private void btn_imp_Click(object sender, EventArgs e)
        {
            swrep = 1;
            Formularios.Informes form =new  Formularios.Informes();

            form.Show();
           
            
        }
    }
}
