using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class VentasItems
    {
        public int Id { get; set; }
        public Ventas Venta { get; set; }
        public Productos Producto { get; set; }
        public double PrecioUnitario { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }
    }
}
