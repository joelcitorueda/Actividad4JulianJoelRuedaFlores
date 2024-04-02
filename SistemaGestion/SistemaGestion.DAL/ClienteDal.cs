using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL
{
	public class ClienteDal
	{
		public DataTable ListarClienteDal()
		{
			string consulta = "select * from CLIENTE";

			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarClienteDal(Cliente cliente)
		{
			string consulta = "INSERT INTO CLIENTE (NOMBRE, APELLIDO, CORREOELECTRONICO, TELEFONO, DIRECCION) " +
							  "VALUES ('" + cliente.Nombre + "', '" +
										  cliente.Apellido + "', '" +
										  cliente.CorreoElectronico + "', '" +
										  cliente.Telefono + "', '" +
										  cliente.Direccion + "')";
			conexion.Ejecutar(consulta);
		}
		Cliente p = new Cliente();
		public Cliente ObtenerClienteIdDal(int id)
		{
			Cliente cliente = new Cliente();
			string consulta = "SELECT * FROM CLIENTE WHERE IDCLIENTE = " + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			if (tabla.Rows.Count > 0)
			{
				cliente.IDCliente = Convert.ToInt32(tabla.Rows[0]["IDCLIENTE"]);
				cliente.Nombre = tabla.Rows[0]["NOMBRE"].ToString();
				cliente.Apellido = tabla.Rows[0]["APELLIDO"].ToString();
				cliente.CorreoElectronico = tabla.Rows[0]["CORREOELECTRONICO"].ToString();
				cliente.Telefono = tabla.Rows[0]["TELEFONO"].ToString();
				cliente.Direccion = tabla.Rows[0]["DIRECCION"].ToString();
			}
			return cliente;
		}

		public void EditarClienteDal(Cliente cliente)
		{
			string consulta = "UPDATE CLIENTE SET NOMBRE = '" + cliente.Nombre + "', " +
												   "APELLIDO = '" + cliente.Apellido + "', " +
												   "CORREOELECTRONICO = '" + cliente.CorreoElectronico + "', " +
												   "TELEFONO = '" + cliente.Telefono + "', " +
												   "DIRECCION = '" + cliente.Direccion + "' " +
							  "WHERE IDCLIENTE = " + cliente.IDCliente;
			conexion.Ejecutar(consulta);
		}

		public void EliminarClienteDal(int id)
		{
			string consulta = "DELETE FROM CLIENTE WHERE IDCLIENTE = " + id;
			conexion.Ejecutar(consulta);
		}

	}
}
