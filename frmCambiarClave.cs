using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockIt_Entidades;
using StockIt_Logica;

namespace StockIt
{
    public partial class frmCambiarClave : Form
    {
        Utils utils = new Utils();

        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string pwdActual = txtClaveA.Text.Trim();
            string pwdNueva = txtClaveN.Text.Trim();
            string pwdNuevaC = txtClaveNC.Text.Trim();

            if(pwdActual == "" || pwdNueva == "" || pwdNuevaC == "")
            {
                //Si al menos uno de los campos está vacío
                if(pwdActual == "")
                {
                    utils.messageBoxCampoRequerido("Debes ingresar tu contraseña actual.");
                    txtClaveA.Focus();
                }
                else if (pwdNueva == "")
                {
                    utils.messageBoxCampoRequerido("Debes ingresar una contraseña nueva.");
                    txtClaveN.Focus();
                }
                else if (pwdNuevaC == "")
                {
                    utils.messageBoxCampoRequerido("Debes confirmar tu contraseña.");
                    txtClaveNC.Focus();
                }
            }
            else
            {
                //Validar el formato de la contraseña nueva
                if (utils.validarPassword(pwdNueva))
                {
                    //Validamos la coincidencia entre la Nueva Contraseña y su Confirmación
                    if (pwdNueva == pwdNuevaC)
                    {
                        //Validar existencia de pwdActual en la BD
                        EUsuario eUsuario = new EUsuario();
                        eUsuario.Correo = utils.getCorreoUsuario();
                        eUsuario.Password = pwdActual;

                        int r = new LUsuarios().ActualizarPassword(eUsuario, pwdNueva);

                        if (r > 0)
                        {
                            utils.messageBoxOperacionExitosa("Contraseña cambiada con éxito.");
                            
                            //Habilitamos los controles del formulario
                            utils.habilitarOpcionesDeMenu();

                            //Ocultamos las contraseñas
                            chkbMostrarPwd.Checked = false;

                            //Limpiar campos
                            limpiarControles();
                        }
                        else if(r == -1)
                        {
                            utils.messageBoxAlerta("La contraseña actual no coincide con la registrada.");
                            txtClaveA.Focus();
                        }
                        else if (r == -2)
                        {
                            utils.messageBoxAlerta("No se pudo actualizar la contraseña." +
                                "\nIntente más tarde.");
                            limpiarControles();
                        }
                        else
                        {
                            utils.messageBoxAlerta("Hubo un error. Intente más tarde.");
                            limpiarControles();
                            txtClaveA.Focus();
                        }
                    }
                    else
                    {
                        utils.messageBoxAlerta("La contraseña nueva y su confirmación deben coincidir.");
                        txtClaveN.Focus();
                    }
                }
                else
                {
                    utils.messageBoxFormatoIncorrecto("La contraseña debe contener como mínimo: " +
                        "\n+ 8 carácteres." +
                        "\n+ Un número dígito." +
                        "\n+ Una letra minúscula." +
                        "\n+ Una letra mayúscula." +
                        "\n+ Un carácter especial (!*@#$%^&+=).");
                    txtClaveN.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void chkbMostrarPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtClaveA.PasswordChar == '*')
            {
                txtClaveA.PasswordChar = '\0';
            }
            else
            {
                txtClaveA.PasswordChar = '*';
            }

            if (txtClaveN.PasswordChar == '*')
            {
                txtClaveN.PasswordChar = '\0';
            }
            else
            {
                txtClaveN.PasswordChar = '*';
            }

            if (txtClaveNC.PasswordChar == '*')
            {
                txtClaveNC.PasswordChar = '\0';
            }
            else
            {
                txtClaveNC.PasswordChar = '*';
            }
        }

        private void limpiarControles()
        {
            txtClaveA.Text = null;
            txtClaveN.Text = null;
            txtClaveNC.Text = null;
            txtClaveA.Focus();
        }
    }
}
