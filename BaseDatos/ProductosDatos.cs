using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class ProductosDatos
    {
        public List<Productos> listar()
        {
            List<Productos> productos = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                setearLecturaProducto("Select ID, Nombre, Precio, Categoria From productos", productos, datos);
                return productos;
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
        public void AgregarProducto(Productos valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into productos (Nombre, Precio, Categoria) values (@Nombre, @Precio, @Categoria)");
                datos.setearParametros("@Nombre", valor.Nombre);
                datos.setearParametros("@Precio", valor.Precio);
                datos.setearParametros("@Categoria", valor.Categoria);
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
        public void ModificarProducto(Productos valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update productos set Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria where ID = @Id");
                datos.setearParametros("@Id", valor.Id);
                datos.setearParametros("@Nombre", valor.Nombre);
                datos.setearParametros("@Precio", valor.Precio);
                datos.setearParametros("@Categoria", valor.Categoria);
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
        public void EliminarProducto(int valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from productos where id = @Id");
                datos.setearParametros("@Id", valor);
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
        public List<Productos> filtroProducto(string campo, string criterio, string filtro)
        {
            List<Productos> productos = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Select ID, Nombre, Precio, Categoria From productos Where ";
            try
            {
                switch (campo)
                {
                    case "Nombre":
                        if (criterio == "Comienza con")
                            consulta += "Nombre like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Nombre like '%" + filtro + "'";
                        else
                            consulta += "Nombre like '%" + filtro + "'";
                        break;
                    case "Precio":
                        if (criterio == "Menos a")
                            consulta += "Precio < " + filtro;
                        else if (criterio == "Igual")
                            consulta += "Precio = " + filtro;
                        else
                            consulta += "Precio > " + filtro;
                        break;
                    default:
                    case "Categoria":
                        if (criterio == "Comienza con")
                            consulta += "Categoria like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Categoria like '%" + filtro + "'";
                        else
                            consulta += "Categoria like '%" + filtro + "'";
                        break;
                }
                setearLecturaProducto(consulta, productos, datos);
                return productos;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        private void setearLecturaProducto(string consultaSql, List<Productos> productos, AccesoDatos datos)
        {
            datos.setearConsulta(consultaSql);
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Productos aux = new Productos();
                aux.Id = (int)datos.Lector["Id"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Precio = (double)datos.Lector["Precio"];
                aux.Categoria = (string)datos.Lector["Categoria"];

                productos.Add(aux);
            }
        }
    }
}
