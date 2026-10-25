using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient; 



namespace negocio
{
    public class ArticuloNegocio
    {
        private SqlDataReader lector;
        public List<Articulo> listar() {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos acceso = new AccesoDatos();

            //lógica 
            try
            { 
                acceso.setearConsulta("");
                acceso.ejecutarConsulta();
                lector = acceso.Lector;
                
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (float)lector["Precio"];

                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                acceso.cerrarConexion();
            }



                        

            
            return lista;
        }

        public void agregarArticulo(Articulo a) { }
        public void eliminarArticulo(Articulo a) { }
        public void modificarArticulo(Articulo a) { }
    


    }
}
