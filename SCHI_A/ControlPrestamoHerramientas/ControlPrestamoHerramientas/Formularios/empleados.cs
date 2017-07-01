using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;
//using System.Windows.Forms.PropertyGridInternal;


namespace ControlPrestamoHerramientas.Formularios
{
    public partial class empleados : Form
    {
        public static string totregistros = "";
        public string[] nom = new string[100];
        public string[] ape = new string[100];
        public string[] fic = new string[100];
        public string[] car = new string[100];
        public string[] are = new string[100];
        public string[] gru = new string[100];
        //DefaultTableModel modelo;
        public String[] titulos = { "Ficha", "Nombre", "Apellido", "Departamento", "Cargo", "Telefono", "Fecha" };
        public String[] camposbd = new string[7];
        public static int res = 0;
        public int i = 0;
        public int h = 0;
        public int con = 0;
        public String fichatrabajador = "";
        public String dato = "";
        public String campobusqueda = "";
        public String textobusqueda = "";
        public String textocargo = "";
        public String textocargocomp = "";
        public string Nombre = "";
        public string Apellido = "";
        public string Ficha = "";
        public string Cargo = "";
        public string Departamento = "";
        public string Telefono = "";
        public string Usuario = "";
        public string nom_tabla_bd = "empleados";
       public string fecha;
       public string sw="";
        public empleados()
        {
            
            InitializeComponent();

            conexionbd.ConnectTo();//Conectar con la base de datos
                       
            dgvempleados.Rows.Clear();//Limpiar registros de la tabla
            cargartabla("");
            inhabilitar();
            cmbbuscar.Text = "Ficha";
            cmbbuscar.Items.Add("Ficha");
            cmbbuscar.Items.Add("Nombre");
            cmbbuscar.Items.Add("Apellido");
            cmbbuscar.Items.Add("Cargo");
            cmbbuscar.Items.Add("Departamento");
            txtbuscar.Text = "";
            txtficha.Focus();
        }

