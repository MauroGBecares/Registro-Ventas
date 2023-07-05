using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BaseDatos
{
    public class VentasDatos
    {
        public List<Ventas> listar()
        {
            List<Ventas> ventas = new List<Ventas>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select V.ID, C.Cliente, V.Fecha, V.Total, V.IDCliente From clientes C,ventas V Where C.ID = V.IDCliente");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Ventas aux = new Ventas();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Cliente = new Clientes();
                    aux.Cliente.Id = (int)datos.Lector["IDCliente"];
                    aux.Cliente.Cliente = (string)datos.Lector["Cliente"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (double)datos.Lector["Total"];

                    ventas.Add(aux);
                }
                return ventas;
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
        public void AgregarVentaNula()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into ventas (IDCliente, Fecha, Total) values (-1, NULL, NULL)");
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
        public void EliminarVenta(int valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from ventasitems where IDVenta = @ID");
                datos.setearParametros("@ID", valor);
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

            try
            {
                datos.setearConsulta("Delete from ventas where ID = @IDventa");
                datos.setearParametros("@IDventa", valor);
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
        public List<Ventas> fitroVentas(string campo, string criterio, string filtro, string fecha)
        {
            List<Ventas> lista = new List<Ventas>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Select V.ID, C.Cliente, V.Fecha, V.Total, V.IDCliente From clientes C,ventas V Where C.ID = V.IDCliente AND ";
            try
            {
                switch (campo)
                {
                    case "Cliente":
                        if (criterio == "Comienza con")
                            consulta += "Cliente like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Cliente like '%" + filtro + "%'";
                        else
                            consulta += "Cliente like '%" + filtro + "'";
                        break;
                    case "Total":
                        if (criterio == "Menos a")
                            consulta += "Total < " + filtro;
                        else if (criterio == "Igual")
                            consulta += "Total = " + filtro;
                        else
                            consulta += "Total > " + filtro;
                        break;
                    default:
                        consulta += "Fecha = '" + fecha + "'";
                        break;
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    Ventas aux = new Ventas();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Cliente = new Clientes();
                    aux.Cliente.Id = (int)datos.Lector["IDCliente"];
                    aux.Cliente.Cliente = (string)datos.Lector["Cliente"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (double)datos.Lector["Total"];

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
    }
}
