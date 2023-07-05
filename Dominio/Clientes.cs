using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public override string ToString()
        {
            return Cliente;
        }
    }
}
