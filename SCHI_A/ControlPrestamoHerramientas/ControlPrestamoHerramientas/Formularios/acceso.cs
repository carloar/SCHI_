using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using System.Data;
//using MySql.Data;
//using MySql.Data.MySqlClient;
//using System.ComponentModel;
using System.Configuration;

namespace ControlPrestamoHerramientas.Formularios
{
    public partial class acceso : Form
    {
        public String dato = "";
        public String nom_tabla_bd = "Usuarios";
        public static string[] datosbd = new string[10];
        public static string[] datos_conf= new string[10];
        public string encriptado = "";
        public string desencriptado = "";
        public int contador = 0;
        public string sql = "";
        public string sel_bd = "";
        //public MySqlConnection cnn = new MySqlConnection(ConexionMySql.cadconex);/*Conexión base de datos*/
        
        //*****************************************************+
        public acceso()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
            //ConexionMySql.conectarBD();
            
            //cnn = ConexionMySql.conectarBD();
            //MySqlConnection cnn = new MySqlConnection(ConexionMySql.cadconex);/*Conexión base de datos*/
        }

        public void mensaje(string texto)
        {
            MessageBox.Show("El campo" + " " + texto + " esta Vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public string campovacio()
        {
            dato = "";
            if (tb_user.Text == "")
            {
                dato = "Usuario";
                tb_user.Focus();
                return dato;
            }


            if (tb_pass.Text == "")
            {
                dato = "Contraseña";
                tb_pass.Focus();
                return dato;
            }

            
            return "";
        }

        public void base_datos(string sel_bd) {

            /*sql = "SELECT * from configuracion ";

            ConexionMySql.consulta(sql);

            //>>>>>>>>>>>>>>>>>>>VACIAR LOS DATOS EN LA TABLA>>>>>>>>>>>>
            if (ConexionMySql.reader.Read())
            {

                datos_conf[0] = ConexionMySql.reader["titulo_sist"].ToString(); ;
                datos_conf[1] = ConexionMySql.reader["nom_empresa"].ToString();
                datos_conf[2] = ConexionMySql.reader["tiempo_mora"].ToString();
                datos_conf[3] = ConexionMySql.reader["base_datos"].ToString();
                datos_conf[4] = ConexionMySql.reader["fecha_reg"].ToString();
                //datos_conf[5] = ConexionMySql.reader["apellido"].ToString();


            }
            ConexionMySql.cnn.Close();*/
           

            sql = "SELECT empleados.nombre,empleados.apellido,usuarios.ficha_emp,usuarios.usuario,usuarios.clave,usuarios.tipo_usu FROM (usuarios INNER JOIN empleados ON empleados.ficha_emp=usuarios.ficha_emp) WHERE usuarios.usuario='" + tb_user.Text + "' AND clave='" + encriptado + "' ";
            //sql = "SELECT empleados.ficha_emp,empleados.nombre,empleados.apellido,usuarios.ficha,usuarios.usuario,usuarios.clave,usuarios.tipo_usu FROM (usuarios INNER JOIN empleados ON empleados.ficha_emp=usuarios.ficha) WHERE usuario='" + tb_user.Text + "' AND clave='" + encriptado + "' ";
            //>>>>>>>>>>>LECTURA DE LA BASE DE DATOS>>>>>>>>>>>>>>>>>>>

            switch (sel_bd)
            {
                case "MySql":
                    /*ConexionMySql.consulta(sql);

                    //>>>>>>>>>>>>>>>>>>>VACIAR LOS DATOS EN LA TABLA>>>>>>>>>>>>
                    if (ConexionMySql.reader.Read())
                    {

                        datosbd[0] = ConexionMySql.reader["ficha_emp"].ToString(); ;
                        datosbd[1] = ConexionMySql.reader["tipo_usu"].ToString();
                        datosbd[2] = ConexionMySql.reader["usuario"].ToString();
                        datosbd[3] = ConexionMySql.reader["clave"].ToString();
                        datosbd[4] = ConexionMySql.reader["nombre"].ToString();
                        datosbd[5] = ConexionMySql.reader["apellido"].ToString();


                    }*/

                    

                    break;
                    



                //>>>>>>>>>>>>>>>>>>>>>>>>>>>>

                case "Access":
                    //>>>>>>>>>>>>>>>>>>>ACCESS>>>>>>>>>>>>

                    conexionbd.command.CommandText = sql;

                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                    if (conexionbd.reader.Read())
                    //while (conexionbd.reader.Read())
                    {

                        datosbd[0] = conexionbd.reader["ficha_emp"].ToString(); ;
                        datosbd[1] = conexionbd.reader["tipo_usu"].ToString();
                        datosbd[2] = conexionbd.reader["usuario"].ToString();                        
                        datosbd[3] = conexionbd.reader["clave"].ToString();
                        datosbd[4] = conexionbd.reader["nombre"].ToString();
                        datosbd[5] = conexionbd.reader["apellido"].ToString();
                        

                    }

                    break;
                default:
                    break;
            }
        
        
        
        }

        public void buscar()
        {
           
            try
            {
                /*conexionbd.command.CommandText = "SELECT COUNT(*) FROM " + nom_tabla_bd + " WHERE ficha_emp='" + ficha + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                res = Convert.ToInt32(conexionbd.command.ExecuteScalar());

                conexionbd.connection.Close();*/
                //MySqlConnection myConnection = new MySqlConnection(ConexionMySql.cadconex);
                
                /*sql="SELECT COUNT(*) FROM empleados WHERE ficha_emp='" + "6414" + "'";

               // conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE user='" + tb_user.Text + "' AND password='" + tb_pass.Text + "' ";
                //conexionbd.command.CommandText = "SELECT * FROM " + nom_tabla_bd + " WHERE user='" + tb_user.Text + "' AND password='" + Clases.Seguridad.result + "' ";
                MySqlCommand sql1 = new MySqlCommand(sql, ConexionMySql.myConnection);
                ConexionMySql.myConnection.Open();//Abrir base de datos

                int result = Convert.ToInt32(sql1.ExecuteScalar());
                ConexionMySql.myConnection.Close();//cerrar base de datos

                if (result == 1)
                {
                    MessageBox.Show("Ya Existe el Registro");

                    
                }*/

                sql = "SELECT * from configuracion ";

                //ConexionMySql.consulta(sql);
                
                conexionbd.command.CommandText = sql;

                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                //>>>>>>>>>>>>>>>>>>>VACIAR LOS DATOS EN LA TABLA>>>>>>>>>>>>
                /*if (ConexionMySql.reader.Read())
                
                {

                    datos_conf[0] = ConexionMySql.reader["titulo_sist"].ToString(); ;
                    datos_conf[1] = ConexionMySql.reader["nombre_empresa"].ToString();
                    datos_conf[2] = ConexionMySql.reader["tiempo_mora"].ToString();
                    datos_conf[3] = ConexionMySql.reader["base_datos"].ToString();
                    datos_conf[4] = ConexionMySql.reader["fecha_reg"].ToString();
                    datos_conf[5] = ConexionMySql.reader["id_conf"].ToString();


                }*/
                
                //if (ConexionMySql.reader.Read())
                if (conexionbd.reader.Read())
                {

                    datos_conf[0] = conexionbd.reader["titulo_sist"].ToString(); ;
                    datos_conf[1] = conexionbd.reader["nombre_empresa"].ToString();
                    datos_conf[2] = conexionbd.reader["tiempo_mora"].ToString();
                    datos_conf[3] = conexionbd.reader["base_datos"].ToString();
                    datos_conf[4] = conexionbd.reader["fecha_reg"].ToString();
                    datos_conf[5] = conexionbd.reader["id_config"].ToString();


                }
                //ConexionMySql.cnn.Close();
                conexionbd.connection.Close();


                


                base_datos(datos_conf[3]);
                //base_datos("MySql");
                //base_datos("Access");
                


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (conexionbd.connection != null || ConexionMySql.cnn != null)
                	if (conexionbd.connection != null )
                {
                    conexionbd.connection.Close();
                    //ConexionMySql.cnn.Close();
                }
            }

           

        }//fin funcion buscar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (Principal.cargar == 1)
            {

                Principal form = new Principal();
                form.Show();
                Principal.cargar = 0;

            }
            else
            {
                Application.Exit();
            }
            
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            //ConexionMySql.conectarBD();
            
            
            if (campovacio() == "")
            {
                //Clases.Seguridad.Encriptar(tb_pass.Text);
                encriptado=Clases.SeguridadAES.Encriptar(tb_pass.Text);

                //desencriptado = Clases.SeguridadAES.Desencriptar(datosbd[3]);
               // MessageBox.Show(encriptado);
                //MessageBox.Show(desencriptado);

                //string text = "123";
                //MessageBox.Show(Clases.SeguridadAES.Encriptar(tb_pass.Text), "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show(Clases.SeguridadAES.Encriptar(text), "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show(Clases.SeguridadAES.Desencriptar(Clases.SeguridadAES.Encriptar(text)), "Desencriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show(Clases.SeguridadAES.Desencriptar(Clases.SeguridadAES.Encriptar(tb_pass.Text)), "Desencriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                buscar();
                //MessageBox.Show(Clases.SeguridadAES.Encriptar(tb_pass.Text)+"Clave:" +datosbd[3], "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




                if (encriptado == datosbd[3])
                {
                    desencriptado = Clases.SeguridadAES.Desencriptar(datosbd[3]);
                    //MessageBox.Show(Clases.SeguridadAES.Encriptar(tb_pass.Text) + "Clave:" + datosbd[3], "Encriptado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (tb_user.Text == datosbd[2] && tb_pass.Text == desencriptado)
                    {

                        this.Visible = false;
                        Principal form = new Principal();
                        form.Show();

                    }
                    
                }

                else
                {
                    MessageBox.Show("Introduzca bien el usuario y clave", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    contador++;

                    if (contador == 3) {

                        MessageBox.Show("Ud no es usuario de este sistema, consulte con el administrador Miguel Gonzalez", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        Application.Exit();
                    }
                
                }

            }
            else { mensaje(dato); }
            
        }

        private void tb_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tb_pass.Focus();

            }
        }

        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_entrar.Focus();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formularios.CambioClave form = new Formularios.CambioClave();
            form.Show();
            this.Visible = false;
        }

        private void acceso_Load(object sender, EventArgs e)
        {

        	//if(ConexionMySql.scbd==1 && conexionbd.scbd==1){
        		if(conexionbd.scbd==1){
        	
        		//Formularios.acceso form=new Formularios.acceso();
        		this.Close();
        		
        		
        	//ConexionMySql.scbd=0;
        	conexionbd.scbd=0;
        	}
        }
    }
}
