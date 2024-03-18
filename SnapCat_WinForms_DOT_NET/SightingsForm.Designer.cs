using System.Drawing.Drawing2D;

namespace SnapCat_WinForms_DOT_NET
{
	partial class SightingsForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			textBox1 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = Properties.Resources.camera_temp;
			pictureBox1.Location = new Point(208, 154);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(452, 427);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(208, 659);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(452, 133);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(237, 833);
			button1.Name = "button1";
			button1.Size = new Size(177, 71);
			button1.TabIndex = 2;
			button1.Text = "Gallery";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(455, 833);
			button2.Name = "button2";
			button2.Size = new Size(177, 71);
			button2.TabIndex = 3;
			button2.Text = "Camera";
			button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(28, 28);
			label1.Name = "label1";
			label1.Size = new Size(604, 72);
			label1.TabIndex = 4;
			label1.Text = "Report a Sighting";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Georgia", 12F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(117, 659);
			label2.Name = "label2";
			label2.Size = new Size(85, 38);
			label2.TabIndex = 5;
			label2.Text = "Info:";
			label2.Click += label2_Click;
			// 
			// SightingsForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(877, 950);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(pictureBox1);
			Name = "SightingsForm";
			Text = "Form1";
			Paint += set_background;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void set_background(object sender, PaintEventArgs e)
		{
			LinearGradientBrush linGrBrush = new LinearGradientBrush(
				new Point(0, 0),
				//new Point(500, 500),
				new Point(0, 1000),
				Color.FromArgb(255, 128, 0, 128),     // Opaque black
				Color.FromArgb(255, 255, 0, 0)
			);  // Opaque red

			float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
			float[] relativePositions = { 0.0f, 0.5f, 1.0f };

			//float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
			//float[] relativePositions = { 0.0f, 0.2f, 1.0f };


			//Create a Blend object and assign it to linGrBrush.
			Blend blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
			linGrBrush.Blend = blend;

			//e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
			e.Graphics.FillRectangle(linGrBrush, 0, 0, 900, 1000);

		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox textBox1;
		private Button button1;
		private Button button2;
		private Label label1;
		private Label label2;
	}
}
