using SistemaGestion.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL
{
	public class PedidoDal
	{
		public DataTable ListarPedidosDal()
		{
			string consulta = "SELECT * FROM PEDIDOS";
			DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
			return lista;
		}

		public void InsertarPedidoDal(Pedido pedido)
		{
			string consulta = "INSERT INTO PEDIDOS (IDCLIENTE, FECHA, TOTAL, ESTADO) VALUES (" +
							  pedido.IDCliente + ", '" + pedido.Fecha.ToString("yyyy-MM-dd") + "', " +
							  pedido.Total + ", '" + pedido.Estado + "')";
			conexion.Ejecutar(consulta);
		}

		public Pedido ObtenerPedidoPorIdDal(int id)
		{
			string consulta = "SELECT * FROM PEDIDOS WHERE IDPEDIDO = " + id;
			DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
			Pedido pedido = new Pedido();
			if (tabla.Rows.Count > 0)
			{
				pedido.IDPedido = Convert.ToInt32(tabla.Rows[0]["IDPEDIDO"]);
				pedido.IDCliente = Convert.ToInt32(tabla.Rows[0]["IDCLIENTE"]);
				pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["FECHA"]);
				pedido.Total = Convert.ToDecimal(tabla.Rows[0]["TOTAL"]);
				pedido.Estado = tabla.Rows[0]["ESTADO"].ToString();
			}
			return pedido;
		}

		public void EditarPedidoDal(Pedido pedido)
		{
			string consulta = "UPDATE PEDIDOS SET IDCLIENTE = " + pedido.IDCliente + ", " +
							  "FECHA = '" + pedido.Fecha.ToString("yyyy-MM-dd") + "', " +
							  "TOTAL = " + pedido.Total + ", " +
							  "ESTADO = '" + pedido.Estado + "' " +
							  "WHERE IDPEDIDO = " + pedido.IDPedido;
			conexion.Ejecutar(consulta);
		}

		public void EliminarPedidoDal(int id)
		{
			string consulta = "DELETE FROM PEDIDOS WHERE IDPEDIDO = " + id;
			conexion.Ejecutar(consulta);
		}

	}
}
