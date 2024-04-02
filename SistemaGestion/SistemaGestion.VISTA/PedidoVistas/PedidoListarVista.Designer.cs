namespace SistemaGestion.VISTA.PedidoVistas
{
	partial class PedidoListarVista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoListarVista));
			label2 = new Label();
			label3 = new Label();
			label1 = new Label();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.HotTrack;
			label2.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(38, 21);
			label2.Name = "label2";
			label2.Size = new Size(396, 29);
			label2.TabIndex = 37;
			label2.Text = "ADMINISTRACION  DE PEDIDOS";
			// 
			// label3
			// 
			label3.BackColor = SystemColors.HotTrack;
			label3.Location = new Point(-1, -3);
			label3.Name = "label3";
			label3.Size = new Size(803, 71);
			label3.TabIndex = 38;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(38, 162);
			label1.Name = "label1";
			label1.Size = new Size(224, 28);
			label1.TabIndex = 36;
			label1.Text = "LISTADO DE PEDIDOS";
			// 
			// button4
			// 
			button4.BackColor = SystemColors.HotTrack;
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.White;
			button4.Image = Properties.Resources.icons8_eliminar_27;
			button4.ImageAlign = ContentAlignment.MiddleRight;
			button4.Location = new Point(434, 87);
			button4.Name = "button4";
			button4.Size = new Size(158, 40);
			button4.TabIndex = 35;
			button4.Text = "ELIMINAR";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.BackColor = SystemColors.HotTrack;
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.White;
			button3.Image = (Image)resources.GetObject("button3.Image");
			button3.ImageAlign = ContentAlignment.MiddleRight;
			button3.Location = new Point(243, 87);
			button3.Name = "button3";
			button3.Size = new Size(158, 40);
			button3.TabIndex = 34;
			button3.Text = "EDITAR";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.HotTrack;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleRight;
			button2.Location = new Point(38, 87);
			button2.Name = "button2";
			button2.Size = new Size(158, 40);
			button2.TabIndex = 33;
			button2.Text = "AGREGAR";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = SystemColors.HotTrack;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(100, 206);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(656, 296);
			dataGridView1.TabIndex = 32;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HotTrack;
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Image = Properties.Resources.icons8_marque_todas_las_27;
			button1.ImageAlign = ContentAlignment.MiddleRight;
			button1.Location = new Point(631, 87);
			button1.Name = "button1";
			button1.Size = new Size(158, 40);
			button1.TabIndex = 39;
			button1.Text = "SELECCIONAR";
			button1.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			button5.BackColor = SystemColors.HotTrack;
			button5.DialogResult = DialogResult.OK;
			button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.ForeColor = Color.White;
			button5.Image = Properties.Resources.bruto;
			button5.ImageAlign = ContentAlignment.MiddleRight;
			button5.Location = new Point(434, 150);
			button5.Name = "button5";
			button5.Size = new Size(355, 40);
			button5.TabIndex = 40;
			button5.Text = "CALCULAR TOTAL PEDIDOS POR CLIENTE";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// PedidoListarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(801, 526);
			Controls.Add(button5);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Name = "PedidoListarVista";
			Text = "PedidoListarVista";
			Load += PedidoListarVista_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label3;
		private Label label1;
		private Button button4;
		private Button button3;
		private Button button2;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button5;
	}
}