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
    public partial class usuarios : Form
    {
        //Declaración de variables
        public String dato = "";
        public static String[] titulos = { "Ficha", "Nombre", "Apellido", "Telefono", "Departamento", "Cargo", "Usuario", "Tipo de Usuario", "Fecha" };

        public static String[] camposbd = new string[titulos.Length];
        public static int[] ancho_col = { 100, 100, 100, 100, 150, 150, 100, 150, 200 };
        public string fmt = "0000.##";
        public string nom_tabla_bd = "usuarios";
        public int cc=0, res = 0;
        public string ficha_trab = "";
        public int lonf = 0;
        public string fichatrabajador="";
        public string ficha_worker = "";
        public String campobusqueda = "";
        public String textobusqueda = "";

        /// <summary>
        /// ///////////////////////////////////
        /// </summary>
        public usuarios()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
        }

        private void btnempl_Click(object sender, EventArgs e)
        {
            Formularios.empleados frm = new Formularios.empleados();
            frm.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            tb_ficha.Text = "";
            tb_nombre.Text = "";
            tb_apellido.Text = "";
            tb_telefono.Text = "";
            tb_depto.Text = "";
            tb_cargo.Text = "";
            cb_tipo_user.Text = "";
            tb_user.Text = "";
            tb_pass.Text = "";
        }

        public void habilitar()
        {
            bool valor = true;
            
            
                       
            cb_tipo_user.Enabled = valor;
            cb_tipo_user.BackColor = Color.White;
            tb_user.Enabled = valor;
            tb_user.BackColor = Color.White;
            tb_pass.Enabled = valor;
            tb_pass.BackColor = Color.White;
            //dt_usu.Enabled = valor;
            
        }

        public void inhabilitar()
        {
            bool valor = false;

            cb_tipo_user.Enabled = valor;
            cb_tipo_user.BackColor = DefaultBackColor;
            tb_pass.Enabled = valor;
            tb_pass.BackColor = DefaultBackColor;
            cb_tipo_user.Enabled = valor;
            cb_tipo_user.BackColor = DefaultBackColor;
            tb_user.Enabled = valor;
            tb_user.BackColor = DefaultBackColor;
            tb_pass.Enabled = valor;
            tb_pass.BackColor = DefaultBackColor;
            dt_usu.Enabled = valor;
        }
        
        public void mensaje(string texto)
        {
            MessageBox.Show("El campo" + " " + texto + " esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string campovacio()
        {
            dato = "";
            if (tb_ficha.Text == "")
            {
                dato = "Ficha de Administrador";
                tb_ficha.Focus();
                return dato;
            }


            if (tb_nombre.Text == "")
            {
                dato = "Nombre del Administrador";
                tb_nombre.Focus();
                return dato;
            }

            if (tb_apellido.Text == "")
            {
                dato = "Apellido del Administrador";
                tb_apellido.Focus();
                return dato;
            }

            if (tb_telefono.Text == "")
            {
                dato = "Telefono del Administrador";
                tb_telefono.Focus();
                return dato;
            }

            if (tb_depto.Text == "")
            {
                dato = "Departamento del Administrador";
                tb_depto.Focus();
                return dato;
            }

            if (tb_cargo.Text == "")
            {
                dato = "Cargo del Administrador";
                tb_cargo.Focus();
                return dato;
            }

            if (cb_tipo_user.Text == "")
            {
                dato = "Tipo de Usuario del Administrador";
                cb_tipo_user.Focus();
                return dato;
            }

            if (tb_pass.Text == "")
            {
                dato = "Clave del Administrador";
                tb_pass.Focus();
                return dato;
            }


            return "";
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            txtbuscar.Text = "";

            tb_ficha.Focus();
            dgv_admin.ColumnCount = titulos.Length;
            dgv_admin.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_admin.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Colocar nombres a los encabezados de las columnas
            for (int i = 0; i <= titulos.Length - 1; i++)
            {
                dgv_admin.Columns[i].HeaderText = titulos[i];
                dgv_admin.Columns[i].Width = ancho_col[i];
            }
            //dgvherramientas.Columns[8].Width = 120;

            //swi[0] = 0;
            cargartabla("");
            //inhabilitar();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            
                limpiar();
                inhabilitar();
            
        }//Fin


        public void cargartabla(string campo)
        {
            dgv_admin.Rows.Clear();//Limpiar registros de la tabla
            cc = 0;
            string sql="";
            try
            {
            	sql="SELECT COUNT(*) FROM " + nom_tabla_bd;
            	
            	//if(Formularios.acceso.datos_conf[3]=="Access"){
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd;
                //conexionbd.command.CommandText = "SELECT COUNT(*) FROM usuarios";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();
            	/*}
            	
            	else if (Formularios.acceso.datos_conf[3]=="MySql"){
                
               
                ConexionMySql.consulta_gen(sql);
                
                 res = Convert.ToInt32(ConexionMySql.myCommand.ExecuteScalar());
                ConexionMySql.cnn.Close();//cerrar base de datos
                }
            	MessageBox.Show(res.ToString());*/
                //MessageBox.Show("No hay registros en la tabla"+res.ToString(), "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == 0)
                {
                    MessageBox.Show("No hay registros en la tabla", "Registro de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    switch (campo)
                    {

                        case "":

                            //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " ORDER BY nombre ASC";
                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) ";
                            break;

                        case "Ficha":
                            //conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE usuarios.ficha_emp like '%" + ficha_trab + "%'";
							conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE empleados.ficha_emp like'%" + ficha_trab + "%'";
                            //conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.ficha_emp,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp)";
                            break;

                        case "Departamento":
                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE empleados.departamento like '%" + txtbuscar.Text + "%'";

                            break;
                            
                       case "Tipo Usuario":
                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE usuarios.tipo_usu like '%" + txtbuscar.Text + "%'";

                            break;

                        case "Nombre":

                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE empleados.nombre like '%" + txtbuscar.Text + "%'";

                            break;

                        case "Apellido":

                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE empleados.apellido like '%" + txtbuscar.Text + "%'";

                            break;
                            
                            case "Cargo":

                            conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE empleados.cargo like '%" + txtbuscar.Text + "%'";

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
                            camposbd[0] = conexionbd.reader["ficha_emp"].ToString();
                            camposbd[1] = conexionbd.reader["nombre"].ToString();
                            camposbd[2] = conexionbd.reader["apellido"].ToString();
                            camposbd[3] = conexionbd.reader["telefono"].ToString();
                            camposbd[4] = conexionbd.reader["departamento"].ToString();
                            camposbd[5] = conexionbd.reader["cargo"].ToString();
                            camposbd[6] = conexionbd.reader["usuario"].ToString();
                            camposbd[7] = conexionbd.reader["tipo_usu"].ToString();
                            //camposbd[7] = conexionbd.reader.GetDateTime(7).ToShortDateString();
                            camposbd[8] = conexionbd.reader["fecha_reg"].ToString();
                            
                            dgv_admin.Rows.Add(camposbd);
                            cc++;

                            if (camposbd[6] == acceso.datosbd[2]) {

                                ficha_worker = camposbd[0];
                            }

                        }

                        if (cc == 0)
                        {
                            dgv_admin.Rows.Clear();//Limpiar registros de la tabla}
                        }
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

            if (res == 0)
            {
                registros.Text = "";
            }
            else
            {
            registros.Text = cc.ToString();             

            }
        }//Fin

        public void buscar(string ficha_t)
        {
            //ConnectTo();

            try
            {
                if (btninsertar.Text == "Nuevo")
                {
                    conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha_emp='" + ficha_t + "'";
                    //conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + "empleados" + " WHERE ficha='" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                    conexionbd.connection.Close();

                    //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "'";
                    conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.departamento,empleados.cargo,empleados.telefono,usuarios.usuario,usuarios.clave,usuarios.tipo_usu,usuarios.fecha_reg FROM (empleados INNER JOIN usuarios ON empleados.ficha_emp=usuarios.ficha_emp) WHERE usuarios.ficha_emp= '" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    //int i = 0;
                    if (conexionbd.reader.Read())
                    {
                        fichatrabajador = conexionbd.reader["ficha_emp"].ToString();
                        tb_ficha.Text = conexionbd.reader["ficha_emp"].ToString();
                        tb_nombre.Text = conexionbd.reader["nombre"].ToString();
                        tb_apellido.Text = conexionbd.reader["apellido"].ToString();
                        tb_telefono.Text = conexionbd.reader["telefono"].ToString();
                        tb_depto.Text = conexionbd.reader["departamento"].ToString();
                        tb_cargo.Text = conexionbd.reader["cargo"].ToString();
                        tb_user.Text = conexionbd.reader["usuario"].ToString();
                        tb_pass.Text = conexionbd.reader["clave"].ToString();
                        tb_pass.Text=Clases.SeguridadAES.Desencriptar(tb_pass.Text);
                        cb_tipo_user.Text = conexionbd.reader["tipo_usu"].ToString();
                        //camposbd[7] = conexionbd.reader.GetDateTime(7).ToShortDateString();
                        //camposbd[7] = conexionbd.reader["fecha_reg"].ToString();
                        if (res == 0)
                        {

                        }
                        else
                        {
                            dt_usu.Value = Convert.ToDateTime(conexionbd.reader["fecha_reg"].ToString());
                        }

                    }


                }//Fin if
                else
                {
                    //conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha='" + ficha_t + "'";
                   conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados WHERE ficha_emp='" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();
                    
                    res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                    conexionbd.connection.Close();
                    //MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "'";
                    conexionbd.command.CommandText = "SELECT nombre, apellido,departamento,cargo,telefono FROM empleados WHERE ficha_emp= '" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();
                    //MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //int i = 0;
                    if (conexionbd.reader.Read())
                    {

                        //tb_ficha.Text = conexionbd.reader["ficha_emp"].ToString();
                        tb_nombre.Text = conexionbd.reader["nombre"].ToString();
                        tb_apellido.Text = conexionbd.reader["apellido"].ToString();
                        tb_telefono.Text = conexionbd.reader["telefono"].ToString();
                        tb_depto.Text = conexionbd.reader["departamento"].ToString();
                        tb_cargo.Text = conexionbd.reader["cargo"].ToString();

                        if (res == 0)
                        {

                        }
                        /*else
                        {
                            dtempl.Value = Convert.ToDateTime(conexionbd.reader["fecha_reg"].ToString());
                        }*/


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


        private void dgv_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           int celda = 0;
            int column = 0;
            String celcol = "";
            //limpiar();
            celda = dgv_admin.CurrentRow.Index;
            column = dgv_admin.CurrentCell.ColumnIndex;

            celcol = dgv_admin[0, celda].Value.ToString();

            tb_ficha.Text = celcol;

            //tb_ficha.Text = ficha_worker;
            
            //swi[0] = 1;
            buscar(tb_ficha.Text);
            //inhabilitar();

            btnupdate.Text = "Modificar";
            btninsertar.Text = "Nuevo";
            btnupdate.Enabled = true;
            btndelete.Enabled = true;

            if (Formularios.acceso.datosbd[1] == "Administrador")
            {
                //habilitar();

            }
            else
            {
                limpiar();
                inhabilitar();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            limpiar();
            inhabilitar();
        }

        public void datoduplicado()
        {

            conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " where ficha_emp='" + tb_ficha.Text + "' or usuario='" + tb_user.Text + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            tb_ficha.Enabled = true;
            tb_ficha.BackColor = Color.White;

            if (btninsertar.Text == "Nuevo")
            {
                limpiar();
                habilitar();
                tb_ficha.Focus();
                btninsertar.Text = "Insertar";
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
            }

            else
            {
                campovacio();
                if (dato != "")
                {
                    mensaje(dato);
                }


                else
                {
                    Clases.consultasSQL.campos_bd[0] = "";
                    Clases.consultasSQL.campos_bd[1] = "";
                    Clases.consultasSQL.campos_bd[2] = "";
                    Clases.consultasSQL.campos_bd[3] = "";

                    Clases.consultasSQL.sw[0] = "usuarios";
                    Clases.consultasSQL.sw[1] = "insertar";                    
                    Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                    Clases.consultasSQL.campos_bd[1] = cb_tipo_user.Text;
                    Clases.consultasSQL.campos_bd[2] = tb_user.Text;
                    //Clases.SeguridadAES.Encriptar(tb_pass.Text);
                    Clases.consultasSQL.campos_bd[3] = Clases.SeguridadAES.Encriptar(tb_pass.Text);
                    Clases.consultasSQL.fecha[0] = dt_usu.Value;
                    //Clases.consultasSQL.campos_bd[7] = Formularios.acceso.datosbd[2];
                    //MessageBox.Show(tb_ficha.Text + cb_tipo_user.Text + tb_user.Text + tb_pass.Text + dt_usu.Value, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    datoduplicado();
                    if (res == 0)
                    {
                        Clases.consultasSQL.insertar();
                        cargartabla("");//Cargar datos en la tabla
                        MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[1] = "";

                       
                    
                    
                    
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe, verifique si el usuario ya esta creado o modifique el campo Usuario", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtbuscar.Focus();
                                                
                    }

                    btninsertar.Text = "Nuevo";
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    limpiar();
                    inhabilitar();
                        
                    
                }
            }
        }

        private void tb_ficha_TextChanged(object sender, EventArgs e)
        {
            //fichatrabajador = tb_ficha.Text;
            if (btnupdate.Text == "Modificar")
            {
                if (tb_ficha.Text == "" || tb_ficha.TextLength < lonf)
                {

                    limpiar();
                    //tb_ficha.Text = fichatrabajador;
                }
                lonf = 0;
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            
            buscar(tb_ficha.Text);
            if (res == 0)
            {
                limpiar();

                MessageBox.Show("No existe el trabajador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_ficha.Text = "";
                tb_ficha.Focus();

            }
        }

        private void tb_ficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtbuscar.Text = "";

                buscar(tb_ficha.Text);
                if (res == 0)
                {
                    limpiar();

                    MessageBox.Show("No existe el trabajador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_ficha.Text = "";
                    tb_ficha.Focus();

                }
                lonf = tb_ficha.TextLength;
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //tb_ficha.Enabled = true;
            //tb_ficha.BackColor = Color.White;
            txtbuscar.Text = "";
            if (tb_ficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnupdate.Text == "Modificar")
                {
                    buscar(tb_ficha.Text);
                    //if (b.res == 1)
                    if (res == 1)
                    {
                        btnupdate.Text = "Guardar";
                        habilitar();
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar un trabajador que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiar();
                        tb_ficha.Focus();
                    }
                }


                else
                {
                    Clases.consultasSQL.sw[0] = "usuarios";
                    Clases.consultasSQL.sw[2] = "update";

                    Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                    Clases.consultasSQL.campos_bd[1] = cb_tipo_user.Text;
                    Clases.consultasSQL.campos_bd[2] = tb_user.Text;
                    //Clases.SeguridadAES.Desencriptar(tb_pass.Text);
                    Clases.consultasSQL.campos_bd[3] = Clases.SeguridadAES.Encriptar(tb_pass.Text);
                    Clases.consultasSQL.fecha[0] = dt_usu.Value;
                    //Clases.consultasSQL.campos_bd[4] = fichatrabajador;

                   // MessageBox.Show(tb_ficha.Text + cb_tipo_user.Text + tb_user.Text + Clases.SeguridadAES.Encriptar(tb_pass.Text) + dt_usu.Value + fichatrabajador, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Clases.consultasSQL.update();
                    //Clases.consultasSQL.update(fichatrabajador, txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");

                    cargartabla("");
                    MessageBox.Show("Actualizado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    inhabilitar();
                    btnupdate.Text = "Modificar";
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tb_ficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscar(tb_ficha.Text);
                //if (b.res == 1)
                if (res == 1)
                {

                    DialogResult resp = MessageBox.Show("Esta seguro(a) que quiere eliminar al trabajador " + tb_nombre.Text + " " + tb_apellido.Text + " " + "con ficha:" + " " + tb_ficha.Text + " ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resp == DialogResult.Yes)
                    {
                        Clases.consultasSQL.sw[0] = "usuarios";
                        Clases.consultasSQL.sw[3] = "delete";
                        Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                        Clases.consultasSQL.delete();

                        cargartabla("");
                        limpiar();
                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[3] = "";
                        MessageBox.Show("Eliminado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        //limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("No puede Eliminar un trabajador que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    tb_ficha.Focus();
                }

            }
        }//Fin
        
        void CmbbuscarSelectedIndexChanged(object sender, EventArgs e)
        {
        	txtbuscar.Text="";
        	txtbuscar.Focus();
        }
        
        void TxtbuscarTextChanged(object sender, EventArgs e)
        {
        	textobusqueda = "";
            campobusqueda = cmbbuscar.Text;
            textobusqueda = txtbuscar.Text;
            
            ficha_trab=txtbuscar.Text;
            
            cargartabla(campobusqueda);
            
            if (txtbuscar.Text==""){
            
            cargartabla("");
            }
        }

        private void tb_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tb_pass.Focus();
            }
        }

        private void reportes_Click(object sender, EventArgs e)
        {
            Reportes.ReporteUsuarios form = new Reportes.ReporteUsuarios();
            form.Show();
        }
    }
}
