using SistemaGestion.BSS;
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
	public partial class PedidoListarVista : Form
	{
		public PedidoListarVista()
		{
			InitializeComponent();
		}
		PedidoBss bss = new PedidoBss();

		private void PedidoListarVista_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = bss.ListarPedidoBss();
		}
		private void frm_closing(object sender, FormClosingEventArgs e)
		{
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			PedidoInsertarVista fr = new PedidoInsertarVista();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPedidoBss();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int IdPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			PedidoEditarVista fr = new PedidoEditarVista(IdPedidoSeleccionado);
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPedidoBss();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int IdPedidoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
			DialogResult result = MessageBox.Show("Estas Seguro de eliminar este cliente?", "Eliminado", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				bss.EliminarPedidoBss(IdPedidoSeleccionado);
				dataGridView1.DataSource = bss.ListarPedidoBss();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			PedidoTotalVistas fr = new PedidoTotalVistas();
			this.Hide();
			fr.FormClosing += frm_closing;
			if (fr.ShowDialog() == DialogResult.OK)
			{
				dataGridView1.DataSource = bss.ListarPedidoBss();
			}

		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			ClienteListarVista detalleingForm = new ClienteListarVista();
			detalleingForm.Show();
			detalleingForm.FormClosing += frm_closing;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (!pServicios.Visible)
				pServicios.Visible = true;
			else
				pServicios.Visible = false;
		}
	}
}
