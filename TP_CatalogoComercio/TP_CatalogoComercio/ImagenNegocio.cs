using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class ImagenNegocio
    {
        public List<Imagen> listar()
        {
            List<Imagen> lista = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select ImagenUrl from IMAGENES";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Url = (string)lector["ImagenUrl"];
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

        public string searchId(string codArt)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                string Id;
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id FROM ARTICULOS AS A WHERE A.Codigo = '" + codArt + "'"; 
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();
                if(lector.Read())
                {
                    Id = lector["Id"].ToString();
                }
                else
                {
                    Id = "0";
                }
                conexion.Close();
                return Id;  
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void agregar(Imagen imagen)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (" + imagen.Id + ", '" + imagen.Url + "')";
                                      //"INSERT INTO IMAGENES (IdArticulo,ImagenUrl) values (" + imagen.Id + "," + "'" + imagen.Url+ "'"+")";
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally { conexion.Close(); }
        }
       
    }
}
