﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockIt_Entidades;

namespace StockIt_Logica
{
    public class LEncabezadoFacturacion
    {
        WSStockIt.WebServiceSI WS = new WSStockIt.WebServiceSI();

        public EEncabezadoFacturacion SeleccionarEncabezadoFacturacionByIdEncabezadoFacturacion(int idEncabezadoFacturacion)
        {
            EEncabezadoFacturacion eEncabezadoFacturacion = new EEncabezadoFacturacion();
            try
            {
                DataSet ds = WS.seleccionarEncabezadoFacturacionByIdEncabezadoFacturacion(idEncabezadoFacturacion);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        eEncabezadoFacturacion.IdEncabezadoFacturacion = int.Parse(row["ID_ENCABEZADO_FACTURACION"].ToString());
                        eEncabezadoFacturacion.Nombres = row["NOMBRE_USUARIO"].ToString();
                        eEncabezadoFacturacion.Apellidos = row["APELLIDO_USUARIO"].ToString();
                        eEncabezadoFacturacion.NombreEmpresa = row["NOMBRE_EMPRESA"].ToString();
                        eEncabezadoFacturacion.NombreCliente = row["NOMBRE_CLIENTE"].ToString();
                        eEncabezadoFacturacion.ApellidoCliente = row["APELLIDO_CLIENTE"].ToString();
                        eEncabezadoFacturacion.FechaFacturacion = DateTime.Parse(row["FECHA_FACTURACION"].ToString());
                        eEncabezadoFacturacion.MontoEncabezadoFacturacion = double.Parse(row["MONTO_ENCABEZADO_FACTURACION"].ToString());
                    }
                }

                return eEncabezadoFacturacion;
            }
            catch (Exception)
            {
                return eEncabezadoFacturacion;
            }
        }
    }
}