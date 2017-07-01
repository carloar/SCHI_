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
    public partial class configuracion : Form
    {
        public string dato = "";
        public configuracion()
        {
            InitializeComponent();
            for(int i=1;i<=5;i++){
                cb_tm.Items.Add(i);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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
            if (tb_tit_sist.Text == "")
            {
                dato = "Titulo del Sistema";
                tb_tit_sist.Focus();
                return dato;
            }


            if (tb_nom_emp.Text == "")
            {
                dato = "Nombre de la Empresa";
                tb_nom_emp.Focus();
                return dato;
            }

            if (cb_tm.Text == "")
            {
                dato = "Tiempo Mora";
                cb_tm.Focus();
                return dato;
            }

            if (cb_bd.Text == "")
            {
                dato = "Base de Datos";
                cb_bd.Focus();
                return dato;
            }

           

            return "";
        }


        public void cargar_datos() {
            string sql = "";
            sql = "SELECT * from configuracion ";

           /* ConexionMySql.consulta(sql);

            //>>>>>>>>>>>>>>>>>>>VACIAR LOS DATOS EN LA TABLA>>>>>>>>>>>>
            if (ConexionMySql.reader.Read())
            {

                tb_tit_sist.Text = ConexionMySql.reader["titulo_sist"].ToString(); ;
                tb_nom_emp.Text = ConexionMySql.reader["nom_empresa"].ToString();
                cb_tm.Text = ConexionMySql.reader["tiempo_mora"].ToString();
                cb_bd.Text = ConexionMySql.reader["base_datos"].ToString();
                dt_ps.Value = DateTime.Parse(ConexionMySql.reader["fecha_reg"].ToString());



            }
            ConexionMySql.cnn.Close();*/
            
            conexionbd.command.CommandText = sql;

                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                
                if (conexionbd.reader.Read())
                {

                    tb_tit_sist.Text = conexionbd.reader["titulo_sist"].ToString(); ;
                    tb_nom_emp.Text = conexionbd.reader["nombre_empresa"].ToString();
                    cb_tm.Text= conexionbd.reader["tiempo_mora"].ToString();
                    cb_bd.Text = conexionbd.reader["base_datos"].ToString();
                    dt_ps.Value = DateTime.Parse(conexionbd.reader["fecha_reg"].ToString());
                    //acceso.datos_conf[5] = conexionbd.reader["id_config"].ToString();


                }
                //ConexionMySql.cnn.Close();
                conexionbd.connection.Close();

        }

        private void configuracion_Load(object sender, EventArgs e)
        {
           /* tb_tit_sist.Text = acceso.datos_conf[0];
            tb_nom_emp.Text = acceso.datos_conf[1];
            cb_tm.Text = acceso.datos_conf[2];
            cb_bd.Text = acceso.datos_conf[3];
            dt_ps.Value = DateTime.Parse(acceso.datos_conf[4]);*/


            cargar_datos();
            }

        public void habilitar() {
            bool valor = true;
            tb_tit_sist.Enabled=valor;
            tb_tit_sist.BackColor = Color.White;
            tb_nom_emp.Enabled = valor;
            tb_nom_emp.BackColor = Color.White;
            cb_tm.Enabled = valor;
            cb_tm.BackColor = Color.White;
            cb_bd.Enabled = valor;
            cb_bd.BackColor = Color.White;
            dt_ps.Enabled = valor;
        
                }

        public void inhabilitar()
        {

            bool valor = false;
            tb_tit_sist.Enabled = valor;
            tb_tit_sist.BackColor = DefaultBackColor;
            tb_nom_emp.Enabled = valor;
            tb_nom_emp.BackColor = DefaultBackColor;
            cb_tm.Enabled = valor;
            cb_tm.BackColor = DefaultBackColor;
            cb_bd.Enabled = valor;
            cb_bd.BackColor = DefaultBackColor;
            dt_ps.Enabled = valor;
            btnupdate.Text = "Modificar";
        

        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (btnupdate.Text == "Modificar")
            {
                habilitar();
                btnupdate.Text = "Guardar";
            }
            else {

                campovacio();
                if (dato != "")
                {
                    mensaje(dato);
                }


                else
                {
                    Clases.consultasSQL.sw[0] = "configuracion";
                    Clases.consultasSQL.sw[2] = "update";                    
                    Clases.consultasSQL.camposdouble[0] = Double.Parse(acceso.datos_conf[5]);
                    Clases.consultasSQL.campos_bd[0] = tb_tit_sist.Text;
                    Clases.consultasSQL.campos_bd[1] = tb_nom_emp.Text;
                    Clases.consultasSQL.camposdouble[1] = Double.Parse(cb_tm.Text);
                    Clases.consultasSQL.campos_bd[2] = cb_bd.Text;                   
                    //Clases.consultasSQL.fecha[0] = DateTime.Parse(dt_ps.Value.ToString("dd/MM/yyyy"+" "+DateTime.Now.ToString("HH:mm:ss tt")));
                    Clases.consultasSQL.fecha[0] = dt_ps.Value;
                    //Clases.consultasSQL.fecha[0] = DateTime.Parse(dt_ps.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    //dt_ps.Value.ToString("yyyy-MM-dd H:mm:ss");
                    Clases.consultasSQL.update();

                    MessageBox.Show("Actualizado Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    string sql = "SELECT * from configuracion ";

                  
                    conexionbd.command.CommandText = sql;

                    conexionbd.command.CommandType = CommandType.Text;
                    conexionbd.connection.Open();
                    conexionbd.command.ExecuteNonQuery();

                    conexionbd.reader = conexionbd.command.ExecuteReader();

                   
                    if (conexionbd.reader.Read())
                    {

                        Formularios.acceso.datos_conf[0] = conexionbd.reader["titulo_sist"].ToString(); ;
                        Formularios.acceso.datos_conf[1] = conexionbd.reader["nombre_empresa"].ToString();
                        Formularios.acceso.datos_conf[2] = conexionbd.reader["tiempo_mora"].ToString();
                        Formularios.acceso.datos_conf[3] = conexionbd.reader["base_datos"].ToString();
                        Formularios.acceso.datos_conf[4] = conexionbd.reader["fecha_reg"].ToString();
                        Formularios.acceso.datos_conf[5] = conexionbd.reader["id_config"].ToString();


                    }
                    //ConexionMySql.cnn.Close();
                    conexionbd.connection.Close();
                    
                    inhabilitar();
                }
            
            
            
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            inhabilitar();
        }

        private void dt_ps_ValueChanged(object sender, EventArgs e)
        {
        	
            //dt_ps.Format=DateTimePickerFormat.Custom;
            //dt_ps.CustomFormat="yyyy-MM-dd HH:mm:ss";
            dt_ps.Value=Convert.ToDateTime(dt_ps.Value.ToString("yyyy-MM-dd"+" "+DateTime.Now.ToString("HH:mm:ss")));
            //MessageBox.Show(dt_ps.Value.ToString("yyyy-MM-dd"+" "+DateTime.Now.ToString("HH:mm:ss")));
            
            
            //MessageBox.Show(DateTime.Now.ToString("HH:mm:ss"));
            //MessageBox.Show(dt_ps.CustomFormat="yyyy-MM-dd hh:mm:ss");
        }

       
        
    }
}
