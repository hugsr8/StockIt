using StockIt_Entidades;
using StockIt_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmAggClientes : Form
    {
        Utils utils = new Utils();

        public frmAggClientes()
        {
            InitializeComponent();
        }

        private void frmAggClientes_Load(object sender, EventArgs e)
        {
            llenarCbxSexo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numClie = mskNumClie.Text.Trim();

            if (txtNomClie.Text.Trim() == "" || txtApeClie.Text.Trim() == "" || cbxSexoClie.SelectedIndex == 0
                || numClie.Length < 9 || txtCorreoClie.Text.Trim() == "")
            {
                if(txtNomClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el/los nombre(s) del cliente.");
                    txtNomClie.Focus();
                }
                else if (txtApeClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el/los apellido(s) del cliente.");
                    txtApeClie.Focus();
                }
                else if (cbxSexoClie.SelectedIndex == 0)
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar el sexo del cliente.");
                    cbxSexoClie.Focus();
                }
                else if (numClie.Length < 9)
                {
                    utils.messageBoxCampoRequerido("Debes escribir el número de teléfono del cliente.");
                    mskNumClie.Focus();
                }
                else if (txtCorreoClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el correo electrónico del cliente.");
                    txtCorreoClie.Focus();
                }
            }
            else
            {
                try
                {
                    //Validamos email
                    string email = txtCorreoClie.Text.Trim();
                    if (utils.validarEmail(email))
                    {
                        //Registramos el cliente
                        ECliente eCliente = new ECliente();
                        eCliente.NombreCliente = txtNomClie.Text.Trim().ToUpper();
                        eCliente.ApellidoCliente = txtApeClie.Text.Trim().ToUpper();
                        eCliente.SexoCliente = cbxSexoClie.SelectedIndex == 1 ? "M" : "F";
                        eCliente.TelefonoCliente = mskNumClie.Text.Trim();
                        eCliente.CorreoCliente = txtCorreoClie.Text.Trim();

                        int r = new LClientes().InsertarCliente(utils.getIdUsuario(), eCliente);

                        if (r > 0)
                        {
                            //Mensaje de registro exitoso
                            utils.messageBoxOperacionExitosa("El cliente se ha registrado satisfactoriamente.");
                            limpiarCampos();
                        }
                        else if (r == -1)
                        {
                            utils.messageBoxAlerta("No se puede asignar el telefono \"" + eCliente.TelefonoCliente + "\" al cliente." +
                                "\nHay uno existente con idéntico telefono.");
                        }
                        else if (r == -2)
                        {
                            utils.messageBoxAlerta("No se puede asignar el correo \"" + eCliente.CorreoCliente + "\" al cliente." +
                                "\nHay uno existente con idéntico correo.");
                        }
                        else if (r == -3)
                        {
                            utils.messageBoxAlerta("No se pudo insertar el cliente. Intente más tarde.");
                        }
                        else
                        {
                            utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                        }
                    }
                    else
                    {
                        utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                        txtCorreoClie.Focus();
                    }

                }
                catch (Exception)
                {
                    utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                    txtCorreoClie.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void llenarCbxSexo()
        {
            cbxSexoClie.Items.Add("SELECCIONAR");
            cbxSexoClie.Items.Add("MASCULINO");
            cbxSexoClie.Items.Add("FEMENINO");
            cbxSexoClie.SelectedIndex = 0;
        }

        //Limpiar campos
        private void limpiarCampos()
        {
            txtNomClie.Text = null;
            txtApeClie.Text = null;
            cbxSexoClie.SelectedIndex = 0;
            mskNumClie.Text = null;
            txtCorreoClie.Text = null;
            txtNomClie.Focus();
        }
    }
}
