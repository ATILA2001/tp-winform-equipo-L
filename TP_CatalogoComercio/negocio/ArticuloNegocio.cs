using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl AS Imagen " +
                    "FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id " +
                    "INNER JOIN MARCAS AS M ON A.IdMarca = M.Id " +
                    "INNER JOIN IMAGENES AS I ON A.Id = I.IdArticulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Imagenes = new List<Imagen>();
                    Imagen iAux = new Imagen();
                    //aux.Imagen = new Imagen();
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    //aux.Imagen.Url = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    iAux.Url = (string)datos.Lector["Imagen"];
                    aux.Imagenes.Add(iAux);
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
        public List<Articulo> listarConFiltro (decimal desde, decimal hasta, Marca marca, Categoria categoria)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS MARCAS, C.Descripcion AS CATEGORIAS, A.Precio FROM ARTICULOS AS A " +
                "INNER JOIN MARCAS AS M ON A.IdMarca = M.Id " +
                "INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id " +
                "WHERE A.IdCategoria = " + categoria.Id + " AND A.IdMarca = " + marca.Id + " AND A.Precio BETWEEN " + desde + " AND " + hasta);
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Descripcion = (string)datos.Lector["MARCAS"];
                    aux.Categoria.Descripcion = (string)datos.Lector["CATEGORIAS"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    lista.Add(aux);
                }
                
                return lista;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                "VALUES(" + "'" + art.CodigoArticulo + "'" + "," + "'" + art.Nombre + "'" + "," + "'" + art.Descripcion + "'" + "," + art.Marca.Id + "," + art.Categoria.Id + "," + art.Precio + ")");
                datos.ejecutarAccion();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally 
            { 
                datos.cerrarConexion(); 
            }
        }
        public void eliminar(string id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id =" + id + "");
                datos.ejecutarAccion();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally 
            { 
                datos.cerrarConexion(); 
            }

        }
        public string searchId(string codArt)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string Id;
                datos.setearConsulta("SELECT A.Id FROM ARTICULOS AS A WHERE A.Codigo = '" + codArt + "'");
                if (datos.Lector.Read())
                {
                    Id = datos.Lector["Id"].ToString();
                }
                else
                {
                    Id = "0";
                }
                return Id;
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
