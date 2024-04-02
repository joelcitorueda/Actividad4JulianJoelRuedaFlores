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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGestion.VISTA.ClienteVistas
{
	public partial class ClienteInsertarVista : Form
	{
		public ClienteInsertarVista()
		{
			InitializeComponent();
		}
		ClienteBss bss = new ClienteBss();
		private void button1_Click(object sender, EventArgs e)
		{
			Cliente c = new Cliente();
			c.Nombre = textBox1.Text; 
			c.Apellido = textBox2.Text; 
			c.CorreoElectronico = textBox3.Text; 
			c.Telefono = textBox4.Text; 
			c.Direccion = textBox5.Text; 

			
			bss.InsertarClienteBss(c);

			MessageBox.Show("Cliente guardado correctamente");
		}
		

	}
}
