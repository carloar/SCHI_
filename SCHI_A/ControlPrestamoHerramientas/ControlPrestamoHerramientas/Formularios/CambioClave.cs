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
    public partial class CambioClave : Form
    {

        public string dato = "";
        public string encriptado = "";
        public string [] datosbd=new string[10];
        public CambioClave()
        {
            InitializeComponent();
            conexionbd.ConnectTo();//Conectar con la base de datos
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


            if (tb_nva_clave.Text == "")
            {
                dato = "Contraseña Nueva";
                tb_nva_clave.Focus();
                return dato;
            }

            if (tb_nva_clave2.Text == "")
            {
                dato = "Repetición Contraseña Nueva";
                tb_nva_clave2.Focus();
                return dato;
            }


            return "";
        }

        public void buscar(string usuario)
        {

            try
            {
                
                conexionbd.command.CommandText = "SELECT * FROM usuarios WHERE usuario='" + usuario + "' AND clave='" + encriptado + "' ";

                conexionbd.command.CommandType = CommandType.Text;
                conexionbd.connection.Open();
                conexionbd.command.ExecuteNonQuery();

                conexionbd.reader = conexionbd.command.ExecuteReader();

                if (conexionbd.reader.Read())
                {

                    datosbd[0] = conexionbd.reader["ficha"].ToString(); ;
                    datosbd[1] = conexionbd.reader["tipo_usu"].ToString();
                    datosbd[2] = conexionbd.reader["usuario"].ToString();
                    datosbd[3] = conexionbd.reader["clave"].ToString();
                    datosbd[4] = conexionbd.reader["fecha_reg"].ToString();

                }
                else { MessageBox.Show("El Usuario no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }


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



        }//fin funcion buscar

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            campovacio();
            if (dato != "")
            {
                mensaje(dato);
            }
            else
            {
                if (tb_nva_clave.Text != tb_nva_clave2.Text)
                {
                    MessageBox.Show("Las claves a actualizar no son iguales", "Clave Nueva", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else{
                encriptado = Clases.SeguridadAES.Encriptar(tb_pass_actual.Text);
                //MessageBox.Show(Clases.SeguridadAES.Encriptar(tb_pass_actual.Text), "Clave Nueva", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                buscar(tb_user.Text);

                if (tb_user.Text == datosbd[2] && tb_pass_actual.Text == Clases.SeguridadAES.Desencriptar(encriptado))
                {

                    Clases.consultasSQL.sw[0] = "usuarios";
                    Clases.consultasSQL.sw[2] = "update";

                    Clases.consultasSQL.campos_bd[0] = datosbd[0];
                    Clases.consultasSQL.campos_bd[1] = datosbd[1];
                    Clases.consultasSQL.campos_bd[2] = datosbd[2];
                    Clases.consultasSQL.campos_bd[3] = Clases.SeguridadAES.Encriptar(tb_nva_clave.Text); ;
                    Clases.consultasSQL.fecha[0] = Convert.ToDateTime(Clases.consultasSQL.campos_bd[4]);
                    //Clases.consultasSQL.campos_bd[4] = fichatrabajador;

                    // MessageBox.Show(tb_ficha.Text + cb_tipo_user.Text + tb_user.Text + Clases.SeguridadAES.Encriptar(tb_pass.Text) + dt_usu.Value + fichatrabajador, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Clases.consultasSQL.update();
                    //Clases.consultasSQL.update(fichatrabajador, txtficha.Text, txtnombre.Text, txtapellido.Text, cmbdepartamento.Text, cmbcargo.Text, tbtelefono.Text, dtempl.Value, "miguel");

                    //cargartabla("");
                    MessageBox.Show("Clave Actualizada Con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //limpiar();
                    //inhabilitar();
                    //btnupdate.Text = "Modificar";
                    this.Close();
                    Formularios.acceso form = new Formularios.acceso();
                    form.Show();
                }
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            
                Formularios.acceso form = new Formularios.acceso();
                form.Show();
           
            this.Close();
        }
    }
}
