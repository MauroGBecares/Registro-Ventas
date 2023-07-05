using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class VentasItemsDatos
    {
        public List<VentasItems> listar()
        {
            List<VentasItems> ventasItems = new List<VentasItems>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int valor = TomarIDVenta();
                setearLecturaVentasItems("Select I.ID, P.Nombre as Producto, I.PrecioUnitario, I.Cantidad, I.PrecioTotal, I.IDVenta, i.IDProducto From ventasitems I, ventas V, productos P Where P.ID = I.IDProducto AND V.ID = I.IDVenta AND I.IDVenta = @ID", ventasItems, datos, valor);

                return ventasItems;
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
        public List<VentasItems> listar(Ventas valor)
        {
            List<VentasItems> ventasItems = new List<VentasItems>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int valorIDVentaNula = TomarIDVenta();
                setearLecturaVentasItems("Select I.ID, P.Nombre as Producto, I.PrecioUnitario, I.Cantidad, I.PrecioTotal, I.IDVenta, i.IDProducto From ventasitems I, ventas V, productos P Where P.ID = I.IDProducto AND V.ID = I.IDVenta AND (I.IDVenta = @ID OR I.IDVenta = @IDVentaNula)", ventasItems, datos, valor.Id, valorIDVentaNula);

                return ventasItems;
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
        private void setearLecturaVentasItems(string consultaSql, List<VentasItems> ventasItems, AccesoDatos datos, int valor)
        {
            datos.setearConsulta(consultaSql);
            datos.setearParametros("@ID", valor);
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                VentasItems aux = new VentasItems();
                aux.Id = (int)datos.Lector["ID"];
                aux.Venta = new Ventas();
                aux.Venta.Id = (int)datos.Lector["IDVenta"];
                aux.Producto = new Productos();
                aux.Producto.Nombre = (string)datos.Lector["Producto"];
                aux.PrecioUnitario = (double)datos.Lector["PrecioUnitario"];
                aux.Cantidad = (double)datos.Lector["Cantidad"];
                aux.PrecioTotal = (double)datos.Lector["PrecioTotal"];

                ventasItems.Add(aux);
            }
        }
        private void setearLecturaVentasItems(string consultaSql, List<VentasItems> ventasItems, AccesoDatos datos, int valor, int valorIDVentaNula)
        {
            datos.setearConsulta(consultaSql);
            datos.setearParametros("@ID", valor);
            datos.setearParametros("@IDVentaNula", valorIDVentaNula);
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                VentasItems aux = new VentasItems();
                aux.Id = (int)datos.Lector["ID"];
                aux.Venta = new Ventas();
                aux.Venta.Id = (int)datos.Lector["IDVenta"];
                aux.Producto = new Productos();
                aux.Producto.Nombre = (string)datos.Lector["Producto"];
                aux.PrecioUnitario = (double)datos.Lector["PrecioUnitario"];
                aux.Cantidad = (double)datos.Lector["Cantidad"];
                aux.PrecioTotal = (double)datos.Lector["PrecioTotal"];

                ventasItems.Add(aux);
            }
        }
        public void AgregarVentasItems(VentasItems valor, bool hayVentaCargada, Ventas valorVentaID)
        {
            AccesoDatos datos = new AccesoDatos();
                try
                {
                    int valorID = TomarIDVenta();
                    datos.setearConsulta("Insert into ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) values (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)");
                    datos.setearParametros("@IDVenta", valorID);
                    datos.setearParametros("@IDProducto", valor.Producto.Id);
                    datos.setearParametros("@PrecioUnitario", valor.PrecioUnitario);
                    datos.setearParametros("@Cantidad", valor.Cantidad);
                    datos.setearParametros("@PrecioTotal", valor.PrecioTotal);
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
        private int TomarIDVenta()
        {
            AccesoDatos datos = new AccesoDatos();
            int id;
            try
            {
                datos.setearConsulta("SELECT TOP 1 * FROM ventas ORDER BY ID DESC");
                datos.ejecutarLectura();
                datos.Lector.Read();
                id = datos.Lector.GetInt32(datos.Lector.GetOrdinal("ID"));

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarVentaItem(int valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from ventasitems where id = @ID");
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
        }
        public void CancelarCambiosVenta()
        {
            AccesoDatos datos = new AccesoDatos();
            int id = TomarIDVenta();
            try
            {
                datos.setearConsulta("Delete from ventas where ID = @IDventa");
                datos.setearParametros("@IDventa", id);
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
            datos.setearConsulta("Delete from ventasitems where IDVenta = @ID");
            datos.setearParametros("@ID", id);
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
        public void GuardarVenta(Ventas valor, bool esNuevaVenta)
        {
            AccesoDatos datos = new AccesoDatos();
            int id = TomarIDVenta();
            try
            {
                datos.setearConsulta("Update ventas set IDCliente = @IDCliente, Fecha = @Fecha, Total = @Total where id = @ID");
                if (esNuevaVenta)
                    datos.setearParametros("@ID", id);
                else
                    datos.setearParametros("@ID", valor.Id);
                datos.setearParametros("@IDCliente", valor.Cliente.Id);
                datos.setearParametros("@Fecha", valor.Fecha);
                datos.setearParametros("@Total", valor.Total);
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
            if (!esNuevaVenta)
            {
                try
                {
                    datos.setearConsulta("Update ventasitems set IDVenta = @IDModificada where IDVenta = @IDVentaNula");
                    datos.setearParametros("@IDVentaNula", id);
                    datos.setearParametros("@IDModificada", valor.Id);
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
                    datos.setearParametros("@IDventa", id);
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
        public void ModificarCantidad(VentasItems valor, double cantidad)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update ventasitems set PrecioTotal = @PrecioTotal, Cantidad = @Cantidad where id = @ID");
                datos.setearParametros("@ID", valor.Id);
                datos.setearParametros("@Cantidad", cantidad);
                datos.setearParametros("@PrecioTotal", valor.PrecioTotal);
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
