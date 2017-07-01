/*
 * Creado por SharpDevelop.
 * Usuario: miguel
 * Fecha: 26/02/2016
 * Hora: 09:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
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
	/// <summary>
	/// Description of herramientas_asignacion.
	/// </summary>
	public partial class herramientas_asignacion : Form
	{
		
		public static String[] titulos = { "Codigo", "Descripción", "tipo","Marca", "Ubicación", "Stock Inicial", "Stock Actual", "Observaciones", "Fecha" };
        
        public static String[] camposbd = new string[titulos.Length];
        public static int[] ancho_col = {100,150,100,100,100,100,100,200,150};
        public Double id_herr = 0;
        public string fmt = "0000.##";
        public string nom_tabla_bd = "herramientas_asignacion";
        public String dato = "";
        public int res = 0;
        public int sw = 0;
        public int sw1= 0;
        public string[] ubic=new string[1000];
        public string[] marca = new string[1000];
        public string marcah = "";
        public string ubicacion = "";
        public string ini_cod = "";
        public string cad_sql = "";
        public string codigoherramienta = "";
        public String campobusqueda = "";
        public String textobusqueda = "";
        public int res2 = 0;
        //public string cad_sql = "";
        public int [] swi=new int[10];
        
        
		public herramientas_asignacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cbtipoherr.Items.Add("Manual");
            cbtipoherr.Items.Add("Electrica");
            cbtipoherr.Items.Add("Neumatica");
            cbtipoherr.Items.Add("Hidraulica");
            
            
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_salirClick(object sender, EventArgs e)
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
            if (cbtipoherr.Text == "")
            {
                dato = "Tipo de Herramienta";
                cbtipoherr.Focus();
                return dato;
            }


            if (tb_descrip.Text == "")
            {
                dato = "Descripción de la Herramienta";
                tb_descrip.Focus();
                return dato;
            }

            if (cbubic.Text == "")
            {
                dato = "Ubicación";
                cbubic.Focus();
                return dato;
            }

            if (tb_stocki.Text == "")
            {
                dato = "Stock Inicial";
                tb_stocki.Focus();
                return dato;
            }

            if (tb_stocka.Text == "")
            {
                dato = "Stock actual";
                tb_stocka.Focus();
                return dato;
            }

           
            return "";
        }
        
        
        public void cargartabla(string campo)
        {


            dgv_ha.Rows.Clear();//Limpiar registros de la tabla
            // sw = campo;

            try
            {

                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd;
                //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();
                
                if (res == 0)
                {

                    MessageBox.Show("No hay datos, inserte datos", "Base datos vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{

                
                switch (campo)
                {

                    case "":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " ORDER BY cod_herr ASC";

                        break;


                    case "Codigo":


                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cod_herr like '%" + txtbuscar.Text + "%'ORDER BY cod_herr ASC";
                        
                        break;

                    case "Descripcion":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE descripcion like '%" + txtbuscar.Text + "%'ORDER BY cod_herr ASC";
                        
                        break;

                    case "Ubicacion":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE ubicacion like '%" + txtbuscar.Text + "%'ORDER BY ubicacion ASC";
                        
                        break;

                    case "Tipo":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE tipo_herr like '%" + txtbuscar.Text + "%'ORDER BY tipo_herr ASC";
                        
                        break;

                    case "Marca":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE marca like '%" + txtbuscar.Text + "%'ORDER BY marca ASC";

                        break;
                    case "Fecha":

                        conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE fecha_reg like '%" + txtbuscar.Text + "%'ORDER BY fecha_reg ASC";

                        break;


                }

                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();
                conexionbd.reader = conexionbd.command.ExecuteReader();

                int i = 0;

                for (int k = 1; k <= res; k++)
                {
                    ubic[k] = null;
                    marca[k] = null;
                }

                int h = 1;
                int con = 0;
                cbubic.Items.Clear();
                cb_marca.Items.Clear();

                if (conexionbd.reader.HasRows)
                {

                    while (conexionbd.reader.Read())
                    {

                        marcah = conexionbd.reader["marca"].ToString();
                        ubicacion = conexionbd.reader["ubicacion"].ToString();
                        camposbd[0] = conexionbd.reader["cod_herr"].ToString();
                        camposbd[1] = conexionbd.reader["descripcion"].ToString();
                        camposbd[2] = conexionbd.reader["tipo_herr"].ToString();
                        camposbd[3] = marcah;
                        camposbd[4] = ubicacion;
                        //camposbd[5] = conexionbd.reader.GetDouble(6).ToString();
                        camposbd[5] = conexionbd.reader["stock_ini"].ToString();
                        camposbd[6] = conexionbd.reader["stock_actual"].ToString();
                        //camposbd[6] = conexionbd.reader.GetDouble(7).ToString();
                        camposbd[7] = conexionbd.reader["observaciones"].ToString();
                        //camposbd[8] = conexionbd.reader.GetDateTime(9).ToShortDateString() + "-" + conexionbd.reader.GetDateTime(9).ToShortTimeString();
                        camposbd[8] = conexionbd.reader["fecha_reg"].ToString();

                        dgv_ha.Rows.Add(camposbd);

                        ubic[h] = ubicacion;
                        marca[h] = marcah;
                        con = 0;

                        for (int k = 1; k <= h; k++) { 
                            if (marca[h] == marca[k]) { con = con + 1; } }

                        if (con > 1) { /*No hace nada*/ } 
                        else { cb_marca.Items.Add(marca[h]); }

                        con = 0;
                        for (int k = 1; k <= h; k++) { if (ubic[h] == ubic[k]) { con = con + 1; } }

                        if (con > 1) { /*No hace nada*/}
                        else { cbubic.Items.Add(ubic[h]); }//Fin Cargar datos automaticos en combbox





                        i = i + 1;
                        h = h + 1;

                    }



                }


                registros.Text = res.ToString();
               // label20.Text = camposbd[0];
                
                }
            }

            catch (Exception)
            {


                MessageBox.Show("Error de conexion con la base de datos C:\\prestamo_herramientas.accdb", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }
       


        }
        
        
        
		
		void Herramientas_asignacionLoad(object sender, EventArgs e)
		{
			cmbbuscar.Text = "Codigo";
            cmbbuscar.Items.Add("Descripcion");
            cmbbuscar.Items.Add("Marca");
            cmbbuscar.Items.Add("Ubicacion");
            cmbbuscar.Items.Add("Tipo");
            cmbbuscar.Items.Add("Fecha");
            
            txtbuscar.Text = "";

            cbtipoherr.Focus();
            dgv_ha.ColumnCount = titulos.Length;
            dgv_ha.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ha.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Colocar nombres a los encabezados de las columnas
            for (int i = 0; i <= titulos.Length-1; i++)
            {
                dgv_ha.Columns[i].HeaderText= titulos[i];
                dgv_ha.Columns[i].Width = ancho_col[i];
            }
            //dgvherramientas.Columns[8].Width = 120;

            swi[0] =0;
            cargartabla("");
            inhabilitar();
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
		}
		
		public void consulta_cod(string cod) {
            try
            {
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE cod_herr like '%" + cod + "%'";
                //conexionbd.command.CommandText = "SELECT cod_herr FROM " + nom_tabla_bd;
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();
                if (res > 0)
                {
                    conexionbd.command.CommandText = "SELECT MAX(id_herr) as nroherr FROM " + nom_tabla_bd+" WHERE cod_herr like '%" + cod + "%'";;
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    
                    if (conexionbd.reader.Read())
                    {
                        id_herr = Convert.ToDouble(conexionbd.reader["nroherr"].ToString());
                        //MessageBox.Show(id_herr.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Error de codigo SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            finally 
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }
        
        }
		
		
		
		
		
		
		
		void CbtipoherrSelectedIndexChanged(object sender, EventArgs e)
		{
			if (swi[0] == 1) {

                           
            }
            else
            {
                switch (cbtipoherr.SelectedIndex)
                {

                    case 0:

                        consulta_cod("HAM");

                        id_herr = id_herr + 1;
                        cod_herr.Text = "HAM" + id_herr.ToString(fmt);


                        break;

                    case 1:

                        consulta_cod("HAE");
                        if (res == 0)
                        {
                            id_herr = 1;
                        }
                        else
                        {
                            id_herr = id_herr + 1;
                        }
                        cod_herr.Text = "HAE" + id_herr.ToString(fmt);
                        break;

                    case 2:
                        consulta_cod("HAN");
                        if (res == 0)
                        {
                            id_herr = 1;
                        }
                        else
                        {
                            id_herr = id_herr + 1;
                        }
                        cod_herr.Text = "HAN" + id_herr.ToString(fmt);
                        break;

                    case 3:
                        consulta_cod("HAH");
                        if (res == 0)
                        {
                            id_herr = 1;
                        }
                        else {
                            id_herr = id_herr + 1;
                        }
                        cod_herr.Text = "HAH" + id_herr.ToString(fmt);
                        break;

                }

                swi[0] = 0;
            }
		}

            public void inhabilitar()
        {
            bool status=false;
            cbtipoherr.Enabled = status;
            tb_descrip.Enabled = status;
            cb_marca.Enabled = status;
            cbubic.Enabled = status;
            tb_stocki.Enabled = status;
            tb_stocka.Enabled = status;
            tb_observ.Enabled = status;
        }

        public void habilitar()
        {
            bool status = true;
            cbtipoherr.Enabled = status;
            tb_descrip.Enabled = status;
            cb_marca.Enabled = status;
            cbubic.Enabled = status;
            tb_stocki.Enabled = status;
            tb_stocka.Enabled = status;
            tb_observ.Enabled = status;
        }

        public void limpiar()
        {
            string clear = "";
            cod_herr.Text = clear;
            cbtipoherr.Text = clear;
            tb_descrip.Text = clear;
            cb_marca.Text = clear;
            cbubic.Text = clear;
            tb_stocki.Text = clear;
            tb_stocka.Text = clear;
            tb_observ.Text = clear;
        }

        public void buscar(string codherr)
        {
            //ConnectTo();

            try
            {
                conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();

                conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE cod_herr='" + codherr + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                conexionbd.reader = conexionbd.command.ExecuteReader();

                //int i = 0;
                if (conexionbd.reader.Read())
                {

                    
                    cbtipoherr.Text = conexionbd.reader["tipo_herr"].ToString();
                    id_herr = conexionbd.reader.GetDouble(1);
                    tb_descrip.Text = conexionbd.reader["descripcion"].ToString();
                    cb_marca.Text = conexionbd.reader["marca"].ToString();
                    cbubic.Text = conexionbd.reader["ubicacion"].ToString();                    
                    tb_stocki.Text = conexionbd.reader["stock_ini"].ToString();
                    tb_stocka.Text = conexionbd.reader["stock_actual"].ToString();
                    tb_observ.Text = conexionbd.reader["observaciones"].ToString();
                    
                    if (res == 0)
                    {
                        cb_marca.Text = "";
                        cbubic.Text = "";
                    }
                    else
                    {
                        dtfr.Value = Convert.ToDateTime(conexionbd.reader["fecha_reg"].ToString());
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
        
        
        
        
	 //}
		
		void BtninsertarClick(object sender, EventArgs e)
		{
			txtbuscar.Text = "";
            swi[0] = 0;

            if (btninsertar.Text == "Nuevo")
            {
                limpiar();
                cbtipoherr.Text = "-------Seleccione------";
                habilitar();
                cbtipoherr.Focus();
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
                    Clases.consultasSQL.sw[0] = nom_tabla_bd;
                    Clases.consultasSQL.sw[1] = "insertar";
                    
                    Clases.consultasSQL.campos_bd[0] = cod_herr.Text;
                    Clases.consultasSQL.camposdouble[0] = id_herr;
                    Clases.consultasSQL.campos_bd[1] = tb_descrip.Text;
                    Clases.consultasSQL.campos_bd[2] = cbtipoherr.Text;
                    Clases.consultasSQL.campos_bd[3] = cb_marca.Text;
                    Clases.consultasSQL.campos_bd[4] = cbubic.Text;
                    Clases.consultasSQL.camposdouble[1] = Double.Parse(tb_stocki.Text);
                    Clases.consultasSQL.camposdouble[2] = Double.Parse(tb_stocka.Text);
                    Clases.consultasSQL.fecha[0] = dtfr.Value;
                    Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                    Clases.consultasSQL.campos_bd[5] = tb_observ.Text;
                    
                    
                    
                    //Clases.consultasSQL.insertar_herr(cod_herr.Text, id_herr, tb_descrip.Text, cbubic.Text, cbtipoherr.Text, cb_marca.Text, Double.Parse(tb_stocki.Text), Double.Parse(tb_stocka.Text),dtfr.Value, "miguel",tb_observ.Text);
                    //MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clases.consultasSQL.insertar();
                    Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[1] = "";
                    res2 = res;
                    cargartabla("");//Cargar datos en la tabla
                    if (res > res2)
                    {
                        MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    btninsertar.Text = "Nuevo";
                    btnupdate.Enabled = true;
                    btndelete.Enabled = true;
                    limpiar();
                    cbtipoherr.Text = "-------Seleccione------";
                    inhabilitar();
                }
            }
		}
		
		
		
		
		
		
		
		
		
		
		void Dgv_haCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		int celda = 0;
            int column = 0;
            String celcol = "";
            limpiar();
            celda = dgv_ha.CurrentRow.Index;
            column = dgv_ha.CurrentCell.ColumnIndex;

            celcol = dgv_ha[0, celda].Value.ToString();

            cod_herr.Text = celcol;
            
            swi[0] = 1;
            buscar(cod_herr.Text);
            inhabilitar();

            btnupdate.Text = "Modificar";
            btninsertar.Text = "Nuevo";
            btnupdate.Enabled = true;

            if (Formularios.acceso.datosbd[1] == "Administrador")
            {
                btndelete.Enabled = true;
            }
            else
            {
                btndelete.Enabled = false;
            }
            

            
            
            if (herramientas_asignadas.swtab == 2)
            {

               

                herramientas_asignadas.datos_herr[0] = celcol;
                herramientas_asignadas.datos_herr[1] = cbtipoherr.Text;
                herramientas_asignadas.datos_herr[2] = tb_descrip.Text;
                //*****************************************************
                /*herramientas_asignadas.datos_herr[1] = celcol;
                herramientas_asignadas.datos_herr[1] = cbtipoherr.Text;
                herramientas_asignadas.datos_herr[1] = tb_descrip.Text;*/
                herramientas_asignadas.datos_herr[3] = cbubic.Text;
                herramientas_asignadas.datos_herr[4] = tb_stocka.Text;
                herramientas_asignadas.datos_herr[5] = id_herr.ToString();
                herramientas_asignadas.datos_herr[6] = cb_marca.Text;
                herramientas_asignadas.datos_herr[7] = tb_stocki.Text;
                herramientas_asignadas.datos_herr[8] = tb_observ.Text;
                
                
                
                //*****************************************************
                
                Formularios.herramientas_asignadas form = new Formularios.herramientas_asignadas();
                this.Close();
                form.Show();
            }			
		}
		
		void BtnupdateClick(object sender, EventArgs e)
		{
			txtbuscar.Text = "";
            if (cod_herr.Text == "")
            {
                MessageBox.Show("El campo Codigo esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btnupdate.Text == "Modificar")
                {
                    buscar(cod_herr.Text);
                    //if (b.res == 1)
                    if (res == 1)
                    {
                        btnupdate.Text = "Actualizar";
                        habilitar();
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar un Codigo que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiar();
                        cod_herr.Focus();
                    }
                }


                else
                {
                    Clases.consultasSQL.sw[0] = nom_tabla_bd;
                    Clases.consultasSQL.sw[2] = "update";

                    //Insertar datos en la tabla
                    Clases.consultasSQL.campos_bd[0] = cod_herr.Text;
                    Clases.consultasSQL.camposdouble[0] = id_herr;
                    Clases.consultasSQL.campos_bd[1] = tb_descrip.Text;
                    Clases.consultasSQL.campos_bd[2] = cbtipoherr.Text;
                    Clases.consultasSQL.campos_bd[3] = cb_marca.Text;
                    Clases.consultasSQL.campos_bd[4] = cbubic.Text;
                    Clases.consultasSQL.camposdouble[1] = Convert.ToDouble(tb_stocki.Text);
                    Clases.consultasSQL.camposdouble[2] = Convert.ToDouble(tb_stocka.Text);
                    Clases.consultasSQL.campos_bd[5] = tb_observ.Text;
                    Clases.consultasSQL.fecha[0] = dtfr.Value;
                    Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                    Clases.consultasSQL.campos_bd[7] = cod_herr.Text; 

                    Clases.consultasSQL.update();
                    //Clases.consultasSQL.update(fichatrabajador, txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");

                    cargartabla("");
                    Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[2] = "";
                    MessageBox.Show("Actualizado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    inhabilitar();
                    btnupdate.Text = "Modificar";
                }
            }
		}
		
		void BtndeleteClick(object sender, EventArgs e)
		{
			if (cod_herr.Text == "")
            {
                MessageBox.Show("El campo Codigo esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscar(cod_herr.Text);
                //if (b.res == 1)
                if (res == 1)
                {

                    DialogResult resp = MessageBox.Show("Esta seguro(a) que quiere eliminar la Herramienta " + tb_descrip.Text + " "+"con Codigo:" + " " + cod_herr.Text + " ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resp == DialogResult.Yes)
                    {
                        Clases.consultasSQL.sw[0] = nom_tabla_bd;
                        Clases.consultasSQL.sw[3] = "delete";
                        Clases.consultasSQL.campos_bd[0] = cod_herr.Text;
                        Clases.consultasSQL.delete();

                        cargartabla("");
                        Clases.consultasSQL.sw[0] = "";
                    	Clases.consultasSQL.sw[3] = "";
                        limpiar();

                        MessageBox.Show("Eliminado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        //limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("No puede Eliminar un Codigo que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    cbtipoherr.Focus();
                }

            }
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			limpiar();
            inhabilitar();
            btninsertar.Text = "Nuevo";
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnupdate.Text = "Modificar";
		}
		
		void TxtbuscarTextChanged(object sender, EventArgs e)
		{
			 textobusqueda = "";
            campobusqueda = cmbbuscar.Text;
            textobusqueda = txtbuscar.Text;
            //cargartabla();
            cargartabla(campobusqueda);
		}
		
		void CmbbuscarSelectedIndexChanged(object sender, EventArgs e)
		{
			txtbuscar.Text = "";
            txtbuscar.Focus();
		}

        private void imprimirpersonal_Click(object sender, EventArgs e)
        {
            Reportes.ReporteHerramientasAsignacion form = new Reportes.ReporteHerramientasAsignacion();
            form.Show();
        }
	}
}
