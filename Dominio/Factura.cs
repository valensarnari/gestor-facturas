using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public string Proveedor { get; set; }
        public Decimal Precio { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }
        public string Aclaracion { get; set; }
        public string Estado { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public Consorcio Consorcio { get; set; }
        public int Activo { get; set; }
    }
}