        private void salirsqlgrupos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mensaje(string texto)
        {
            MessageBox.Show("El campo" + " " + texto + " esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string campovacio()
        {
            dato = "";
            if (txtficha.Text == "")
            {
                dato = "Ficha";
                txtficha.Focus();
                return dato;
            }


            if (txtnombre.Text == "")
            {
                dato = "Nombre";
                txtnombre.Focus();
                return dato;
            }

            if (txtapellido.Text == "")
            {
                dato = "Apellido";
                txtapellido.Focus();
                return dato;
            }

            if (tbtelefono.Text == "")
            {
                dato = "Telefono";
                tbtelefono.Focus();
                return dato;
            }

            if (cmbdepartamento.Text == "")
            {
                dato = "Departamento";
                cmbdepartamento.Focus();
                return dato;
            }

            if (cmbcargo.Text == "")
            {
                dato = "Cargo";
                cmbcargo.Focus();
                return dato;
            }

                       

            return "";
        }



        public void cargartabla(string campo)
        {


            //ConnectTo();
            DataTable tabla; 
            tabla = new DataTable();
            //Creo un objeto DataTable que representará una tabla con el nombre Tabla1
            DataTable table = new DataTable("Tabla1");
            
            /*for (int s = 0; s <= 5; s++)
            {
                table.Columns.Add(new DataColumn(titulos[s], typeof(string)));
            }
            table.Columns.Add(new DataColumn(titulos[6], typeof(DateTime)));
            //Ahora creamos filas para que la tabla tenga datos
            DataRow row = table.NewRow();*/
           // DataRow row = dgvempleados.NewRow();

            // Create an unbound DataGridView by declaring a column count.
            dgvempleados.ColumnCount = 7;
            dgvempleados.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvempleados.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            /*dgvempleados.Columns[0].Name = "Recipe";
            dgvempleados.Columns[1].Name = "Category";
            dgvempleados.Columns[2].Name = "Main Ingredients";
            dgvempleados.Columns[3].Name = "Rating";*/
            for (int i = 0; i <= titulos.Length - 1; i++)
            {
                dgvempleados.Columns[i].HeaderText = titulos[i];
            }
            
            dgvempleados.Rows.Clear();//Limpiar registros de la tabla
            sw=campo;
            
                try
                {
                    conexionbd.command.CommandText = "SELECT COUNT(*) FROM "+nom_tabla_bd;
                    //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                    conexionbd.connection.Close();

                    switch (campo)
                    {

                        case "":

                            conexionbd.command.CommandText = "SELECT * FROM "+nom_tabla_bd+" ORDER BY nombre ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                        case "Ficha":

                            conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE ficha_emp like '%" + txtbuscar.Text + "%'ORDER BY nombre ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                        case "Nombre":

                            conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE nombre like '%" + txtbuscar.Text + "%'ORDER BY nombre ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                        case "Apellido":

                            conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE apellido like '%" + txtbuscar.Text + "%'ORDER BY apellido ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                        case "Departamento":

                            conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE departamento like '%" + txtbuscar.Text + "%'ORDER BY departamento ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                        case "Cargo":

                            conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cargo like '%" + txtbuscar.Text + "%'ORDER BY cargo ASC";
                            conexionbd.command.CommandType = CommandType.Text;
                            conexionbd.connection.Open();
                            conexionbd.command.ExecuteNonQuery();
                            break;

                    }


                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    i = 0;

                    for (int k = 1; k <= res; k++)
                    {
                        car[k] = "";
                        are[k] = "";
                    }
                    h = 1;
                    con = 0;
                    cmbcargo.Items.Clear();
                    cmbdepartamento.Items.Clear();

                    if (conexionbd.reader.HasRows)
            {
                    while (conexionbd.reader.Read())
                    {
                        Cargo = conexionbd.reader["cargo"].ToString();
                        Departamento = conexionbd.reader["departamento"].ToString();

                        
                        for(int k=0;k<=6;k++){
                            //titulos[k] = conexionbd.reader.GetString(k);
                            if (k == 6)
                            {
                                camposbd[k] = conexionbd.reader.GetDateTime(k).ToShortDateString();
                            }
                            else { camposbd[k] = conexionbd.reader.GetString(k); }
                        
                        }

                        dgvempleados.Rows.Add(camposbd);
                        
                        car[h] = Cargo;
                        are[h] = Departamento;
                        con = 0;

                        for (int k = 1; k <= h; k++){if (car[h] == car[k]){con = con + 1;}}
                        
                        if (con > 1) { /*No hace nada*/ }else { cmbcargo.Items.Add(car[h]); }
                        
                        con = 0;
                        for (int k = 1; k <= h; k++) {if (are[h] == are[k]) {con = con + 1;} }

                        if (con > 1){/*No hace nada*/}
                        else { cmbdepartamento.Items.Add(are[h]); }//Fin Cargar datos automaticos en combbox
            

                       

                        i = i + 1;
                        h = h + 1;
                    }
                    
                        }



                }

                catch (Exception)
                {
                    //throw;
                    MessageBox.Show("Error de conexion con la base de datos C:\\prestamo_herramientas.accdb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception("Error de conexion", e);
                }
                finally
                {
                    if (conexionbd.connection != null)
                    {
                        conexionbd.connection.Close();
                    }
                }
            


            registros.Text = res.ToString();
            //grupos.totregistros = res.ToString();
            //totregistros = res.ToString();



        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";

            if (btninsertar.Text == "Nuevo")
            {
                limpiar();
                habilitar();
                txtficha.Focus();
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
                    Clases.consultasSQL.sw[0] = "empleados";
                    Clases.consultasSQL.sw[1] = "insertar";
                    //Insertar datos en la tabla
                    Clases.consultasSQL.campos_bd[0] = txtficha.Text;
                    Clases.consultasSQL.campos_bd[1] = txtnombre.Text;
                    Clases.consultasSQL.campos_bd[2] = txtapellido.Text;
                    Clases.consultasSQL.campos_bd[3] = cmbdepartamento.Text;
                    Clases.consultasSQL.campos_bd[4] = cmbcargo.Text;
                    Clases.consultasSQL.campos_bd[5] = tbtelefono.Text;
                    Clases.consultasSQL.fecha[0] = dtempl.Value;
                    Clases.consultasSQL.campos_bd[7] = Formularios.acceso.datosbd[2];

                    Clases.consultasSQL.insertar();
                    //Clases.consultasSQL.insertar(txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");
                    
                    cargartabla("");//Cargar datos en la tabla
                    MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btninsertar.Text = "Nuevo";
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    limpiar();
                    inhabilitar();
                }
            }
        }//Fin Isertar

        public void inhabilitar()
        {
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            cmbcargo.Enabled = false;
            cmbdepartamento.Enabled = false;
            tbtelefono.Enabled = false;
            dtempl.Enabled = false;
        }

        public void habilitar()
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            cmbcargo.Enabled = true;
            cmbdepartamento.Enabled = true;
            tbtelefono.Enabled = true;
            dtempl.Enabled = true;
        }

        public void limpiar()
        {
            txtficha.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            cmbcargo.Text = "";
            cmbdepartamento.Text = "";
            tbtelefono.Text = "";
        }

        public void buscar(string ficha)
        {
            //ConnectTo();

            try
            {
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha_emp='" + ficha + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();

                conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE ficha_emp='" + ficha + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                conexionbd.reader = conexionbd.command.ExecuteReader();

                //int i = 0;
                while (conexionbd.reader.Read())
                {

                    

                    fichatrabajador = conexionbd.reader["ficha_emp"].ToString(); 
                    txtnombre.Text = conexionbd.reader["nombre"].ToString();
                    txtapellido.Text = conexionbd.reader["apellido"].ToString();
                    cmbdepartamento.Text = conexionbd.reader["departamento"].ToString();
                    cmbcargo.Text = conexionbd.reader["cargo"].ToString();
                    tbtelefono.Text = conexionbd.reader["telefono"].ToString();
                    if (res == 0)
                    {
                        cmbdepartamento.Text = "";
                        cmbcargo.Text = "";
                    }
                    else
                    {
                        dtempl.Value = Convert.ToDateTime(conexionbd.reader["fecha_reg"].ToString());
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

            /*fichatrabajador = Ficha;
            txtnombre.Text = Nombre;
            txtapellido.Text = Apellido;
            cmbdepartamento.Text = Departamento;
            cmbcargo.Text = Cargo;            
            tbtelefono.Text = Telefono;
            if (res == 0) {
                cmbdepartamento.Text = "";
                cmbcargo.Text = "";
            }
            else
            {
                dtempl.Value = Convert.ToDateTime(fecha);
            }*/

        }//fin funcion buscar

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            buscar(txtficha.Text);
            if (res == 0)
            {
                limpiar();
                
                MessageBox.Show("No existe el trabajador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtficha.Text = "";
                txtficha.Focus();

            }
        }//Fin

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtapellido.Focus();
                e.Handled = true;
            }

            if (((e.KeyChar) < 65 && e.KeyChar != 8) || e.KeyChar > 122 || (e.KeyChar > 90 && e.KeyChar < 97))
            {

                e.Handled = true;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbtelefono.Focus();
                e.Handled = true;
            }

            if (((e.KeyChar) < 65 && e.KeyChar != 8) || e.KeyChar > 122 || (e.KeyChar > 90 && e.KeyChar < 97))
            {

                e.Handled = true;
            }
        }

        private void txtficha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btninsertar.Text == "Nuevo" )
            {

                if (e.KeyChar == 13)
                {
                    

                    txtbuscar.Text = "";
                    buscar(txtficha.Text);
                    //buscar(fichatrabajador);
                    if (res == 0)
                    {
                        MessageBox.Show("No existe el trabajador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtficha.Text = "";
                        txtficha.Focus();

                    }

                    else {
                        
                            txtnombre.Focus();
                 
                    }


                }

            }

            else
            {

                if (e.KeyChar == 13)
                {
                    txtnombre.Focus();
                    e.Handled = true;
                }
            }

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }

        private void cmbdepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbcargo.Focus();
                e.Handled = true;
            }

