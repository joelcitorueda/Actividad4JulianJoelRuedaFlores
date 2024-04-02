using SistemaGestion.BSS;
using SistemaGestion.Modelos;
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
	public partial class ClienteEditarVista : Form
	{
		int idx = 0;
		Cliente p = new Cliente();
		ClienteBss bss = new ClienteBss();
		public ClienteEditarVista(int id)
		{
			idx = id;
			InitializeComponent();
		}

		private void ClienteEditarVista_Load(object sender, EventArgs e)
		{
			p = bss.ObtenerClienteIdBss(idx);
			textBox1.Text = p.Nombre;
			textBox2.Text = p.Apellido;
			textBox3.Text = p.CorreoElectronico;
			textBox4.Text = p.Telefono;
			textBox5.Text = p.Direccion;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.Nombre = textBox1.Text;
			p.Apellido = textBox2.Text;
			p.CorreoElectronico = textBox3.Text;
			p.Telefono = textBox4.Text;
			p.Direccion = textBox5.Text;

			bss.EditarClienteBss(p);
			MessageBox.Show("Datos Actualizados");
		}
	}
}
