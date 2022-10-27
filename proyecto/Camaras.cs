using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producto
{
    public class Camaras
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string ImagenUrl { get; set; }

        public Producto Marcas {get; set; }

        public categorias Categoria { get; set;  }

        





    }
}
