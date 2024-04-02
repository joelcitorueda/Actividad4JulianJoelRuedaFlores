using SistemaGestion.BSS;
using SistemaGestion.DAL;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.ClienteVistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.VISTA.PedidoVistas
{
	public partial class PedidoTotalVistas : Form
	{
		public PedidoTotalVistas()
		{
			InitializeComponent();
		}
		public static int IdClienteSeleccionado = 0;
		ClienteBss bssprov = new ClienteBss();

		private readonly conexion conexion = new conexion("Data Source=DESKTOP-EROEUF5;Initial Catalog=SISTEMAGESTION;Integrated Security=True;");


		private void button3_Click(object sender, EventArgs e)
		{
			ClienteListarVista fr = new ClienteListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Cliente cliente = bssprov.ObtenerClienteIdBss(IdClienteSeleccionado);
				textBox1.Text = cliente.Nombre;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Verificar si se ha seleccionado un cliente

			if (IdClienteSeleccionado != 0)
			{
				MostrarPedidosCliente(IdClienteSeleccionado);

				MostrarTotalPedidosCliente(IdClienteSeleccionado);
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un cliente primero.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void MostrarPedidosCliente(int idCliente)
		{
			try
			{
				string query = "SELECT P.IDPedido, P.Fecha, P.Total " +
							   "FROM Pedidos P " +
							   "INNER JOIN Cliente C ON P.IDCliente = C.IDCliente " +
							   "WHERE C.IDCliente = @IDCliente";


				DataTable dataTable = conexion.EjecutarDataTabla(query, "PedidosCliente", idCliente);
				dataGridView1.DataSource = dataTable;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar los pedidos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void MostrarTotalPedidosCliente(int idCliente)
		{
			try
			{
				string queryTotal = "SELECT SUM(P.Total) AS TotalPedidos " +
									"FROM Pedidos P " +
									"INNER JOIN Cliente C ON P.IDCliente = C.IDCliente " +
									"WHERE C.IDCliente = @IDCliente";

				DataTable dataTableTotal = conexion.EjecutarDataTabla(queryTotal, "TotalPedidosCliente", idCliente);

				dataGridView2.DataSource = dataTableTotal;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar la suma total de los pedidos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
