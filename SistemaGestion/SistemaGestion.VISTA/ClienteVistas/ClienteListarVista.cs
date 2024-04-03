using SistemaGestion.BSS;
using SistemaGestion.DAL;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.PedidoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.VISTA.ClienteVistas
{
	public partial class ClienteListarVista : Form
	{
		public ClienteListarVista()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();

		private void ClienteListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarClienteBss();
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			ClienteInsertarVista fr = new ClienteInsertarVista();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			ClienteEditarVista fr = new ClienteEditarVista(IdClienteSeleccionado);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}
		public static int IdClienteSeleccionado { get; private set; }

		private void button4_Click(object sender, EventArgs e)
		{
			int IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("Estas Seguro de eliminar este cliente?", "Eliminado", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarClienteBss(IdClienteSeleccionado);
				dataGridView1.DataSource = bss.ListarClienteBss();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PedidoVistas.PedidoInsertarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			PedidoVistas.PedidoEditarVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			PedidoVistas.PedidoTotalVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			PedidoListarVista detalleingForm = new PedidoListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}
	}
}
