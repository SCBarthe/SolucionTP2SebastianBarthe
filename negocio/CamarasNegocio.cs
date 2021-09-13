using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using producto; 

namespace TP2SebastianBarthe
{
    class CamarasNegocio
    {

        public List<Camaras> listado() 
        {
            List<Camaras> lista = new List<Camaras>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector; 

           
            try
            {

                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, Descripcion, Codigo, ImagenUrl from ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Camaras aux = new Camaras();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"]; 


                    lista.Add(aux); 

                }


                conexion.Close(); 

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
             
        }

        public void agregar (Camaras nuevaCam)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand(); 

            try
            {

                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                comando.CommandText = "insert into ARTICULOS Values ('"+ nuevaCam.Codigo + "', '"+nuevaCam.Nombre+"', '"+nuevaCam.Descripcion+"', '1', '1', '"+nuevaCam.ImagenUrl+"', "+nuevaCam.Precio+") ";

                conexion.Open();
                comando.ExecuteNonQuery(); 

            }
            catch (Exception ex)
            {
                throw ex; 
            }
            finally
            {
                conexion.Close(); 
            }


        }


    }
}
