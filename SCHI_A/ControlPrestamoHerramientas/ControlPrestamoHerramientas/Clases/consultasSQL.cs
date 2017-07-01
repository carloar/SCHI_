using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;


namespace ControlPrestamoHerramientas.Clases
{

    class consultasSQL
    {
        public static String [] campos_bd=new String [20];
        public static DateTime[] fecha = new DateTime[20];
        public static Double[] camposdouble = new Double[20];
        public static String cadenasql = "";
        public static String[] sw = new String [10];
        public static String[] fecha_string = new String [20];
        public static int status_consulta = 0;
        public consultasSQL(){

            conexionbd.ConnectTo();//Conectar con la base de datos
        }

        public static void cadenaSQL() {

            switch (sw[0]) { 
                case "empleados":
                    if (sw[1] == "insertar")
                    {
                        cadenasql = "INSERT INTO empleados (ficha_emp,nombre, apellido,departamento,cargo,telefono,fecha_reg,usuario_admin) VALUES('" + campos_bd[0] + "','" + campos_bd[1] + "', '" + campos_bd[2] + "', '" + campos_bd[3] + "', '" + campos_bd[4] + "', '" + campos_bd[5] + "', '" + fecha[0] + "', '" + campos_bd[7] + "')";
                    }
                    if (sw[2] == "update")
                    {
                        cadenasql = "UPDATE empleados SET ficha_emp='" + campos_bd[0] + "',nombre='" + campos_bd[1] + "' ,apellido='" + campos_bd[2] + "',departamento='" + campos_bd[3] + "' ,cargo='" + campos_bd[4] + "' ,telefono='" + campos_bd[5] + "' ,fecha_reg='" + fecha[0] + "',usuario_admin='" + campos_bd[6] + "' " + " WHERE ficha_emp='" + campos_bd[7] + "'";
                    }
                    if (sw[3] == "delete")
                    {
                        cadenasql = "DELETE from empleados WHERE ficha_emp='" + campos_bd[0] + "'";
                    }
                
                break;
            

            case "herramientas":
                if (sw[1] == "insertar")
                {
                   // MessageBox.Show("Prueba"+campos_bd[5], "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cadenasql = "INSERT INTO herramientas(cod_herr,id_herr, descripcion,tipo_herr,marca,ubicacion,stock_ini,stock_actual,observaciones,fecha_reg,usuario) VALUES('" + campos_bd[0] + "','" + camposdouble[0] + "', '" + campos_bd[1] + "', '" + campos_bd[2] + "', '" + campos_bd[3] + "', '" + campos_bd[4] + "','" + camposdouble[1] + "','" + camposdouble[2] + "', '" + campos_bd[5] + "', '" + fecha[0] + "', '" + campos_bd[6] + "')";
                }
                if (sw[2] == "update")
                {
                    cadenasql = "UPDATE herramientas SET cod_herr='" + campos_bd[0] + "',id_herr='" + camposdouble[0] + "' ,descripcion='" + campos_bd[1] + "',tipo_herr='" + campos_bd[2] + "' ,marca='" + campos_bd[3] + "' ,ubicacion='" + campos_bd[4] + "' ,stock_ini='" + camposdouble[1] + "' ,stock_actual='" + camposdouble[2] + "' ,observaciones='" + campos_bd[5] + "' ,fecha_reg='" + fecha[0] + "',usuario='" + campos_bd[6] + "' " + " WHERE cod_herr='" + campos_bd[7] + "'";
                }
                if (sw[3] == "delete")
                {
                    cadenasql = "DELETE from herramientas WHERE cod_herr='" + campos_bd[0] + "'";
                }
                break;
                
                case "herramientas_asignacion":
                if (sw[1] == "insertar")
                {
                   // MessageBox.Show("Prueba"+campos_bd[5], "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cadenasql = "INSERT INTO herramientas_asignacion(cod_herr,id_herr, descripcion,tipo_herr,marca,ubicacion,stock_ini,stock_actual,observaciones,fecha_reg,usuario) VALUES('" + campos_bd[0] + "','" + camposdouble[0] + "', '" + campos_bd[1] + "', '" + campos_bd[2] + "', '" + campos_bd[3] + "', '" + campos_bd[4] + "','" + camposdouble[1] + "','" + camposdouble[2] + "', '" + campos_bd[5] + "', '" + fecha[0] + "', '" + campos_bd[6] + "')";
                }
                if (sw[2] == "update")
                {
                    cadenasql = "UPDATE herramientas_asignacion SET cod_herr='" + campos_bd[0] + "',id_herr='" + camposdouble[0] + "' ,descripcion='" + campos_bd[1] + "',tipo_herr='" + campos_bd[2] + "' ,marca='" + campos_bd[3] + "' ,ubicacion='" + campos_bd[4] + "' ,stock_ini='" + camposdouble[1] + "' ,stock_actual='" + camposdouble[2] + "' ,observaciones='" + campos_bd[5] + "' ,fecha_reg='" + fecha[0] + "',usuario='" + campos_bd[6] + "' " + " WHERE cod_herr='" + campos_bd[7] + "'";
                }
                if (sw[3] == "delete")
                {
                    cadenasql = "DELETE from herramientas_asignacion WHERE cod_herr='" + campos_bd[0] + "'";
                }
                break;

            case "prestamo":
                if (sw[1] == "insertar")
                {
                    cadenasql = "INSERT INTO prestamo(ficha_emp,cod_herr,cantidad,observacion, fecha,estatus,usuario) VALUES('" + campos_bd[0] + "', '" + campos_bd[1] + "', '" + camposdouble[0] + "', '" + campos_bd[2] + "', '" + fecha[0] + "','" + campos_bd[3] + "','" + campos_bd[4] + "')";
                }
                if (sw[2] == "update")
                {
                    cadenasql = "UPDATE prestamo SET ficha_emp='" + campos_bd[0] + "',cod_herr='" + campos_bd[1] + "' ,cantidad='" + camposdouble[0] + "',observacion='" + campos_bd[2] + "' ,fecha='" + fecha[0] + "' ,estatus='" + campos_bd[3] + "' ,usuario='" + campos_bd[4] + "'" + " WHERE (cod_herr='" + campos_bd[1] + "' and ficha_emp='" + campos_bd[0] + "' and estatus='" + campos_bd[5] + "') ";
                   // cadenasql = "UPDATE prestamo SET ficha_emp='" + campos_bd[0] + "',cod_herr='" + campos_bd[1] + "' ,cantidad='" + camposdouble[0] + "',observacion='" + campos_bd[2] + "' ,fecha='" + fecha[0] + "' ,estatus='" + campos_bd[3] + "' ,usuario='" + campos_bd[4] + "'" + " WHERE cod_herr='" + campos_bd[1] + "' and ficha_emp='" + campos_bd[0] + "' ";
                }
                if (sw[3] == "delete")
                {
                    cadenasql = "DELETE from prestamo WHERE (cod_herr='" + campos_bd[1] + "' and ficha_emp='" + campos_bd[0] + "' and estatus='" + campos_bd[5] + "')";
                }
            
            break;

            case "usuarios":
            if (sw[1] == "insertar")
            {
                
                cadenasql = "INSERT INTO usuarios (ficha_emp,tipo_usu,usuario,clave, fecha_reg) VALUES('" + campos_bd[0] + "','" + campos_bd[1] + "','" + campos_bd[2] + "','" + campos_bd[3] + "','" + fecha[0] + "')";
            }
            if (sw[2] == "update")
            {
                //MessageBox.Show(campos_bd[0] + campos_bd[1] + campos_bd[2] + campos_bd[3] + fecha[0] + campos_bd[4], "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cadenasql = "UPDATE usuarios SET ficha_emp='" + campos_bd[0] + "',tipo_usu='" + campos_bd[1] + "' ,usuario='" + campos_bd[2] + "',clave='" + campos_bd[3] + "',fecha_reg='" + fecha[0] + "' " + " WHERE (ficha_emp='" + campos_bd[0] +"') ";
                //cadenasql = "UPDATE usuarios SET ficha='" + campos_bd[0] + "',tipo_usu='" + campos_bd[1] + "' ,usuario='" + campos_bd[2] + "',clave='" + campos_bd[3] + "',fecha='" + fecha[0] + "',usuario_admin='" + campos_bd[6] + "' " + " WHERE ficha='" + campos_bd[4] + "'";
            }
            if (sw[3] == "delete")
            {
                cadenasql = "DELETE from usuarios WHERE ficha_emp='" + campos_bd[0] + "'";
            }

            break;

            case "configuracion":
            if (sw[1] == "insertar")
            {

                cadenasql = "INSERT INTO usuarios (ficha,tipo_usu,usuario,clave, fecha_reg) VALUES('" + campos_bd[0] + "','" + campos_bd[1] + "','" + campos_bd[2] + "','" + campos_bd[3] + "','" + fecha[0] + "')";
            }
            if (sw[2] == "update")
            {
                
                //fecha[0]=Convert.ToDateTime(fecha[0].ToString("yyyy-MM-dd HH:mm:ss"));
                /*if(Formularios.acceso.datos_conf[3]=="Access"){
                	
                cadenasql = "UPDATE configuracion SET id_conf='" + camposdouble[0] + "',titulo_sist='" + campos_bd[0] + "' ,nom_empresa='" + campos_bd[1] + "',tiempo_mora='" + camposdouble[1] + "' ,base_datos='" + campos_bd[2] + "',fecha_reg='" + fecha[0] + "' ";
                }*/
                
                //else if (Formularios.acceso.datos_conf[3]=="MySql"){
                	//cadenasql = "UPDATE configuracion SET titulo_sist='" + campos_bd[0] + "' ,nombre_empresa='" + campos_bd[1] + "',tiempo_mora='" + camposdouble[1] + "' ,base_datos='" + campos_bd[2] + "',fecha_reg='" + fecha_string[0] + "' ";
                
                	cadenasql = "UPDATE configuracion SET titulo_sist='" + campos_bd[0] + "' ,nombre_empresa='" + campos_bd[1] + "',tiempo_mora='" + camposdouble[1] + "' ,base_datos='" + campos_bd[2] + "',fecha_reg='" + fecha[0] + "' ";
                	
                	//}
            }
            if (sw[3] == "delete")
            {
                cadenasql = "DELETE from usuarios WHERE ficha='" + campos_bd[0] + "'";
            }

            break;
            
            case "herramientas_asignadas":
            
            if (sw[1] == "insertar")
                    {
                        cadenasql = "INSERT INTO herramientas_asignadas (ficha_emp,cod_herr, cantidad,observacion,fecha_reg,usuario) VALUES('" + campos_bd[0] + "','" + campos_bd[1] + "', '" + camposdouble[0] + "', '" + campos_bd[2] + "', '" + fecha[0] + "', '" + campos_bd[3] + "')";
                    }
                    if (sw[2] == "update")
                    {
                        cadenasql = "UPDATE herramientas_asignadas SET ficha_emp='" + campos_bd[0] + "',cod_herr='" + campos_bd[1] + "' ,cantidad='" + camposdouble[0] + "',observacion='" + campos_bd[2] + "' ,fecha_reg='" + fecha[0] + "' ,usuario='" + campos_bd[3] + "' " + " WHERE ficha_emp='" + campos_bd[4] + "' and cod_herr='" + campos_bd[1] + "' ";
                    }
                    if (sw[3] == "delete")
                    {
                    	if(Formularios.herramientas_asignadas.sw_elim==1){
                    		cadenasql = "DELETE from herramientas_asignadas WHERE ficha_emp='" + campos_bd[0] + "' and cod_herr='" + campos_bd[1] + "'";
                    	Formularios.herramientas_asignadas.sw_elim=0;
                    	}
                    	else{
                        cadenasql = "DELETE from herramientas_asignadas WHERE ficha_emp='" + campos_bd[0] + "'";
                    }
                    	}
                
                break;

            }

            
        }

        
        //Insertar datos en la tabla empleados
        //public static void insertar(string ficha, string nombre, string apellido, string departamento, string cargo, string telefono, DateTime fecha, string usuario)
        public static void insertar()
        {
            //conexionbd.ConnectTo();//Conectar con la base de datos

            try
            {
                //conexionbd.command.CommandText = "INSERT INTO empleados (ficha_emp,nombre, apellido,departamento,cargo,telefono,fecha_reg,usuario_admin) VALUES('" + ficha + "','" + nombre + "', '" + apellido + "', '" + departamento + "', '" + cargo + "', '" + telefono + "', '" + fecha + "', '" + usuario + "')";
                cadenaSQL();
                conexionbd.command.CommandText = cadenasql;
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

               
            }
            catch (Exception)
            {
                MessageBox.Show("Error de codigo SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }

        }//Fin funcion insertar

        public static void delete()
        {

            try
            {
                cadenaSQL();
                conexionbd.command.CommandText = cadenasql;

                //conexionbd.command.CommandText = "DELETE from empleados WHERE ficha_emp='" + ficha + "'";
                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                conexionbd.reader = conexionbd.command.ExecuteReader();

                //int i = 0;
                /*if (conexionbd.reader.Read())
                {
                    status_consulta = 1;

                }
                else { status_consulta = 0; }*/
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }

        }//Fin funcion delete

        //public static void update(string ficha_anterior, string ficha, string nombre, string apellido, string departamento, string cargo, string telefono, DateTime fecha, string usuario)
        public static void update()
        {

            try
            {

                cadenaSQL();
                string sel_bd=Formularios.acceso.datos_conf[3];
                /*switch (sel_bd)
                {
                    case "Access":*/
                        //ACCESS
                        conexionbd.command.CommandText = cadenasql;                
                        conexionbd.command.CommandType = CommandType.Text;
                        conexionbd.connection.Open();
                        conexionbd.command.ExecuteNonQuery();

                       /* break;
                    case "MySql":

                        ConexionMySql.actualizar(cadenasql);

                        break;

                    default:
                        break;
                }*/

                
            }
            catch (Exception)
            {
                MessageBox.Show("Error de codigo SQL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                if (conexionbd.connection != null)
                {
                    conexionbd.connection.Close();
                }
            }

        }//Fin Funcion update

        
    }
}
