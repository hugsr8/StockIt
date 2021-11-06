﻿using StockIt.CustomControls;
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
    public partial class frmReservas : Form
    {
        Utils utils = new Utils();
        ReservaCard[] reservas;
        List<ECardReserva> eCardReservasList;
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            cargarReservas();
        }

        private void cargarReservas()
        {
            eCardReservasList = new LEncabezadoReservas().SeleccionarReservasActivas(utils.getIdUsuario());

            if (eCardReservasList.Count > 0)
            {
                reservas = new ReservaCard[eCardReservasList.Count];
                for (int i = 0; i < reservas.Length; i++)
                {
                    reservas[i] = new ReservaCard();
                    reservas[i].Name = eCardReservasList[i].IdEncabezadoReserva.ToString();
                    reservas[i].NomClie = eCardReservasList[i].NombreCliente + " " + eCardReservasList[i].ApellidoCliente;
                    reservas[i].TelClie = eCardReservasList[i].TelefonoCliente;
                    reservas[i].FechaReserva = eCardReservasList[i].FechaReserva;
                    reservas[i].FechaPromesaEntrega = eCardReservasList[i].FechaPromesaEntrega;
                    reservas[i].MontoReserva = eCardReservasList[i].MontoEncabezadoReserva;

                    //Creación de btnEditar
                    reservas[i].BtnEditarProp = new Button();
                    reservas[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                    void btnEditar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ReservaCard reservaCardItem = ((ReservaCard)sender);

                        utils.setFormToPanelFormularioHijo(new frmModReservas());
                    }

                    //Creación de btnFacturar
                    reservas[i].BtnFacturarProp = new Button();
                    reservas[i].ButtonClickFacturar += new EventHandler(btnFacturar_ButtonClick);

                    void btnFacturar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ReservaCard reservaCardItem = ((ReservaCard)sender);

                        utils.messageBoxOperacionExitosa("Facturando reserva " + reservaCardItem.Name);
                    }

                    //Creación de btnCancelar
                    reservas[i].BtnCancelarProp = new Button();
                    reservas[i].ButtonClickCancelar += new EventHandler(btnCancelar_ButtonClick);

                    void btnCancelar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ReservaCard reservaCardItem = ((ReservaCard)sender);

                        DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas finalizar la reserva del cliente" +
                            " \"" + reservaCardItem.NomClie + "\"?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            reservaCardItem.Dispose();
                        }
                    }

                    //Agregamos el ProductoCard al FlowLAyoutPanel
                    flpListadoReservas.Controls.Add(reservas[i]);
                }
            }
        }

        private void txtNomCliente_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsReservas(reservas, txtNomCliente);
        }
    }
}
