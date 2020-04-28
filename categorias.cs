using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace articulos
{
    public class categorias
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }

       
    }
}
