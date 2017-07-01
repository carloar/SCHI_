using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Configuration;

//namespace ControlPrestamoHerramientas.ConexionBaseDatos
    namespace ControlPrestamoHerramientas
{
    class ConexionMySql
    {
        //Cadena de conexión a la base de datos
     /*public static string cadconex = "Database=cph;Data Source=localhost;User Id=root;Password=mebym";
        
        //Variable Conexión a la base de datos
        public static MySqlConnection cnn = new MySqlConnection(cadconex);//Conexión base de datos
        //public static string sql = "";
        
        public static MySqlCommand myCommand;
        public static string mySelectQuery = "";//Variable para codigo SQL Select
        public static MySqlDataReader reader;//Variable para leer datos de la base de datos
        public static string myInsertQuery = "";//Variable para codigo SQL Update
        //public static MySqlConnection;
        public static int scbd=0;

        public static void consulta_gen(string sql) {



            myCommand = new MySqlCommand(sql, cnn);
            
            cnn.Open();
            myCommand.ExecuteNonQuery();
            
            
        }
        public static void consulta(string sql) {



            myCommand = new MySqlCommand(sql, cnn);
            
            cnn.Open();
            myCommand.ExecuteNonQuery();
            
            reader = ConexionMySql.myCommand.ExecuteReader();
        }

        //>>>>>>>>>>>>>>>>>>>>>>>CONECTAR A LA BASE DE DATOS<<<<<<<<<<<<<<<<<<<<<<<<

        public static void conectarBD()
        {
            try
            {//Inicio try

                MySqlConnection myConnection = new MySqlConnection(cadconex);
                //cnn.Open();
                myConnection.Open();//Abrir conexión a la base de datos
                //MessageBox.Show("Conexión,exitosa",
                               // "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//Fin try

            catch (System.Exception)
            {
                MessageBox.Show("Error de Conexión, verifique que el servidor este activo",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            	scbd=1;
            }//fin catch 


        }//Fin ConectarBD


        //>>>>>>>>>>>>>>>>EJECUTAR EL COMANDO SELECT PARA MOSTRAR DATOS<<<<<<<<<<<<<<<<<<<<<<<

        public static void seleccion()
        {
            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, cnn);
            cnn.Open();
            reader = myCommand.ExecuteReader();
        }//Fin función selección

        //>>>>EJECUTAR EL COMANDO UPDATE PARA ACTUALIZAR O MIDIFICAR DATOS<<<<

        public static void actualizar(string sql)
        {
            myCommand = new MySqlCommand(sql, cnn);

            cnn.Open();
            myCommand.ExecuteNonQuery();


           
            myCommand.Connection.Close();
            MessageBox.Show("Actualizado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }//Fin función actualizar
		
		*/
    }
    //}
}
