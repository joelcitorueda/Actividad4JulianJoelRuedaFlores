namespace SistemaGestion.VISTA.PedidoVistas
{
	partial class PedidoTotalVistas
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
			button3 = new Button();
			pictureBox1 = new PictureBox();
			textBox1 = new TextBox();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			dataGridView2 = new DataGridView();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// button3
			// 
			button3.Location = new Point(265, 207);
			button3.Name = "button3";
			button3.Size = new Size(116, 29);
			button3.TabIndex = 58;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.pedido;
			pictureBox1.Location = new Point(220, 59);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 57;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(45, 207);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 56;
			textBox1.Text = "ID CLIENTE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(45, 18);
			label1.Name = "label1";
			label1.Size = new Size(472, 38);
			label1.TabIndex = 55;
			label1.Text = "TOTAL DE PEDIDOS POR CLIENTE";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = SystemColors.HotTrack;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(45, 299);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(431, 196);
			dataGridView1.TabIndex = 59;
			// 
			// button1
			// 
			button1.Location = new Point(45, 252);
			button1.Name = "button1";
			button1.Size = new Size(116, 29);
			button1.TabIndex = 60;
			button1.Text = "TOTAL";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToDeleteRows = false;
			dataGridView2.BackgroundColor = SystemColors.HotTrack;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(343, 525);
			dataGridView2.Margin = new Padding(3, 4, 3, 4);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.Size = new Size(197, 73);
			dataGridView2.TabIndex = 61;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(193, 540);
			label2.Name = "label2";
			label2.Size = new Size(123, 24);
			label2.TabIndex = 62;
			label2.Text = "Monto Total\r\n";
			// 
			// PedidoTotalVistas
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(626, 636);
			Controls.Add(label2);
			Controls.Add(dataGridView2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(button3);
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "PedidoTotalVistas";
			Text = "PedidoTotalVistas";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button3;
		private PictureBox pictureBox1;
		private TextBox textBox1;
		private Label label1;
		private DataGridView dataGridView1;
		private Button button1;
		private DataGridView dataGridView2;
		private Label label2;
	}
}