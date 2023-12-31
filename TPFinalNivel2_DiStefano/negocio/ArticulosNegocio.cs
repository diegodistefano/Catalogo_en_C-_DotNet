using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, A.Id, C.Descripcion Categoria, M.Descripcion Marca, A.IdCategoria, A.IdMarca From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria and  M.Id = A.IdMarca");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Math.Round(datos.Lector.GetDecimal(4), 2);
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

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

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, A.Id, C.Descripcion Categoria, M.Descripcion Marca, A.IdCategoria, A.IdMarca From ARTICULOS A, CATEGORIAS C, MARCAS M Where C.Id = A.IdCategoria and  M.Id = A.IdMarca And ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a:":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a:":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "Codigo like '" + filtro + "%' ";
                            break;
                        case "Termina con:":
                            consulta += "Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con:":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con:":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Categoria")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con:":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = Math.Round(datos.Lector.GetDecimal(4), 2);
                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marcas();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulos nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert Into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdCategoria, IdMarca) Values (@Codigo, @Nombre, @Descripcion, @ImagenUrl, @Precio, @IdCategoria, @IdMarca)");
              //datos.setearConsulta("Insert Into ARTICULOS (Codigo, Nombre, Descripcion) Values (@Codigo, @Nombre, @Descripcion)");
               
                datos.setearParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.setearParametro("@Precio", nuevoArticulo.Precio);
                datos.setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                
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

        public void modificar(Articulos nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set  Codigo = @Codigo, Nombre = @nombre, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, Precio = @Precio, IdCategoria = @IdCategoria, IdMarca = @IdMarca Where Id = @Id");
                
                datos.setearParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.setearParametro("@Precio", nuevoArticulo.Precio);
                datos.setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setearParametro("@id", nuevoArticulo.Id);

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

        public void eliminar(int Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                
                datos.setearParametro("@Id", Id);
                
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


    }
}
