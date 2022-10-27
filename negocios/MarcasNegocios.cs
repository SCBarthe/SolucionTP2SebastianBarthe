using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using negocios;
using producto; 

namespace negocios
{
    public class MarcasNegocios
    {

        public List<Producto> listado()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    //  lista.Add(new Producto((int)datos.Lector["Id"], (string)datos.Lector["Descripcion"])); 

                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux); 


                }


                return lista; 
            }
            catch (Exception ex)
            {

                throw ex; 

            }
            finally
            {
                datos.cerrarConexion(); 
            }
        }



    }
}
