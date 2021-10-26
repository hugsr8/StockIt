﻿using StockIt.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    class Utils
    {
        //Abre un formulario en el Panel "panelFormularioHijo" del Form "frmPrincipal"
        public void setFormToPanelFormularioHijo(Form form)
        {
            try
            {
                Form objFrmPrincipal = Application.OpenForms["frmPrincipal"];

                if (objFrmPrincipal != null)
                {
                    Label objlblFormOpen = (Label)objFrmPrincipal.Controls.Find("lblFormOpen", true).SingleOrDefault();
                    Form frmOpen = Application.OpenForms[objlblFormOpen.Text];

                    if (frmOpen != null)
                    {
                        frmOpen.Close();
                    }

                    Panel objPanelFormularioHijo = (Panel)objFrmPrincipal.Controls.Find("panelFormularioHijo", true).SingleOrDefault();
                    Form formularioHijo = form;
                    formularioHijo.TopLevel = false;
                    formularioHijo.FormBorderStyle = FormBorderStyle.None;
                    formularioHijo.Dock = DockStyle.Fill;
                    objPanelFormularioHijo.Controls.Add(formularioHijo);
                    objPanelFormularioHijo.Tag = formularioHijo;
                    formularioHijo.BringToFront();
                    formularioHijo.Show();
                }
            }
            catch (Exception)
            {
            }
        }

        //Cierra el formulario que posee como nombre el valor de "nombreForm", si este se encuentra abierto
        public void closeOpenFormPanelFormularioHijo(string nombreForm)
        {
            try
            {
                Form formOpen = Application.OpenForms[nombreForm];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        #region Métodos para filtros con Custom Controls

        //Filtro de Card en pantalla de AgregarReservas
        public void filtrarCardsProductosReservas(ProductoVRCard[] productosVR, TextBox textBox)
        {
            for (int i = 0; i < productosVR.Length; i++)
            {
                if (textBox.Text != "")
                {
                    string valor = productosVR[i].NomProd.Trim().ToUpper();
                    string valorBusqueda = textBox.Text.Trim().ToUpper();
                    if (valor.Contains(valorBusqueda))
                    {
                        productosVR[i].Show();
                    }
                    else
                    {
                        productosVR[i].Hide();
                    }
                }
                else
                {
                    productosVR[i].Show();
                }
            }
        }

        //Filtro de Card en pantalla de Proveedores
        public void filtrarCardsProveedores(ProveedorCard[] proveedores, TextBox textBox)
        {
            for (int i = 0; i < proveedores.Length; i++)
            {
                if (textBox.Text != "")
                {
                    string valor = proveedores[i].NomProveedor.Trim().ToUpper();
                    string valorBusqueda = textBox.Text.Trim().ToUpper();
                    if (valor.Contains(valorBusqueda))
                    {
                        proveedores[i].Show();
                    }
                    else
                    {
                        proveedores[i].Hide();
                    }
                }
                else
                {
                    proveedores[i].Show();
                }
            }
        }

        //Filtro de Card en pantalla de Productos
        public void filtrarCardsProductos(ProductoCard[] productos, TextBox textBox)
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (textBox.Text != "")
                {
                    string valor = productos[i].NomProd.Trim().ToUpper();
                    string valorBusqueda = textBox.Text.Trim().ToUpper();
                    if (valor.Contains(valorBusqueda))
                    {
                        productos[i].Show();
                    }
                    else
                    {
                        productos[i].Hide();
                    }
                }
                else
                {
                    productos[i].Show();
                }
            }
        }

        //Filtro de Card en pantalla de Clientes
        public void filtrarCardsClientes(ClienteCard[] clientes, TextBox textBox)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (textBox.Text != "")
                {
                    string valor = clientes[i].NomClie.Trim().ToUpper();
                    string valorBusqueda = textBox.Text.Trim().ToUpper();
                    if (valor.Contains(valorBusqueda))
                    {
                        clientes[i].Show();
                    }
                    else
                    {
                        clientes[i].Hide();
                    }
                }
                else
                {
                    clientes[i].Show();
                }
            }
        }

        #endregion

        #region Métodos para validaciones
        public bool validarEmail(string email)
        {
            bool r;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,5})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                r = true;
            }
            else
            {
                r = false;
            }

            return r;
        }


        /* Valida que la contraseña contenga:
         * 8 o más caracteres,
         * al menos un número digito,
         * al menos una letra minúscula,
         * al menos una letra mayúscula,
         * al menos un carácter especial: !*@#$%^&+=
         */
        public bool validarPassword(string password)
        {
            bool r;

            Regex regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");
            Match match = regex.Match(password);
            if (match.Success)
            {
                r = true;
            }
            else
            {
                r = false;
            }

            return r;
        }

        #endregion

        #region Métodos para Messagebox

        //MessageBox Alerta
        public void messageBoxAlerta(string mensaje)
        {
            MessageBox.Show(mensaje, "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Get Messagebox "Cancelar Operación"
        public DialogResult getMessageBoxCancelarOperacion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Cancelar operación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        //MessageBox de "Dato Requerido"
        public void messageBoxCampoRequerido(string mensaje)
        {
            MessageBox.Show(mensaje, "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //MessageBox de "Formato incorrecto"
        public void messageBoxFormatoIncorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Formato incorrecto",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //MessageBox de "Operación exitosa"
        public void messageBoxOperacionExitosa(string mensaje)
        {
            MessageBox.Show(mensaje, "Operación exitosa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
