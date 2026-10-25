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

        public int Id { get; set; }
        public string CodigoArticulo { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Elemento Marca { get; set; }
        public Elemento Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public float Precio { get; set; }
    }
}