            if (((e.KeyChar) < 65 && e.KeyChar != 8) || e.KeyChar > 122 || (e.KeyChar > 90 && e.KeyChar < 97))
            {

                e.Handled = true;
            }
        }

        private void cmbcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtempl.Focus();
                e.Handled = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            if (txtficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnupdate.Text == "Modificar")
                {
                    buscar(txtficha.Text);
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
                        txtficha.Focus();
                    }
                }
                                  

                        else
                        {
                            Clases.consultasSQL.sw[0] = "empleados";
                            Clases.consultasSQL.sw[2] = "update";

                            //Insertar datos en la tabla
                            Clases.consultasSQL.campos_bd[0] = txtficha.Text;
                            Clases.consultasSQL.campos_bd[1] = txtnombre.Text;
                            Clases.consultasSQL.campos_bd[2] = txtapellido.Text;
                            Clases.consultasSQL.campos_bd[3] = cmbdepartamento.Text;
                            Clases.consultasSQL.campos_bd[4] = cmbcargo.Text;
                            Clases.consultasSQL.campos_bd[5] = tbtelefono.Text;
                            Clases.consultasSQL.fecha[0] = dtempl.Value;
                            Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                            Clases.consultasSQL.campos_bd[7] = fichatrabajador;

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
            if (txtficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscar(txtficha.Text);
                //if (b.res == 1)
                if (res == 1)
                {

                    DialogResult resp = MessageBox.Show("Esta seguro(a) que quiere eliminar al trabajador " + txtnombre.Text + " " + txtapellido.Text + " " + "con ficha:" + " " + txtficha.Text + " ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resp == DialogResult.Yes)
                    {
                        Clases.consultasSQL.sw[0] = "empleados";
                        Clases.consultasSQL.sw[3] = "delete";
                        Clases.consultasSQL.campos_bd[0] = txtficha.Text;
                        Clases.consultasSQL.delete();

                        cargartabla("");
                        limpiar();

                        MessageBox.Show("Eliminado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        //limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("No puede Eliminar un trabajador que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    txtficha.Focus();
                }

            }
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = 0;
            int column = 0;
            String celcol = "";
            limpiar();
            celda = dgvempleados.CurrentRow.Index;
            column = dgvempleados.CurrentCell.ColumnIndex;

            celcol = dgvempleados[0, celda].Value.ToString();

            txtficha.Text = celcol;
            fichatrabajador = txtficha.Text;
            buscar(txtficha.Text);
            inhabilitar();

            btnupdate.Text = "Modificar";
            btnupdate.Enabled = true;
            if (Formularios.acceso.datosbd[1] == "Administrador")
            {
                btndelete.Enabled = true;
            }
            else
            {
                btndelete.Enabled = false;
            }
           

            if (prestamos_herramientas.swtab ==1) {

               
                prestamos_herramientas.datosform[0] = celcol;
                prestamos_herramientas.datosform[1] = txtnombre.Text;
                prestamos_herramientas.datosform[2] = txtapellido.Text;
                prestamos_herramientas.datosform[3] = cmbdepartamento.Text;
                prestamos_herramientas.datosform[4] = cmbcargo.Text;
                prestamos_herramientas.datosform[5] = tbtelefono.Text;
                Formularios.prestamos_herramientas form = new Formularios.prestamos_herramientas();
                this.Close();
                form.Show();
            }
            
            
            if (herramientas_asignadas.swtab ==1) {

               
                herramientas_asignadas.datos_emp[0] = celcol;
                herramientas_asignadas.datos_emp[1] = txtnombre.Text;
                herramientas_asignadas.datos_emp[2] = txtapellido.Text;
                //prestamos_herramientas.datosform[3] = cmbdepartamento.Text;
                herramientas_asignadas.datos_emp[3] = cmbcargo.Text;
                herramientas_asignadas.datos_emp[4] = tbtelefono.Text;
                Formularios.herramientas_asignadas form = new Formularios.herramientas_asignadas();
                this.Close();
                form.Show();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            limpiar();
            inhabilitar();
            btninsertar.Text = "Nuevo";
            btnupdate.Enabled = true;
            btndelete.Enabled = true;
            btnupdate.Text = "Modificar";
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            textobusqueda = "";
            campobusqueda = cmbbuscar.Text;
            textobusqueda = txtbuscar.Text;
            //cargartabla();
            cargartabla(campobusqueda);
        }

        private void tbtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                cmbdepartamento.Focus();
                e.Handled = true;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dtempl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtficha.Focus();
                e.Handled = true;
            }
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            txtficha.Focus();
        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            txtbuscar.Focus();
        }

        private void imprimirpersonal_Click(object sender, EventArgs e)
        {
            Reportes.ReportesTrabajadores form = new Reportes.ReportesTrabajadores();
            form.Show();
        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcargo.Focus();
        }

        
        

        
    }
}
