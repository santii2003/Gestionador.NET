using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public Articulo() { }
        
        public int codArticulo;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Elemento Marca { get; set; }

        public Elemento Categoria { get; set; }
        public int Precio { get; set; }
    }
}
