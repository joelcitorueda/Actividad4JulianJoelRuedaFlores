﻿namespace SistemaGestion.VISTA.ClienteVistas
{
	partial class ClienteInsertarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInsertarVista));
			pictureBox1 = new PictureBox();
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label1 = new Label();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(119, 62);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 42;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.HotTrack;
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(194, 461);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 40;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HotTrack;
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(77, 461);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 39;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(63, 310);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(246, 27);
			textBox3.TabIndex = 38;
			textBox3.Text = "CORREO ELECTRONICO";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(63, 262);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(246, 27);
			textBox2.TabIndex = 37;
			textBox2.Text = "APELLIDO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(63, 212);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(246, 27);
			textBox1.TabIndex = 36;
			textBox1.Text = "NOMBRE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(99, 16);
			label1.Name = "label1";
			label1.Size = new Size(189, 28);
			label1.TabIndex = 35;
			label1.Text = "AGREGAR CLIENTE";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(63, 359);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(246, 27);
			textBox4.TabIndex = 43;
			textBox4.Text = "TELEFONO";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(63, 402);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(246, 27);
			textBox5.TabIndex = 44;
			textBox5.Text = "DIRECION";
			// 
			// ClienteInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(369, 599);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ClienteInsertarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ClienteInsertarVista";
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
		private TextBox textBox4;
		private TextBox textBox5;
	}
}