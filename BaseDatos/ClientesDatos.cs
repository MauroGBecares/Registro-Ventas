using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BaseDatos
{
    public class ClientesDatos
    {
        public List<Clientes> listar()
        {
            List<Clientes> clientes = new List<Clientes>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                setearLecturaClientes("Select ID, Cliente, Telefono, Correo From clientes", clientes, datos);
                return clientes;
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
        public void AgregarCliente(Clientes valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into clientes (Cliente, Telefono, Correo) values (@Cliente, @Telefono, @Correo)");
                datos.setearParametros("@Cliente", valor.Cliente);
                datos.setearParametros("@Telefono", valor.Telefono);
                datos.setearParametros("@Correo", valor.Correo);
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
        public void ModificarCliente(Clientes valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update clientes set Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo where ID = @Id");
                datos.setearParametros("@Id", valor.Id);
                datos.setearParametros("@Cliente", valor.Cliente);
                datos.setearParametros("@Telefono", valor.Telefono);
                datos.setearParametros("@Correo", valor.Correo);
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
        public void eliminarCliente(int valor)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from clientes where id = @Id");
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

        public List<Clientes> filtroCliente(string campo, string criterio, string filtro)
        {
            List<Clientes> clientes = new List<Clientes>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Select ID, Cliente, Telefono, Correo From clientes Where ";
            try
            {
                switch (campo)
                {
                    case "Nombre o Razon Social":
                        if (criterio == "Comienza con")
                            consulta += "Cliente like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Cliente like '%" + filtro + "'";
                        else
                            consulta += "Cliente like '%" + filtro + "'";
                        break;
                    case "Teléfono":
                        if (criterio == "Comienza con")
                            consulta += "Telefono like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Telefono like '%" + filtro + "'";
                        else
                            consulta += "Telefono like '%" + filtro + "'";
                        break;
                    default:
                        if (criterio == "Comienza con")
                            consulta += "Correo like '" + filtro + "%'";
                        else if (criterio == "Contiene")
                            consulta += "Correo like '%" + filtro + "'";
                        else
                            consulta += "Correo like '%" + filtro + "'";
                        break;
                }
                setearLecturaClientes(consulta, clientes, datos);
                return clientes;
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
        private void setearLecturaClientes(string consultaSql, List<Clientes> clientes, AccesoDatos datos)
        {
            datos.setearConsulta(consultaSql);
            datos.ejecutarLectura();
            while (datos.Lector.Read())
            {
                Clientes aux = new Clientes();
                aux.Id = (int)datos.Lector["Id"];
                aux.Cliente = (string)datos.Lector["Cliente"];
                aux.Telefono = (string)datos.Lector["Telefono"];
                aux.Correo = (string)datos.Lector["Correo"];

                clientes.Add(aux);
            }
        }
    }
}
