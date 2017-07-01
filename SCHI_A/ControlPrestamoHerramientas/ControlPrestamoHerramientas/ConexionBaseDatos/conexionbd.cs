using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace ControlPrestamoHerramientas
{
    class conexionbd
    {
        public static OleDbConnection connection;
        public static OleDbCommand command;
        public static OleDbDataReader reader;
        public static int scbd=0;

        public static void ConnectTo()
        {
            try
            {//Inicio try

            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\BDA\\prestamo_herramientas.accdb;Jet OLEDB:Database Password=mebym73");

            command = connection.CreateCommand();
            
            	
            }
            
            catch (System.Exception)
            {
                MessageBox.Show("Error de Conexión, verifique que existe la base de datos: C:\\BDA\\prestamo_herramientas.accdb",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            	scbd=1;
            }//fin catch 
        }
    }

    
}
