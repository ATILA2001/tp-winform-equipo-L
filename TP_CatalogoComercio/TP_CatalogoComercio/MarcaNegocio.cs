using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];
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
        public void agregar(Marca marca)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO MARCAS (Descripcion) VALUES ('" + marca.Descripcion + "')";
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); }
        }
        public void eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "DELETE FROM MARCAS WHERE Id =" + id + "";
                ;
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
