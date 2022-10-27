using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using producto; 

namespace negocios
{
    public class CamarasNegocio
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
                //comando.CommandText = "select Nombre, Descripcion, Codigo, ImagenUrl from ARTICULOS";
                comando.CommandText = "select a.Nombre, a.Descripcion,  Codigo, ImagenUrl, Precio,  m.Descripcion as Marca, c.Descripcion as Categoria,  IdMarca, IdCategoria, a.Id from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Camaras aux = new Camaras();
                    aux.Id = (int)lector["Id"]; 
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                   

                    aux.Marcas = new Producto();
                    aux.Marcas.Descripcion = (string)lector["Marca"];
                    aux.Marcas.Id = (int)lector["IdMarca"];

                    aux.Categoria = new categorias();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];


                    aux.Precio = (decimal)lector["Precio"];




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

        public void modificar(Camaras camara)
        {
            AccesoDatos datos = new AccesoDatos(); 
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.agregarParametro("@Codigo", camara.Codigo);
                datos.agregarParametro("@Nombre", camara.Nombre);
                datos.agregarParametro("@Descripcion", camara.Descripcion);
                datos.agregarParametro("IdMarca", camara.Marcas.Id);
                datos.agregarParametro("@IdCategoria", camara.Categoria.Id);
                datos.agregarParametro("@ImagenUrl", camara.ImagenUrl);
                datos.agregarParametro("@Precio", camara.Precio);
                datos.agregarParametro("@Id", camara.Id);

                datos.ejecutarAccion(); 


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

        public void eliminarCam(int id)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = " + id);
                datos.ejecutarAccion();


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

        public void agregar (Camaras nuevaCam)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand(); 

            try
            {

                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                comando.CommandText = "insert into ARTICULOS Values ('"+ nuevaCam.Codigo + "', '"+nuevaCam.Nombre+"', '"+nuevaCam.Descripcion+"', @IdMarca, @IdCategoria, '"+nuevaCam.ImagenUrl+"', '"+nuevaCam.Precio+"')";
                comando.Parameters.AddWithValue("@IdMarca", nuevaCam.Marcas.Id);
                comando.Parameters.AddWithValue("@IdCategoria", nuevaCam.Categoria.Id); 


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
