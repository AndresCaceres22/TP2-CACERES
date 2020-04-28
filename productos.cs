using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace articulos
{
    public class productos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public marcas marca { get; set; }
        public categorias categoria { get; set; }
        public string imagenurl { get; set; }
        public decimal precio { get; set; }


    }
}
