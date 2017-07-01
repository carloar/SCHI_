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
    public partial class herramientas_asignadas : Form
    	
    {
    	public string dato="";
    	public static String[] titulos = { "Codigo Herramienta", "Descripcion", "Tipo Herramienta", "Cantidad", "Observacion","Fecha Registro" };

        public static String[] camposbd = new string[titulos.Length];
        public static String[] campos_lb = new string[3];
        public static int[] ancho_col = { 150, 150, 150, 100, 200, 150};
        public string fmt = "0000.##";
        public string nom_tabla_bd = "herramientas_asignadas";
        public int cc=0, res = 0;
        public string ficha_trab = "";
        public int lonf = 0;
        public string fichatrabajador="";
        public static string[] datos_emp=new string[10];
        public static string[] datos_herr=new string[10];
        public static int sw_de=0;
        public static int swtab=0;
         public String campobusqueda = "";
        public String textobusqueda = "";
        public static int sw_elim=0;
        public static int swrep = 0;
        
        public herramientas_asignadas()
        {
            InitializeComponent();
            for (int j = 1; j <= 10; j++) {

                cb_cant.Items.Add(j);
                
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            for(int i=0;i<=4;i++){
            datos_emp[i]="";	
            datos_herr[i]="";
            }
           		
            	
            	
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
                dato = "Ficha trabajador";
                tb_ficha.Focus();
                return dato;
            }


            if (cod_herr.Text == "")
            {
                dato = "Codigo de la Herramienta";
                cod_herr.Focus();
                return dato;
            }

            if (cb_cant.Text == "")
            {
                dato = "Ubicación";
                cb_cant.Focus();
                return dato;
            }

            
           
            return "";
        }
        
        public void habilitar(){
        bool valor=true;
        
      ;
       
       cb_cant.Enabled=valor;
       cb_cant.BackColor=Color.White;
       tb_observ.Enabled=valor;
       tb_observ.BackColor=Color.White;
        dt_ha.Enabled=valor;
       dt_ha.BackColor=Color.White;
        
        }
        
        public void inhabilitar(){
       bool valor=false;
      
       cb_cant.Enabled=valor;
       cb_cant.BackColor=DefaultBackColor;
       tb_observ.Enabled=valor;
       tb_observ.BackColor=DefaultBackColor;
        dt_ha.Enabled=valor;
       dt_ha.BackColor=DefaultBackColor;
        
        }
        
        public void limpiar(){
        
        string clr="";
        
        tb_ficha.Text=clr;
        tbnombre.Text=clr;
        tbapellido.Text=clr;
        tbcargo.Text=clr;
        tbtelefono.Text=clr;
        cod_herr.Text=clr;
        tb_tipo_herr.Text=clr;
        tb_descrip.Text=clr;
        cb_cant.Text=clr;
        tb_observ.Text=clr;   
        cmbbuscar.Text="";
        
        }
        
        public void cargar_lista(){
        
        //dgvherr_asig.Rows.Clear();//Limpiar registros de la tabla
        cc=0;
        conexionbd.command.CommandText = "SELECT DISTINCT herramientas_asignadas.ficha_emp,empleados.nombre,empleados.apellido FROM herramientas_asignadas INNER JOIN empleados ON herramientas_asignadas.ficha_emp=empleados.ficha_emp ";
        conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();


                conexionbd.reader = conexionbd.command.ExecuteReader();


                if (conexionbd.reader.HasRows)
                {

                    while (conexionbd.reader.Read())
                    {
                        
                    	
                    	//campos_lb[0]=conexionbd.reader["ficha_emp"].ToString();
                            lb_ha.Items.Add(conexionbd.reader["ficha_emp"].ToString()+" "+conexionbd.reader["nombre"].ToString()+" "+conexionbd.reader["apellido"].ToString());
                            
                        cc++;
                    }
                   
                        //cc++;
                        //lb_ha.Items.Add(campos_lb);

                    }

                    if (cc == 0)
                    {
                    	lb_ha.Items.Clear();//Limpiar registros de la tabla}
                    }
                    
                    registros.Text=cc.ToString();
                    
                    conexionbd.connection.Close();
        }
        
        public void cargartabla(string campo) {
            dgvherr_asig.Rows.Clear();//Limpiar registros de la tabla
            cc = 0;
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

                    
                     

                    case "Ficha":

                        
                            conexionbd.command.CommandText = "SELECT herramientas_asignacion.cod_herr,herramientas_asignacion.descripcion,herramientas_asignacion.tipo_herr,herramientas_asignacion.stock_actual,herramientas_asignadas.ficha_emp,herramientas_asignadas.cantidad,herramientas_asignadas.observacion,herramientas_asignadas.fecha_reg,empleados.nombre,empleados.apellido,empleados.cargo,empleados.telefono FROM (herramientas_asignadas INNER JOIN herramientas_asignacion ON herramientas_asignadas.cod_herr=herramientas_asignacion.cod_herr) INNER JOIN empleados ON herramientas_asignadas.ficha_emp=empleados.ficha_emp WHERE herramientas_asignadas.ficha_emp= '" + ficha_trab + "'";
                      
                        break;

                    case "Codigo":
                       
                        conexionbd.command.CommandText = "SELECT herramientas_asignacion.cod_herr,herramientas_asignacion.descripcion,herramientas_asignacion.tipo_herr,herramientas_asignacion.stock_actual,herramientas_asignadas.ficha_emp,herramientas_asignadas.cantidad,herramientas_asignadas.observacion,herramientas_asignadas.fecha_reg,empleados.nombre,empleados.apellido,empleados.cargo,empleados.telefono FROM (herramientas_asignadas INNER JOIN herramientas_asignacion ON herramientas_asignadas.cod_herr=herramientas_asignacion.cod_herr) INNER JOIN empleados ON herramientas_asignadas.ficha_emp=empleados.ficha_emp WHERE herramientas_asignadas.ficha_emp = '" + ficha_trab + "' and herramientas.cod_herr like '%" + txtbuscar.Text + "%' ";
                        
                        break;

                    case "Descripcion":

                        conexionbd.command.CommandText = "SELECT herramientas_asignacion.cod_herr,herramientas_asignacion.descripcion,herramientas_asignacion.tipo_herr,herramientas_asignacion.stock_actual,herramientas_asignadas.ficha_emp,herramientas_asignadas.cantidad,herramientas_asignadas.observacion,herramientas_asignadas.fecha_reg,empleados.nombre,empleados.apellido,empleados.cargo,empleados.telefono FROM (herramientas_asignadas INNER JOIN herramientas_asignacion ON herramientas_asignadas.cod_herr=herramientas_asignacion.cod_herr) INNER JOIN empleados ON herramientas_asignadas.ficha_emp=empleados.ficha_emp WHERE herramientas_asignadas.ficha_emp = '" + ficha_trab + "' and herramientas_asignacion.descripcion like '%" + txtbuscar.Text + "%' ";
                        
                        break;

                    case "Tipo Herramienta":

                        conexionbd.command.CommandText = "SELECT herramientas_asignacion.cod_herr,herramientas_asignacion.descripcion,herramientas_asignacion.tipo_herr,herramientas_asignacion.stock_actual,herramientas_asignadas.ficha_emp,herramientas_asignadas.cantidad,herramientas_asignadas.observacion,herramientas_asignadas.fecha_reg,empleados.nombre,empleados.apellido,empleados.cargo,empleados.telefono FROM (herramientas_asignadas INNER JOIN herramientas_asignacion ON herramientas_asignadas.cod_herr=herramientas.cod_herr) INNER JOIN empleados ON herramientas_asignadas.ficha_emp=empleados.ficha_emp WHERE herramientas_asignadas.ficha_emp = '" + ficha_trab + "' and herramientas_asignacion.tipo_herr like '%" + txtbuscar.Text + "%' ";
                       
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
                        
                        camposbd[0] = conexionbd.reader["cod_herr"].ToString();
                        camposbd[1] = conexionbd.reader["descripcion"].ToString();
                        //camposbd[2] = conexionbd.reader["ubicacion"].ToString();
                        camposbd[2] = conexionbd.reader["tipo_herr"].ToString();
                        camposbd[3] = conexionbd.reader["cantidad"].ToString();
                        camposbd[4] = conexionbd.reader["Observacion"].ToString();
                        camposbd[5] =conexionbd.reader["fecha_reg"].ToString();
                        //camposbd[6] =conexionbd.reader["fecha_reg"].ToString();
                        //camposbd[5] = conexionbd.reader.GetDateTime(7).ToShortDateString();
                        if (campo == "Ficha")
                        {
                        	tb_ficha.Text = conexionbd.reader["ficha_emp"].ToString();
                            tbnombre.Text = conexionbd.reader["nombre"].ToString();
                            tbapellido.Text = conexionbd.reader["apellido"].ToString();
                            tbcargo.Text = conexionbd.reader["cargo"].ToString();
                            tbtelefono.Text = conexionbd.reader["telefono"].ToString();
                            
                            
                            herramientas_asignadas.datos_emp[0] = tb_ficha.Text;
                            herramientas_asignadas.datos_emp[1] = tbnombre.Text;
                            herramientas_asignadas.datos_emp[2] = tbapellido.Text;
                            herramientas_asignadas.datos_emp[3]=tbcargo.Text;
                            herramientas_asignadas.datos_emp[4]=tbtelefono.Text;
                        }
                       

                        dgvherr_asig.Rows.Add(camposbd);
                        cc++;

                    }

                    if (cc == 0)
                    {
                        dgvherr_asig.Rows.Clear();//Limpiar registros de la tabla}
                    }
                }
                /*else {
                    conexionbd.connection.Close();

                    //conexionbd.command.CommandText = "SELECT empleados.nombre,empleados.apellido FROM prestamos INNER JOIN empleados ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "'";
                    conexionbd.command.CommandText = "SELECT empleados.nombre,empleados.apellido FROM empleados INNER JOIN prestamo ON prestamo.ficha_emp=empleados.ficha_emp WHERE prestamo.ficha_emp = '" + ficha_trab + "'";
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
                }*/
                
                    
                



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
                //tot_reg.Text = (Convert.ToDouble(res)-cc).ToString();

            }
        }
        

        public void buscar(string ficha_t)
        {
            //ConnectTo();

            try
            {
                if (btn_nuevo.Text == "Nuevo")
                {
                    conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha_emp='" + ficha_t + "'";
                    //conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + "empleados" + " WHERE ficha='" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                    conexionbd.connection.Close();
                    
                    if(res==0){
                    
                    limpiar();

                    MessageBox.Show("El trabajador no tiene herramientas asignadas, proceda a registrarlo y cargue las herramientas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_ficha.Text = "";
                    tb_ficha.Focus();
                    }
                    
                    else{

                    
                    //conexionbd.command.CommandText = "SELECT * from " + nom_tabla_bd + " where ficha_emp= '" + ficha_t + "'";
                    //conexionbd.command.CommandText = "SELECT nombre, apellido,cargo,telefono FROM empleados WHERE ficha_emp= '" + ficha_t + "'";
                    conexionbd.command.CommandText = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,empleados.cargo,empleados.telefono FROM empleados INNER JOIN herramientas_asignadas ON herramientas_asignadas.ficha_emp=empleados.ficha_emp WHERE herramientas_asignadas.ficha_emp = '" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    //int i = 0;
                    if (conexionbd.reader.Read())
                    {
                        fichatrabajador = conexionbd.reader["ficha_emp"].ToString();
                        tb_ficha.Text = fichatrabajador;
                        tbnombre.Text = conexionbd.reader["nombre"].ToString();
                        tbapellido.Text = conexionbd.reader["apellido"].ToString();
                        tbtelefono.Text = conexionbd.reader["telefono"].ToString();
                        //tb_depto.Text = conexionbd.reader["departamento"].ToString();
                        tbcargo.Text = conexionbd.reader["cargo"].ToString();
                        
                        //sw_de=1;
                        
                                               
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
                    conexionbd.command.CommandText = "SELECT nombre, apellido,cargo,telefono FROM empleados WHERE ficha_emp= '" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();
                    //MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //int i = 0;
                    if (conexionbd.reader.Read())
                    {

                        //tb_ficha.Text = conexionbd.reader["ficha_emp"].ToString();
                        tbnombre.Text = conexionbd.reader["nombre"].ToString();
                        tbapellido.Text = conexionbd.reader["apellido"].ToString();
                        tbtelefono.Text = conexionbd.reader["telefono"].ToString();
                        //tb_depto.Text = conexionbd.reader["departamento"].ToString();
                        tbcargo.Text = conexionbd.reader["cargo"].ToString();

                        if (res == 0) {                       	
                        	
						MessageBox.Show("El trabajador no existe, proceda a registrarlo en empleados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        }
                       
                    }
                    
                    else{
                    if (res == 0) {                       	
                        	
						MessageBox.Show("El trabajador no existe, proceda a registrarlo en empleados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        }}
                }
                
                }//Fin Try
                
                
            
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
        
        void Button2Click(object sender, EventArgs e)
        {
        	limpiar();
        		inhabilitar();
        		btn_nuevo.Text="Nuevo";
        		btn_mod.Enabled=false;
        		btn_elim.Enabled=false;
        		swtab=0;
        		sw_de=0;
        		sw_elim=0;
        		tb_ficha.Enabled=true;
            tb_ficha.BackColor=Color.White;
            tb_ficha.Focus();
        		btn_elim.Text="Eliminar";
        		
        		for(int i=0;i<=9;i++){
        			datos_emp[i]="";
        			datos_herr[i]="";
        			
        		
        		}
        }
        
        
        
        void Button5Click(object sender, EventArgs e)
        {
        	/*habilitar();
        	tb_ficha.Focus();
        	btn_nuevo.Text="Guardar";
        	btn_empl.Enabled=true;
        	btn_herr.Enabled=true;*/
        	
        	txtbuscar.Text = "";
            //swi[0] = 0;
            //swtab=0;

            if (btn_nuevo.Text == "Nuevo")
            {
                limpiar();
                //cbtipoherr.Text = "-------Seleccione------";
                habilitar();
                tb_ficha.Enabled=true;
            	tb_ficha.BackColor=Color.White;
                tb_ficha.Focus();
                btn_nuevo.Text="Guardar";
        		btn_empl.Enabled=true;
        		btn_herr.Enabled=true;
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
                    Clases.consultasSQL.sw[0] = "herramientas_asignadas";
                    Clases.consultasSQL.sw[1] = "insertar";
                    
                    Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;                    
                    Clases.consultasSQL.campos_bd[1] = cod_herr.Text;
                    Clases.consultasSQL.camposdouble[0] = Double.Parse(cb_cant.Text);
                    Clases.consultasSQL.campos_bd[2] = tb_observ.Text;
                    Clases.consultasSQL.campos_bd[3] = Formularios.acceso.datosbd[2];                    
                    Clases.consultasSQL.fecha[0] = dt_ha.Value;
                    
                    
                    
                    
                    //Clases.consultasSQL.insertar_herr(cod_herr.Text, id_herr, tb_descrip.Text, cbubic.Text, cbtipoherr.Text, cb_marca.Text, Double.Parse(tb_stocki.Text), Double.Parse(tb_stocka.Text),dtfr.Value, "miguel",tb_observ.Text);
                    //MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    int res2=0;               
                    
                    contar_reg();
                    res2 = res;
                    
                    
                    datoduplicado();
                    if(res>0){
                    MessageBox.Show("Ya usted tiene esa Herramienta asignada, modifique", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);	
                    }
                    else{
                    Clases.consultasSQL.insertar();
                    
                    Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[1] = "";
                    
                    Clases.consultasSQL.sw[0] = "herramientas_asignacion";
                        Clases.consultasSQL.sw[2] = "update";
                        
                       
                        //Actualizar datos en la tabla
                        Clases.consultasSQL.campos_bd[0] = cod_herr.Text;
                        Clases.consultasSQL.camposdouble[0] = Convert.ToDouble(datos_herr[5]);
                        Clases.consultasSQL.campos_bd[1] = tb_descrip.Text;
                        Clases.consultasSQL.campos_bd[2] = datos_herr[1];
                        Clases.consultasSQL.campos_bd[3] = datos_herr[6];
                        Clases.consultasSQL.campos_bd[4] = datos_herr[3];
                        Clases.consultasSQL.camposdouble[1] = Convert.ToDouble(datos_herr[7]);
                        Clases.consultasSQL.camposdouble[2] = Convert.ToDouble(tb_stocka.Text);
                        Clases.consultasSQL.campos_bd[6] = Formularios.acceso.datosbd[2];
                        Clases.consultasSQL.fecha[0] = dt_ha.Value;
                        Clases.consultasSQL.campos_bd[5] = datos_herr[8];
                        Clases.consultasSQL.campos_bd[7] = cod_herr.Text;

                        Clases.consultasSQL.update();
                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[2] = "";
                    
                    contar_reg();
                    
                    
                    //cargartabla("");//Cargar datos en la tabla
                    if (res > res2)
                    {
                    	
                    MessageBox.Show("Grabado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cod_herr.Text="";
                    tb_tipo_herr.Text="";
                    tb_descrip.Text="";
                    cb_cant.Text="";
                    tb_observ.Text="";
                    dt_ha.Enabled=false;
                                        
                    }
                    }
                    btn_nuevo.Text = "Nuevo";
                    ficha_trab=tb_ficha.Text;
                    cargartabla("Ficha");
                    lb_ha.Items.Clear();
                    cargar_lista();
                    //limpiar();
                    
                    //inhabilitar();
                }
            }
        	
        }
        
        public void contar_reg(){
        
         conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd;
                    //conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + "empleados" + " WHERE ficha='" + ficha_t + "'";
                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                    conexionbd.connection.Close();
        
        }
        
        public void datoduplicado() {

            conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " where cod_herr='" + cod_herr.Text + "' and ficha_emp='" + tb_ficha.Text + "'";
            //conexionbd.command.CommandText = "SELECT COUNT(*) FROM empleados";
            conexionbd.command.CommandType = CommandType.Text;
            conexionbd.connection.Open();
            conexionbd.command.ExecuteNonQuery();

            res= Convert.ToInt32(conexionbd.command.ExecuteScalar());

            conexionbd.connection.Close();
        
        }
        
        void Herramientas_asignadasLoad(object sender, EventArgs e)
        {
        	
        	txtbuscar.Text = "";

            tb_ficha.Focus();
            dgvherr_asig.ColumnCount = titulos.Length;
            dgvherr_asig.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Blue;
            columnHeaderStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvherr_asig.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Colocar nombres a los encabezados de las columnas
            for (int i = 0; i <= titulos.Length - 1; i++)
            {
                dgvherr_asig.Columns[i].HeaderText = titulos[i];
                dgvherr_asig.Columns[i].Width = ancho_col[i];
            }
            
            //cargartabla("");
            //inhabilitar();
            //if (swtab == 0 || sw_de==1) { 
            	if (swtab == 0) { 
            
            btn_mod.Enabled = false;
            btn_elim.Enabled = false;
            
                limpiar();
                inhabilitar();
                lb_ha.Items.Clear();
                cargar_lista();
                //MessageBox.Show("Datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            
                cod_herr.Text="";
            	tb_ficha.Text=datos_emp[0];
            	tbnombre.Text=datos_emp[1];
            	tbapellido.Text=datos_emp[2];
            	tbcargo.Text=datos_emp[3];
            	tbtelefono.Text=datos_emp[4];
            	
            	cod_herr.Text=datos_herr[0];
            	tb_tipo_herr.Text=datos_herr[1];
            	tb_descrip.Text=datos_herr[2];
            	tb_stocka.Text=datos_herr[4];
            	
            	habilitar();
        	tb_ficha.Focus();
        	btn_nuevo.Text="Guardar";
        	btn_empl.Enabled=true;
        	btn_herr.Enabled=true;
        	
        	//btn_nuevo.Text = "Nuevo";
                    ficha_trab=datos_emp[0];
                    cargartabla("Ficha");
                    lb_ha.Items.Clear();
                    cargar_lista();
            
                 }
            /*else{
            btn_mod.Enabled = false;
            btn_elim.Enabled = false;
            
                limpiar();
                inhabilitar();}*/
        	
        }
        
        void TbfichaKeyPress(object sender, KeyPressEventArgs e)
        {
        	if (e.KeyChar == 13)
            {
                txtbuscar.Text = "";

                buscar(tb_ficha.Text);
                
                datos_emp[0]=tb_ficha.Text;
                datos_emp[1]=tbnombre.Text;
                datos_emp[2]=tbapellido.Text;
                datos_emp[3]=tbcargo.Text;
                datos_emp[4]=tbtelefono.Text;
                
                if (res == 0)
                {
                    /*limpiar();

                    MessageBox.Show("El trabajador no tiene herramientas asignadas, proceda a registrarlo y cargue las herramientas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_ficha.Text = "";
                    tb_ficha.Focus();*/
                    cargar_lista();

                }
                else{
                
                btn_elim.Enabled=true;
                btn_elim.Text="Eliminar";
                }
                lonf = tb_ficha.TextLength;
                ficha_trab=tb_ficha.Text;
                lb_ha.Items.Clear();
                cargar_lista();
                cargartabla("Ficha");
                
                
                    
            }
        }
        
        
        
        void TbfichaTextChanged(object sender, EventArgs e)
        {
        	//if (btn_nuevo.Text == "Guardar")
           // {
                if (tb_ficha.Text == "" || tb_ficha.TextLength < lonf)
                {

                	tbnombre.Text="";
                	tbapellido.Text="";
                	tbcargo.Text="";
                	tbtelefono.Text="";
                	dgvherr_asig.Rows.Clear();//Limpiar registros de la tabla
                	registros.Text="";
                	lb_ha.Items.Clear();
                	cargar_lista();
                }
                lonf = 0;
                sw_elim=0;
                limpiar_herr();
            //}
        }
        
        void Btn_emplClick(object sender, EventArgs e)
        {
        	 Formularios.empleados form = new Formularios.empleados();
            form.Show();
            swtab = 1;
            this.Close();
        }
        
        void Btn_herrClick(object sender, EventArgs e)
        {
        	Formularios.herramientas_asignacion form = new Formularios.herramientas_asignacion();
            form.Show();

            swtab = 2;
            this.Close();
        }
        
        public void limpiar_herr(){
        				cod_herr.Text="";
                        tb_tipo_herr.Text="";
                        tb_descrip.Text="";
                        tb_observ.Text="";
                        cb_cant.Text="";
        
        }
        
        public void limpiar_emp(){
        				tb_ficha.Text="";
                        tbnombre.Text="";
                        tbapellido.Text="";
                        tbcargo.Text="";
                        tbtelefono.Text="";
        
        }
        
        void Btn_elimClick(object sender, EventArgs e)
        {
        	if (tb_ficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscar(tb_ficha.Text);
                //if (b.res == 1)
                if (res >= 1)
                {

                	if(sw_elim==1){
                		
                		DialogResult resp = MessageBox.Show("Esta seguro(a) que quiere eliminar la herramienta con codigo " + cod_herr.Text + " "+"del trabajador:" + " " + tbnombre.Text + " ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resp == DialogResult.Yes)
                    {
                        Clases.consultasSQL.sw[0] = nom_tabla_bd;
                        Clases.consultasSQL.sw[3] = "delete";
                        Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                        Clases.consultasSQL.campos_bd[1] = cod_herr.Text;
                       
                        Clases.consultasSQL.delete();

                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[3] = "";
                        //cargartabla("Ficha");
                        lb_ha.Items.Clear();
                        cargar_lista();
                        limpiar_herr();
                        cargartabla("Ficha");
                        //limpiar();

                        MessageBox.Show("Eliminado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        //limpiar();
                    }
                	
                	
                	//sw_elim=0;
                	}
                	else{
                    DialogResult resp = MessageBox.Show("Esta seguro(a) que quiere eliminar el trabajador con herramientas asignadas " + tbnombre.Text + " "+"con Ficha:" + " " + tb_ficha.Text + " ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (resp == DialogResult.Yes)
                    {
                        Clases.consultasSQL.sw[0] = nom_tabla_bd;
                        Clases.consultasSQL.sw[3] = "delete";
                        Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                       
                        Clases.consultasSQL.delete();

                        Clases.consultasSQL.sw[0] = "";
                        Clases.consultasSQL.sw[3] = "";
                        //cargartabla("Ficha");
                        lb_ha.Items.Clear();
                        cargar_lista();
                        limpiar();

                        MessageBox.Show("Eliminado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        //limpiar();
                    }
                	}
                }
                else
                {
                    MessageBox.Show("No puede Eliminar un trabajador que no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    tb_ficha.Focus();
                }

            }
        }
        
        void Btn_modClick(object sender, EventArgs e)
        {
        	
        	txtbuscar.Text = "";
            if (tb_ficha.Text == "")
            {
                MessageBox.Show("El campo Ficha esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (btn_mod.Text == "Modificar")
                {
                    buscar(tb_ficha.Text);
                    //if (b.res == 1)
                    if (res >= 1)
                    {
                        btn_mod.Text = "Actualizar";
                        habilitar();
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar un trabajador que no tiene herramientas asignadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiar();
                        cod_herr.Focus();
                    }
                }


                else
                {
                    Clases.consultasSQL.sw[0] = "herramientas_asignadas";
                    Clases.consultasSQL.sw[2] = "update";

                    //Insertar datos en la tabla
                    Clases.consultasSQL.campos_bd[0] = tb_ficha.Text;
                    Clases.consultasSQL.camposdouble[0] =  Convert.ToDouble(cb_cant.Text);
                    Clases.consultasSQL.campos_bd[1] = cod_herr.Text;
                    Clases.consultasSQL.campos_bd[2] = tb_observ.Text;
                    Clases.consultasSQL.campos_bd[3] = Formularios.acceso.datosbd[2];
                    Clases.consultasSQL.campos_bd[4] = tb_ficha.Text;            
                    
                    //Clases.consultasSQL.fecha[0] = dt_ha.Value;
                    Clases.consultasSQL.fecha[0] = DateTime.Now;
                   

                    Clases.consultasSQL.update();
                    //Clases.consultasSQL.update(fichatrabajador, txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");
					Clases.consultasSQL.sw[0] = "";
                    Clases.consultasSQL.sw[2] = "";
                    cargartabla("Ficha");
                    lb_ha.Items.Clear();
                    cargar_lista();
                    MessageBox.Show("Actualizado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                    inhabilitar();
                    btn_mod.Text = "Modificar";
                }
            }
        	
        }
        
        void Dgvherr_asigCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        	
        	int celda = 0;
            int column = 0;
            String celcol = "";
            sw_elim=1;
            //limpiar();
            celda = dgvherr_asig.CurrentRow.Index;
            column = dgvherr_asig.CurrentCell.ColumnIndex;

            celcol = dgvherr_asig[0, celda].Value.ToString();
            //MessageBox.Show(dgvherr_asig[0, 0].Value.ToString());

            cod_herr.Text = celcol;
            tb_descrip.Text=dgvherr_asig[1, celda].Value.ToString();
            tb_tipo_herr.Text=dgvherr_asig[2, celda].Value.ToString();
            cb_cant.Text=dgvherr_asig[3, celda].Value.ToString();
            tb_observ.Text=dgvherr_asig[4, celda].Value.ToString();
            dt_ha.Value=DateTime.Parse(dgvherr_asig[5, celda].Value.ToString());
            
            inhabilitar();

            btn_mod.Text = "Modificar";
            btn_nuevo.Text = "Nuevo";
            btn_mod.Enabled = true;

            if (Formularios.acceso.datosbd[1] == "Administrador")
            {
                btn_elim.Enabled = true;
            }
            else
            {
                btn_elim.Enabled = false;
            }
            //btn_elim.Enabled=true;
            btn_elim.Text="Eliminar";
            //btn_elim.TextAlign
        	
        }
        
        void CmbbuscarSelectedIndexChanged(object sender, EventArgs e)
        {
        	txtbuscar.Text = "";
            
            txtbuscar.BackColor=Color.White;
            txtbuscar.Enabled=true;
            txtbuscar.Focus();
            
            if(cmbbuscar.Text=="Ficha"){
            
            tb_ficha.Enabled=false;
            tb_ficha.BackColor=DefaultBackColor;
            }
            else if(tb_ficha.Text==""){
          	tb_ficha.Enabled=true;
            tb_ficha.BackColor=Color.White;
            tb_ficha.Focus();
            }
            
            
        }
        
        void TxtbuscarTextChanged(object sender, EventArgs e)
        {
        	textobusqueda = "";
            campobusqueda = cmbbuscar.Text;
            textobusqueda = txtbuscar.Text;
            
            ficha_trab=txtbuscar.Text;
            limpiar_emp();
            cargartabla(campobusqueda);
            
            if(res>0){
            lonf = txtbuscar.TextLength;
            }
            
            if(txtbuscar.Text=="" || txtbuscar.Text==null || txtbuscar.TextLength<lonf ){
            
            	limpiar();
            }
            
            lonf=0;
            
            if(cmbbuscar.Text=="Ficha"){
            
           limpiar_herr();
           //limpiar_emp();
            }
        }
        
       
        
        void Cb_cantKeyPress(object sender, KeyPressEventArgs e)
        {
        	if (e.KeyChar == 13)
            {
                tb_observ.Focus();
                e.Handled = true;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        void Cb_cantSelectedIndexChanged(object sender, EventArgs e)
        {
        	if(tb_stocka.Text==""){
        	
        	}
        	else if(datos_herr[4]=="0"){
        	
        	
        	 MessageBox.Show("No puede asignar una herramienta con stock 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
        	
        	}
        	else if((int.Parse(datos_herr[4])-int.Parse(cb_cant.Text))<0){
        	
        	
        	MessageBox.Show("No puede asignar una cantidad mayor a la actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        	
        	}
        		
        		else{
        			
        	
        		tb_stocka.Text=(int.Parse(datos_herr[4])-int.Parse(cb_cant.Text)).ToString();
        		
        		
        		
        		
        		}
        		
        		
        		
        	}

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            swrep = 1;
            Formularios.Informes form = new Formularios.Informes();

            form.Show();
        }
        	
        
    }
}
