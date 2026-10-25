using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector{ get{ return lector; }}

        //configurar con datos del servidor....
        public AccesoDatos() {
            try
            {
                // configuración del servidor, ip, etc, datos del servidor en remoto
                conexion = new SqlConnection("Acá insertar los datos...");
                comando = new SqlCommand(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta (string consulta) {
            // ver si después hay que cambiar por Data.StoredProcedure  
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta; 
        }

        public void ejecutarConsulta () {
            comando.Connection = conexion;
            
            try { 
                conexion.Open();
                //en lector tenemos todos los datos, algo así como una tabla virtual que debemos 
                // transformar...
    
                //supongo que solo sirve para los casos en dónde tengamos que hacer lecturas y traerlas a la app, ver después....
                lector = comando.ExecuteReader();  
            } 
            catch (Exception ex) {
                throw ex;
            }
        }

        public void cerrarConexion() {
           if (lector!= null) lector.Close();
            conexion.Close();
        }




    }
}
