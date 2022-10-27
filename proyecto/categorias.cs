using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace producto 
{
   public class categorias
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        


        public categorias(int id, string descripcion)
        {
            Id = id;

            Descripcion = descripcion;

            
        }

        public categorias() { }

        public override string ToString()
        {
            return Descripcion;
        }

        
        
       



    }
}
