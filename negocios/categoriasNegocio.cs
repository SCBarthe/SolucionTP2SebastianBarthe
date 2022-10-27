using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using producto; 

namespace negocios
{
    public class categoriasNegocio
    {
        public List<categorias> listado()
        {
            List<categorias> lista = new List<categorias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    //  lista.Add(new Producto((int)datos.Lector["Id"], (string)datos.Lector["Descripcion"])); 

                    categorias aux = new categorias();
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
