using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class FacturaNegocio
    {
        public List<Factura> listarBasico(int mes, int anio, string consorcio)
        {
			try
			{
				List<Factura> listaFacturas = new List<Factura>();
				AccesoDatos acceso = new AccesoDatos();

				acceso.setearConsulta("Select F.Id, Proveedor, Precio, Numero, Descripcion, Aclaracion, F.Estado from Factura F, Consorcio C where Nombre = @consorcio and Mes = @mes and Anio = @anio and idConsorcio = C.Id and F.Activo = 1");
				acceso.setearParametro("@consorcio", consorcio);
                acceso.setearParametro("@mes", mes);
                acceso.setearParametro("@anio", anio);
                acceso.ejecutarLectura();

				while(acceso.Lector.Read())
				{
					Factura factura = new Factura();
					factura.Id = (int)acceso.Lector["Id"];
					factura.Proveedor = (string)acceso.Lector["Proveedor"];
					factura.Precio = (Decimal)acceso.Lector["Precio"];
					factura.Numero = (int)acceso.Lector["Numero"];
					factura.Descripcion = (string)acceso.Lector["Descripcion"];
                    factura.Aclaracion = (string)acceso.Lector["Aclaracion"];
					factura.Estado = (string)acceso.Lector["Estado"];

					listaFacturas.Add(factura);
                }

				acceso.cerrarConexion();
				return listaFacturas;
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
