using StockIt.CustomControls;
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
    public partial class frmModReservas : Form
    {
        public int ID_ENCABEZADO_RESERVA;
        public double TOTAL_RESERVA_GLOBAL;
        Utils utils = new Utils();
        ProductoVRCard[] productosVR;
        List<ECardProducto> eCardProductosList;
        List<EDetalleReservas> eDetalleReservasListActual = new List<EDetalleReservas>();
        ECliente[] eClientes;
        private double totalReserva; //Variable que almacena el total de la reserva (se asigna a lblTotalReserva)
        private bool tipoVista = true; //Variable que permite evaluar el modo de vista actual
        private string textoTTCambiarVista1 = "Haz clic para mostrar únicamente los productos agregados a la reserva";
        private string textoTTCambiarVista2 = "Haz clic para mostrar todos los productos disponibles";

        public frmModReservas()
        {
            InitializeComponent();
        }

        private void frmModReserva_Load(object sender, EventArgs e)
        {
            totalReserva = TOTAL_RESERVA_GLOBAL;
            ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
            cargarProductos();
            cargarClientes();
            ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
            ttActualizar.SetToolTip(btnActualizar, "Haz click para establecer los cambios a la reserva");
            ttLimpiar.SetToolTip(btnVolver, "Haz click para reestablecer los datos de la reserva");
            ttCancelar.SetToolTip(btnCancelar, "Haz click para ignorar los cambios y volver a las Reservas");
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Correo");

            foreach (var cliente in eClientes)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.ApellidoCliente, cliente.TelefonoCliente, cliente.CorreoCliente);
            }
            frmSeleccionarCliente.lblFormularioLlamada.Text = this.Name;
            frmSeleccionarCliente.dgvClientes.DataSource = dt;
            frmSeleccionarCliente.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Agregar validación de Fecha
            if (totalReserva <= 0 || lblIdCliente.Text == "" || txtCliente.Text == "")
            {
                if (totalReserva <= 0)
                {
                    utils.messageBoxCampoRequerido("Debes agregar productos a la reserva.");
                }
                else if (lblIdCliente.Text == "" || txtCliente.Text == "")
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar el cliente a quien\n le pertenece la reserva.");
                    btnSelCliente.Focus();
                }
                /* //Validación de fecha con el WS
                else if ()
                {

                }
                */
            }
            else
            {
                //Actualizar Reserva
                EEncabezadoReservas eEncabezadoReservas = new EEncabezadoReservas();
                eEncabezadoReservas.IdEncabezadoReserva = ID_ENCABEZADO_RESERVA;

                int conteoProductos = 0;
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        conteoProductos++;
                    }
                }

                //Obtenemos los productos que tienen un sub total
                List<EDetalleReservas> eDetallesReservasListNuevo = new List<EDetalleReservas>();
                int indexProducto = 0;
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        EDetalleReservas eDetalleReservas = new EDetalleReservas();
                        eDetalleReservas.IdProducto = int.Parse(productosVR[i].Name);
                        NumericUpDown objNUDCanReserva = (NumericUpDown)productosVR[i].Controls.Find("nudCanReserva", true).SingleOrDefault();
                        eDetalleReservas.Cantidad = ((int)objNUDCanReserva.Value);
                        eDetalleReservas.PrecioProducto = productosVR[i].PreProdPromedio;
                        eDetalleReservas.Monto = productosVR[i].SubTotal;
                        indexProducto++;
                        eDetallesReservasListNuevo.Add(eDetalleReservas);
                    }
                }

                int r = new LDetalleReservas().ActualizarDetalleReserva(eDetalleReservasListActual, eDetallesReservasListNuevo, eEncabezadoReservas);

                if (r > 0)
                {
                    utils.messageBoxOperacionExitosa("La reserva se actualizó satisfactoriamente.");
                }
                else if (r == -1)
                {
                    utils.messageBoxAlerta("No se pudo actualizar la reserva.");
                }
                else
                {
                    utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                }

                //Limpiamos el control FlowLayoutPanel
                flpListadoProductos.Controls.Clear();

                //Limpiamos el arreglo que contiene los Cards
                eCardProductosList.Clear();

                //Cargamos los productos nuevamente
                cargarProductos();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            //Volver a frmReservas
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion(
                "¿Estás seguro que deseas salir de la modificación de la Reserva?" +
                "\nTodos los cambios realizados que no se guardaron se descartarán.");
            if (dialogResult == DialogResult.Yes)
            {
                utils.setFormToPanelFormularioHijo(new frmReservas());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion(
                "¿Estás seguro que deseas cancelar la modificación de la Reserva?" +
                "\nTodos los cambios realizados se descartarán.");
            if (dialogResult == DialogResult.Yes)
            {
                //limpiarDatosReserva();
                eCardProductosList.Clear();
                flpListadoProductos.Controls.Clear();
                totalReserva = TOTAL_RESERVA_GLOBAL;
                cargarProductos();
            }
        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {
            tipoVista = false;
            cambiarVista();
            utils.filtrarCardsProductosReservas(productosVR, txtNomProd);
        }

        private void lklCambiarVista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cambiarVista();
        }

        #region Métodos creados
        private void cargarProductos()
        {
            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");

            eCardProductosList = new LProductos().SeleccionarProductosByIdUsuarioAndEstadoProducto(utils.getIdUsuario(), "A");
            eDetalleReservasListActual = new LDetalleReservas().SeleccionarDetalleReserva(ID_ENCABEZADO_RESERVA);

            if (eCardProductosList.Count > 0)
            {
                productosVR = new ProductoVRCard[eCardProductosList.Count];
                for (int i = 0; i < productosVR.Length; i++)
                {
                    productosVR[i] = new ProductoVRCard();
                    productosVR[i].Name = eCardProductosList[i].IdProducto.ToString();
                    productosVR[i].ImgProd = utils.byteArrayToImage(eCardProductosList[i].Img);
                    productosVR[i].NomProd = eCardProductosList[i].NombreProducto;
                    productosVR[i].CatProd = eCardProductosList[i].Categoria;
                    productosVR[i].CanProd = eCardProductosList[i].Existencia;
                    productosVR[i].PreProd = eCardProductosList[i].Precio;
                    productosVR[i].CanProdN = eCardProductosList[i].UnidadesNuevas;
                    productosVR[i].PreProdN = eCardProductosList[i].PrecioNuevo;
                    productosVR[i].PreProdR = 0.0;
                    productosVR[i].CanProdR = 0;
                    productosVR[i].PreProdPromedio = 0.0;
                    productosVR[i].SubTotalR = 0.0;
                    //Asignamos los valores del producto reservado
                    for (int j = 0; j < eDetalleReservasListActual.Count; j++)
                    {
                        if (eCardProductosList[i].IdProducto == eDetalleReservasListActual[j].IdProducto)
                        {
                            productosVR[i].PreProdR = eDetalleReservasListActual[j].PrecioProducto;
                            productosVR[i].CanProdR = eDetalleReservasListActual[j].Cantidad;
                            productosVR[i].SubTotalR = eDetalleReservasListActual[j].Monto;
                            j = eDetalleReservasListActual.Count;//Si encontró un ID de producto igual, hacemos que finalice el bucle
                        }
                    }
                    productosVR[i].SubTotal = productosVR[i].SubTotalR;

                    //Creación de btnEditar
                    productosVR[i].NudCanReservaProp = new NumericUpDown();
                    productosVR[i].NudCanReservaProp.Value = productosVR[i].CanProdR;
                    productosVR[i].ValueChangedNUDCanReserva += new EventHandler(nudCanProd_ValueChanged);

                    void nudCanProd_ValueChanged(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProductoVRCard productoVRCardItem = ((ProductoVRCard)sender);
                        //Obtenemos el control nudCanReserva
                        NumericUpDown objNUDCanReserva = (NumericUpDown)productoVRCardItem.Controls.Find("nudCanReserva", true).SingleOrDefault();

                        //Realizamos las operaciones necesarias para obtener el SubTotal y se actualiza el Total
                        int canProdReservar = ((int)objNUDCanReserva.Value);
                        double subTotalAntiguo = productoVRCardItem.SubTotal;
                        double subTotalNuevo;
                        int existenciasActuales = productoVRCardItem.CanProd;
                        double precioActual = productoVRCardItem.PreProd;
                        int existenciasNuevas = productoVRCardItem.CanProdN;
                        double precioNuevo = productoVRCardItem.PreProdN;
                        int existenciasReserva = productoVRCardItem.CanProdR;
                        double precioReserva = productoVRCardItem.SubTotalR/productoVRCardItem.CanProdR;
                        int totalExistencias = (existenciasActuales + existenciasNuevas + existenciasReserva);
                        double precioPromedio = 0.0;

                        if (canProdReservar <= totalExistencias)
                        {
                            #region Calculo de precio promedio
                            int canProdReservarExtsNuevas = 1;

                            if (existenciasReserva > 0)
                            {
                                if (canProdReservar <= existenciasReserva)
                                {
                                    //Cálculo si solo se están utilizando las existenciasReserva
                                    subTotalNuevo = (canProdReservar * precioReserva);
                                    precioPromedio = precioReserva;
                                }
                                else if (canProdReservar > existenciasReserva && canProdReservar <= (existenciasReserva + existenciasActuales))
                                {
                                    //Cálculo si solo se están utilizando las existenciasReserva + existenciasActuales
                                    canProdReservarExtsNuevas = (canProdReservar - existenciasReserva);
                                    double calculoReserva = (existenciasReserva * precioReserva);
                                    double calculoActual = (canProdReservarExtsNuevas * precioActual);
                                    precioPromedio = ((calculoReserva + calculoActual) / canProdReservar);
                                    subTotalNuevo = (canProdReservar * precioPromedio);
                                }
                                else
                                {
                                    //Cálculo si se están utilizando las existenciasReserva + existenciasActuales + existenciasNuevas
                                    canProdReservarExtsNuevas = (canProdReservar - existenciasReserva - existenciasActuales);
                                    //Obtenemos el nuevo precio
                                    double calculoReserva = (existenciasReserva * precioReserva);
                                    double calculoActual = (existenciasActuales * precioActual);
                                    double calculoNuevo = (canProdReservarExtsNuevas * precioNuevo);
                                    precioPromedio = ((calculoReserva + calculoActual + calculoNuevo) / canProdReservar);
                                    subTotalNuevo = (canProdReservar * precioPromedio);
                                }
                            }
                            else
                            {
                                if (canProdReservar <= existenciasActuales)
                                {
                                    //Cálculo si solo se están utilizando las existenciasActuales
                                    subTotalNuevo = (canProdReservar * precioActual);
                                    precioPromedio = precioActual;
                                }
                                else
                                {
                                    //Cálculo si solo se están utilizando las existenciasActuales + existenciasNuevas
                                    canProdReservarExtsNuevas = (canProdReservar - existenciasActuales);
                                    //Obtenemos el nuevo precio
                                    double calculoActual = (existenciasActuales * precioActual);
                                    double calculoNuevo = (canProdReservarExtsNuevas * precioNuevo);
                                    precioPromedio = ((calculoActual + calculoNuevo) / canProdReservar);
                                    subTotalNuevo = (canProdReservar * precioPromedio);
                                }
                            }

                            //Le asiganmos el valor al PrecioPromedio, que es el que se debe guardar en la BD
                            productoVRCardItem.PreProdPromedio = precioPromedio;

                            #endregion

                            //Detectamos la opción seleccionada del numericUpDown
                            if (subTotalAntiguo <= subTotalNuevo)
                            {
                                //Opción de Incremento
                                if (subTotalAntiguo < subTotalNuevo)
                                {
                                    if (existenciasReserva > 0)
                                    {
                                        //Si la cantidad a reservar es mayor que las existencias reservadas
                                        if (canProdReservar > existenciasReserva)
                                        {
                                            if (canProdReservar < (existenciasReserva + existenciasActuales))
                                            {
                                                int cantProdReservarAntigua = (canProdReservar - 1);
                                                double calculoReserva = (existenciasReserva * precioReserva);
                                                double calculoActual = ((canProdReservarExtsNuevas - 1) * precioActual);
                                                double precioPromedioAntiguo = ((calculoReserva + calculoActual) / cantProdReservarAntigua);

                                                double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                totalReserva = totalReserva - restar;
                                                double sumar = (canProdReservar * precioPromedio);
                                                totalReserva = totalReserva + sumar;
                                            }
                                            else
                                            {
                                                if (canProdReservar > (existenciasReserva + existenciasActuales))
                                                {
                                                    int cantProdReservarAntigua = (canProdReservar - 1);
                                                    double calculoReserva = (existenciasReserva * precioReserva);
                                                    double calculoActual = (existenciasActuales * precioActual);
                                                    double calculoNuevo = ((canProdReservarExtsNuevas - 1) * precioNuevo);
                                                    double precioPromedioAntiguo = ((calculoReserva + calculoActual + calculoNuevo) / cantProdReservarAntigua);

                                                    double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                    totalReserva = totalReserva - restar;
                                                    double sumar = (canProdReservar * precioPromedio);
                                                    totalReserva = totalReserva + sumar;
                                                }
                                                else
                                                {
                                                    totalReserva += precioPromedio;
                                                }
                                            }

                                            
                                        }
                                        else
                                        {
                                            totalReserva += precioPromedio;
                                        }
                                    }
                                    else
                                    {
                                        if (canProdReservar > existenciasActuales)
                                        {
                                            int cantProdReservarAntigua = (canProdReservar - 1);
                                            double calculoActual = (existenciasActuales * precioActual);
                                            double calculoNuevo = ((canProdReservarExtsNuevas - 1) * precioNuevo);
                                            double precioPromedioAntiguo = ((calculoActual + calculoNuevo) / cantProdReservarAntigua);

                                            double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                            totalReserva = totalReserva - restar;
                                            double sumar = (canProdReservar * precioPromedio);
                                            totalReserva = totalReserva + sumar;
                                        }
                                        else
                                        {
                                            totalReserva += precioPromedio;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Opción de decremento
                                if (canProdReservar >= existenciasReserva && existenciasReserva > 0)
                                {
                                    //Si HAY existencias reservadas

                                    //Disminución del subtotal y total si la cantidad a reservar es igual a la que estaba definida en la Reserva original
                                    if (canProdReservar == existenciasReserva && existenciasReserva > 0)
                                    {
                                        /*Para obtener el precioPromedioAntiguo sumamos los productos de existenciaReserva con precioReserva, y,
                                         * existenciasActuales con precioActual, el resultado lo dividimos entra la cantidad a reservar + 1
                                         */
                                        int cantProdReservarAntigua = (canProdReservar + 1);
                                        double calculoReserva = (existenciasReserva * precioReserva);
                                        double calculoActual = (canProdReservarExtsNuevas * precioActual);
                                        double precioPromedioAntiguo = ((calculoReserva + calculoActual) / cantProdReservarAntigua);

                                        //Restamos el subtotal antiguo al totalReserva
                                        double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                        totalReserva = totalReserva - restar;
                                        //Adicionamos el subtotal nuevo al totalReserva (utilizando el precioPromedio obtenido al principio)
                                        double sumar = (canProdReservar * precioPromedio);
                                        totalReserva = totalReserva + sumar;
                                    }
                                    else
                                    {
                                        //Hacer cálculo con 3 precios

                                        /*
                                        * Si la cantidad a reservar es igual a las existencias actual, asignamos el precio promedio
                                        * haciendo un promedio tomando en cuenta 1 producto de las existencias nuevas
                                        */
                                        if (canProdReservar >= (existenciasReserva + existenciasActuales))
                                        {
                                            if (canProdReservar == (existenciasReserva + existenciasActuales))
                                            {
                                                int cantProdReservarAntigua = (canProdReservar + 1);
                                                double calculoReserva = (existenciasReserva * precioReserva);
                                                double calculoActual = (existenciasActuales * precioActual);
                                                double calculoNuevo = (1 * precioNuevo);
                                                double precioPromedioAntiguo = (calculoReserva + calculoActual + calculoNuevo) / cantProdReservarAntigua;

                                                double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                totalReserva = totalReserva - restar;
                                                double sumar = (canProdReservar * precioPromedio);
                                                totalReserva = totalReserva + sumar;
                                            }
                                            else
                                            {
                                                int cantProdReservarAntigua = (canProdReservar + 1);
                                                double calculoReserva = (existenciasReserva * precioReserva);
                                                double calculoActual = (existenciasActuales * precioActual);
                                                double calculoNuevo = ((canProdReservarExtsNuevas + 1) * precioNuevo);
                                                double precioPromedioAntiguo = ((calculoReserva + calculoActual + calculoNuevo) / cantProdReservarAntigua);

                                                double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                totalReserva = totalReserva - restar;
                                                double sumar = (canProdReservar * precioPromedio);
                                                totalReserva = totalReserva + sumar;
                                            }
                                        }
                                        else
                                        {
                                            totalReserva -= precioPromedio;
                                        }
                                    }
                                }
                                else
                                {
                                    if (existenciasReserva > 0)
                                    {
                                        //Si hay existencias reservadas
                                        if (canProdReservar == existenciasReserva)
                                        {
                                            /*Para obtener el precioPromedioAntiguo sumamos los productos de existenciaReserva con precioReserva, y,
                                            * existenciasActuales con precioActual, el resultado lo dividimos entra la cantidad a reservar + 1
                                            */
                                            int cantProdReservarAntigua = (canProdReservar + 1);
                                            double calculoReserva = (existenciasReserva * precioReserva);
                                            double precioPromedioAntiguo = (calculoReserva / cantProdReservarAntigua);

                                            //Restamos el subtotal antiguo al totalReserva
                                            double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                            totalReserva = totalReserva - restar;
                                            //Adicionamos el subtotal nuevo al totalReserva (utilizando el precioPromedio obtenido al principio)
                                            double sumar = (canProdReservar * precioPromedio);
                                            totalReserva = totalReserva + sumar;
                                        }
                                        else
                                        {
                                            totalReserva -= precioPromedio;
                                        }
                                    }
                                    else
                                    {
                                        //Si NO hay existencias reservadas
                                        /*
                                        * Si la cantidad a reservar es igual a las existencias actual, asignamos el precio promedio
                                        * haciendo un promedio tomando en cuenta 1 producto de las existencias nuevas
                                        */
                                        if (canProdReservar >= existenciasActuales)
                                        {
                                            if (canProdReservar == existenciasActuales)
                                            {
                                                int cantProdReservarAntigua = (canProdReservar + 1);
                                                double calculoActual = (existenciasActuales * precioActual);
                                                double calculoNuevo = ((canProdReservarExtsNuevas) * precioNuevo);
                                                double precioPromedioAntiguo = ((calculoActual + calculoNuevo) / cantProdReservarAntigua);

                                                double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                totalReserva = totalReserva - restar;
                                                double sumar = (canProdReservar * precioPromedio);
                                                totalReserva = totalReserva + sumar;
                                            }
                                            else
                                            {
                                                int cantProdReservarAntigua = (canProdReservar + 1);
                                                double calculoActual = (existenciasActuales * precioActual);
                                                double calculoNuevo = ((canProdReservarExtsNuevas + 1) * precioNuevo);
                                                double precioPromedioAntiguo = ((calculoActual + calculoNuevo) / cantProdReservarAntigua);

                                                double restar = (cantProdReservarAntigua * precioPromedioAntiguo);
                                                totalReserva = totalReserva - restar;
                                                double sumar = (canProdReservar * precioPromedio);
                                                totalReserva = totalReserva + sumar;
                                            }
                                        }
                                        else
                                        {
                                            totalReserva -= precioPromedio;
                                        }
                                    }
                                }


                            }

                            productoVRCardItem.SubTotal = subTotalNuevo;
                            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
                        }
                        else
                        {
                            objNUDCanReserva.Value = totalExistencias;
                            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
                        }

                        //Evaluamos el subtotal para cambiar el color del Fondo y Letra del CustomControl
                        if (((int)productoVRCardItem.SubTotal) > 0)
                        {
                            productoVRCardItem.BackColor = Color.FromArgb(95, 189, 89);
                            productoVRCardItem.ForeColor = Color.White;
                        }
                        else
                        {
                            if (tipoVista == false)
                            {
                                productoVRCardItem.Hide();
                            }
                            productoVRCardItem.BackColor = Color.White;
                            productoVRCardItem.ForeColor = Color.Black;
                        }
                    }

                    //Asignamos el valor del NumericUpDown con la cantidad de producto que se ha reservado
                    productosVR[i].LoadProductoVRCard += new EventHandler(productoVRCard_Load);

                    void productoVRCard_Load(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProductoVRCard productoVRCardItem = ((ProductoVRCard)sender);
                        //Obtenemos el control nudCanReserva
                        NumericUpDown objNUDCanReserva = (NumericUpDown)productoVRCardItem.Controls.Find("nudCanReserva", true).SingleOrDefault();
                        objNUDCanReserva.Value = productoVRCardItem.CanProdR;
                    }

                        //Evaluamos el subtotal para cambiar el color del Fondo y Letra del CustomControl
                        if (((int)productosVR[i].SubTotal) > 0)
                    {
                        productosVR[i].BackColor = Color.FromArgb(95, 189, 89);
                        productosVR[i].ForeColor = Color.White;
                    }
                    else
                    {
                        productosVR[i].BackColor = Color.White;
                        productosVR[i].ForeColor = Color.Black;
                    }

                    //Agregamos el ProductoCard al FlowLAyoutPanel
                    flpListadoProductos.Controls.Add(productosVR[i]);
                }
            }
        }

        private void cargarClientes()
        {
            eClientes = new ECliente[10];
            for (int i = 0; i < eClientes.Length; i++)
            {
                eClientes[i] = new ECliente();
                eClientes[i].IdCliente = i + 1;
                eClientes[i].IdUsuario = 1;
                eClientes[i].NombreCliente = "Nombre " + (i + 1).ToString();
                eClientes[i].ApellidoCliente = "Apellido 1" + (i + 1).ToString();
                eClientes[i].SexoCliente = "A";
                eClientes[i].TelefonoCliente = "7022-8563";
                eClientes[i].CorreoCliente = "correo" + (i + 1).ToString() + "@gmail.com";
                eClientes[i].EstadoCliente = "A";
            }
        }

        //Reestablecer los datos de la reserva
        private void limpiarDatosReserva()
        {
            for (int i = 0; i < productosVR.Length; i++)
            {
                if (productosVR[i].SubTotal > 0)
                {
                    NumericUpDown objNUDCanReserva = (NumericUpDown)productosVR[i].Controls.Find("nudCanReserva", true).SingleOrDefault();
                    objNUDCanReserva.Value = 0;
                    productosVR[i].SubTotal = 0.0;
                    productosVR[i].BackColor = Color.White;
                    productosVR[i].ForeColor = Color.Black;
                }

            }
            txtCliente.Text = null;
            lblIdCliente.Text = null;
            txtComentarios.Text = null;
            totalReserva = 0.0;
            lblTotalReserva.Text = "$" + totalReserva.ToString("0.00");
            txtNomProd.Text = null;

            tipoVista = false;
            cambiarVista();
        }

        //Método que permite mostrar los productos reservados o todos los productos
        private void cambiarVista()
        {
            if (tipoVista == true)
            {
                tipoVista = false;
                ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista2);
                //Mostrar solo productos con subtotal diferente de 0
                for (int i = 0; i < productosVR.Length; i++)
                {
                    if (productosVR[i].SubTotal > 0.0)
                    {
                        productosVR[i].Show();
                    }
                    else
                    {
                        productosVR[i].Hide();
                    }
                }
            }
            else if (tipoVista == false)
            {
                tipoVista = true;
                ttCambiarVista.SetToolTip(lklCambiarVista, textoTTCambiarVista1);
                //Mostrar todos los productos
                for (int i = 0; i < productosVR.Length; i++)
                {
                    productosVR[i].Show();
                }
            }
        }

        #endregion
    }
}
