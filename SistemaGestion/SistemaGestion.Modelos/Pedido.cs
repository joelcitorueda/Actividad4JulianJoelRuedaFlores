using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.Modelos
{
	public class Pedido
	{
		public int IDPedido { get; set; }
		public int IDCliente { get; set; }
		public DateTime Fecha { get; set; }
		public decimal Total { get; set; }
		public string Estado { get; set; }
	}
}
