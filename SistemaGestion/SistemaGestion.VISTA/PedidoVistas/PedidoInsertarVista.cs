using SistemaGestion.BSS;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.ClienteVistas;
using System;
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
	public partial class PedidoInsertarVista : Form
	{
		public PedidoInsertarVista()
		{
			InitializeComponent();
		}
		PedidoBss bss = new PedidoBss();

		private void button1_Click(object sender, EventArgs e)
		{
			Pedido p = new Pedido();
			p.IDCliente = IdClienteSeleccionado;
			p.Fecha = dateTimePicker1.Value;
			p.Total = Convert.ToDecimal(textBox2.Text);
			p.Estado = textBox3.Text;

			bss.InsertarPedidoBss(p);
			MessageBox.Show("Se guardó correctamente a Cliente");
		}
		public static int IdClienteSeleccionado = 0;
		ClienteBss bssprov = new ClienteBss();
		private void button3_Click(object sender, EventArgs e)
		{
			ClienteListarVista fr = new ClienteListarVista();
			if (fr.ShowDialog() == DialogResult.OK)
			{
				Cliente proveedor = bssprov.ObtenerClienteIdBss(IdClienteSeleccionado);
				textBox1.Text = proveedor.Nombre;
			}
		}
	}
}
