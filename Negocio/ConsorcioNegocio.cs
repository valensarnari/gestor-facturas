using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ConsorcioNegocio
    {
        public List<Consorcio> listar()
        {
            try
            {
                List<Consorcio> listaConsorcios = new List<Consorcio>();
                AccesoDatos acceso = new AccesoDatos();

                acceso.setearConsulta("Select Id, Nombre from Consorcio");
                acceso.ejecutarLectura();

                while(acceso.Lector.Read())
                {
                    Consorcio consorcio = new Consorcio();
                    consorcio.Id = (int)acceso.Lector["Id"];
                    consorcio.Nombre = (string)acceso.Lector["Nombre"];

                    listaConsorcios.Add(consorcio);
                }

                acceso.cerrarConexion();
                return listaConsorcios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
