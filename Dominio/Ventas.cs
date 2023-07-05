using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio
{
    public class Ventas
    {
        [DisplayName("Código Venta")]
        public int Id { get; set; }
        public Clientes Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
    }
}
