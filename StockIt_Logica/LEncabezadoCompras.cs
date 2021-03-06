using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt_Logica
{
    public class LEncabezadoCompras
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public int ObtenerNumeroCompra(int idUsuario)
        {
            try
            {
                return WS.obtenerNumeroCompra(idUsuario);
            }
            catch (Exception)
            {
                return -2;
            }
        }

        //Ejecutar en acutalización o inserción
        public int InsertarEncabezadoCompra(EEncabezadoCompraProductos eEncabezadoCompraProductos)
        {
            try
            {
                return WS.insertarEncabezadoCompra(eEncabezadoCompraProductos.IdProveedor, eEncabezadoCompraProductos.Monto);
            }
            catch (Exception)
            {
                return -2;
            }
        }
    }
}
