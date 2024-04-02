namespace SistemaGestion.VISTA.PedidoVistas
{
	partial class PedidoInsertarVista
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
			pictureBox1 = new PictureBox();
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label1 = new Label();
			dateTimePicker1 = new DateTimePicker();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.pedido;
			pictureBox1.Location = new Point(167, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 51;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(234, 398);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 50;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(105, 398);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 49;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(55, 330);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 48;
			textBox3.Text = "ESTADO";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(55, 281);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 47;
			textBox2.Text = "TOTAL";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(55, 193);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 46;
			textBox1.Text = "ID CLIENTE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(55, 144);
			label1.Name = "label1";
			label1.Size = new Size(132, 20);
			label1.TabIndex = 45;
			label1.Text = "AGREGAR PEDIDO";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(55, 239);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 27);
			dateTimePicker1.TabIndex = 53;
			// 
			// button3
			// 
			button3.Location = new Point(275, 193);
			button3.Name = "button3";
			button3.Size = new Size(116, 29);
			button3.TabIndex = 54;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// PedidoInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(440, 508);
			Controls.Add(button3);
			Controls.Add(dateTimePicker1);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "PedidoInsertarVista";
			Text = "PedidoInsertarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private PictureBox pictureBox1;
		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label1;
		private DateTimePicker dateTimePicker1;
		private Button button3;
	}
}