using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producto 
{
    public class Producto
    {

        public int Id { get; set; }

        public string Descripcion { get; set;}


        public Producto (int id, string descripcion)
        {
            Id = id;

            Descripcion = descripcion; 
        }




    }
}
