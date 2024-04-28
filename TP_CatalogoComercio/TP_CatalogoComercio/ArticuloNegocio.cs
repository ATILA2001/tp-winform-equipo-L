using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TP_CatalogoComercio
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.IdMarca, A.IdCategoria, A.Precio, I.ImagenUrl AS Imagen FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id INNER JOIN MARCAS AS M ON A.IdMarca =M.Id INNER JOIN IMAGENES AS I ON A.Id = I.IdArticulo";


                //comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl AS Imagen FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id INNER JOIN MARCAS AS M ON A.IdMarca = M.Id INNER JOIN IMAGENES AS I ON A.Id = I.IdArticulo";

                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagenes = new List<Imagen>();
                    Imagen iAux= new Imagen();
                    //aux.Imagen = new Imagen();
                    aux.Id = (int)lector["Id"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    //aux.Imagen.Url = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];
                    iAux.Url = (string)lector["Imagen"];
                    aux.Imagenes.Add(iAux);
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

        public List<Articulo> listarConFiltro (decimal desde, decimal hasta, Marca marca, Categoria categoria)
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS MARCAS, C.Descripcion AS CATEGORIAS, A.Precio FROM ARTICULOS AS A " +
                                        "INNER JOIN MARCAS AS M ON A.IdMarca = M.Id " +
                                        "INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id " +
                                        "WHERE A.IdCategoria = " + categoria.Id + " AND A.IdMarca = " + marca.Id + " AND A.Precio BETWEEN " + desde + " AND " + hasta;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca.Descripcion = (string)lector["MARCAS"];
                    aux.Categoria.Descripcion = (string)lector["CATEGORIAS"];
                    aux.Precio = (decimal)lector["Precio"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void agregar(Articulo art)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                    "VALUES(" + "'" + art.CodigoArticulo + "'" + "," + "'" + art.Nombre + "'" + "," + "'" + art.Descripcion + "'" + "," + art.Marca.Id + "," + art.Categoria.Id + "," + art.Precio + ")";
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally { conexion.Close(); }
        }       
        public void modificar(Articulo art)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE ARTICULOS SET Codigo = '" + art.CodigoArticulo + "', Nombre = '" + art.Nombre + "', Descripcion = '" + art.Descripcion + 
                    "', IdMarca = " + art.Marca.Id + ", IdCategoria = " + art.Categoria.Id + ", Precio = " + art.Precio + " WHERE Id = " + art.Id;
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
