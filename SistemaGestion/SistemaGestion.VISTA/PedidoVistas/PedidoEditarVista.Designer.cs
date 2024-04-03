namespace SistemaGestion.VISTA.PedidoVistas
{
	partial class PedidoEditarVista
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
			dateTimePicker1 = new DateTimePicker();
			pictureBox1 = new PictureBox();
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label1 = new Label();
			button3 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(42, 248);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 27);
			dateTimePicker1.TabIndex = 61;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.pedido;
			pictureBox1.Location = new Point(154, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 60;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.HotTrack;
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(221, 407);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 59;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HotTrack;
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(92, 407);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 58;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(42, 339);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 57;
			textBox3.Text = "ESTADO";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(42, 290);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 56;
			textBox2.Text = "TOTAL";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(42, 202);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 55;
			textBox1.Text = "ID CLIENTE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(42, 153);
			label1.Name = "label1";
			label1.Size = new Size(182, 31);
			label1.TabIndex = 54;
			label1.Text = "EDITAR PEDIDO";
			// 
			// button3
			// 
			button3.BackColor = SystemColors.HotTrack;
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = Color.White;
			button3.Location = new Point(262, 202);
			button3.Name = "button3";
			button3.Size = new Size(116, 29);
			button3.TabIndex = 62;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// PedidoEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(430, 493);
			Controls.Add(button3);
			Controls.Add(dateTimePicker1);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "PedidoEditarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PedidoEditarVista";
			Load += PedidoEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private PictureBox pictureBox1;
		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label1;
		private Button button3;
	}
}