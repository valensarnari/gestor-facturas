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
		public void modificar(Factura fact)
		{
            AccesoDatos acceso = new AccesoDatos();

            try
			{
				acceso.setearConsulta("Update Factura set Proveedor = @Proveedor, Precio = @Precio, Numero = @Numero, Descripcion = @Descripcion, Aclaracion = @Aclaracion, Estado = @Estado, Mes = @Mes, Anio = @Anio, idConsorcio = @idConsorcio where Id = @Id");
				acceso.setearParametro("@Proveedor", fact.Proveedor);
                acceso.setearParametro("@Precio", fact.Precio);
                acceso.setearParametro("@Numero", fact.Numero);
                acceso.setearParametro("@Descripcion", fact.Descripcion);
                acceso.setearParametro("@Aclaracion", fact.Aclaracion);
                acceso.setearParametro("@Estado", fact.Estado);
                acceso.setearParametro("@Mes", fact.Mes);
                acceso.setearParametro("@Anio", fact.Anio);
                acceso.setearParametro("@idConsorcio", fact.Consorcio.Id);
                acceso.setearParametro("@Id", fact.Id);
				acceso.ejecutarAccion();

            }
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
                acceso.cerrarConexion();
            }
		}
		public void agregar(Factura fact)
		{
			try
			{
				AccesoDatos acceso = new AccesoDatos();

				acceso.setearConsulta("Insert into Factura (Proveedor, Precio, Numero, Descripcion, Aclaracion, Estado, Mes, Anio, idConsorcio) values (@Proveedor, @Precio, @Numero, @Descripcion, @Aclaracion, @Estado, @Mes, @Anio, @idConsorcio)");
				acceso.setearParametro("@Proveedor", fact.Proveedor);
                acceso.setearParametro("@Precio", fact.Precio);
                acceso.setearParametro("@Numero", fact.Numero);
                acceso.setearParametro("@Descripcion", fact.Descripcion);
                acceso.setearParametro("@Aclaracion", fact.Aclaracion);
                acceso.setearParametro("@Estado", fact.Estado);
                acceso.setearParametro("@Mes", fact.Mes);
                acceso.setearParametro("@Anio", fact.Anio);
                acceso.setearParametro("@idConsorcio", fact.Consorcio.Id);
				acceso.ejecutarAccion();

				acceso.cerrarConexion();
            }
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void eliminar(int id)
		{
			try
			{
				AccesoDatos acceso = new AccesoDatos();

				acceso.setearConsulta("Update Factura set Activo = 0 where Id = @Id");
				acceso.setearParametro("Id", id);
				acceso.ejecutarAccion();

				acceso.cerrarConexion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
    }
}
