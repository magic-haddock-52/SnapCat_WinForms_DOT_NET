using System.Drawing.Drawing2D;
using System.Windows.Forms;

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
			reportLabel = new Label();
			label2 = new Label();
			viewLabel = new Label();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.White;
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = Properties.Resources.camera_temp;
			pictureBox1.Location = new Point(592, 487);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(907, 798);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(1636, 599);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(510, 448);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(1682, 1106);
			button1.Name = "button1";
			button1.Size = new Size(177, 99);
			button1.TabIndex = 2;
			button1.Text = "Select Image";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(1915, 1106);
			button2.Name = "button2";
			button2.Size = new Size(177, 99);
			button2.TabIndex = 3;
			button2.Text = "Upload";
			button2.UseVisualStyleBackColor = true;
			// 
			// reportLabel
			// 
			reportLabel.AutoSize = true;
			reportLabel.BackColor = Color.Transparent;
			reportLabel.Font = new Font("Georgia", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			reportLabel.ForeColor = Color.White;
			reportLabel.Location = new Point(1542, 69);
			reportLabel.Name = "reportLabel";
			reportLabel.Size = new Size(604, 72);
			reportLabel.TabIndex = 4;
			reportLabel.Text = "Report a Sighting";
			reportLabel.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Georgia", 12F);
			label2.ForeColor = Color.White;
			label2.Location = new Point(1636, 558);
			label2.Name = "label2";
			label2.Size = new Size(85, 38);
			label2.TabIndex = 5;
			label2.Text = "Info:";
			label2.Click += label2_Click;
			// 
			// viewLabel
			// 
			viewLabel.AutoSize = true;
			viewLabel.BackColor = Color.Transparent;
			viewLabel.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			viewLabel.ForeColor = Color.White;
			viewLabel.Location = new Point(849, 69);
			viewLabel.Name = "viewLabel";
			viewLabel.Size = new Size(518, 72);
			viewLabel.TabIndex = 6;
			viewLabel.Text = "View Sightings";
			viewLabel.Click += viewLabel_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.White;
			label4.Location = new Point(1444, 69);
			label4.Name = "label4";
			label4.Size = new Size(55, 72);
			label4.TabIndex = 7;
			label4.Text = "|";
			label4.Click += reportLabel_Click;
			// 
			// SightingsForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(2854, 1729);
			Controls.Add(label4);
			Controls.Add(viewLabel);
			Controls.Add(label2);
			Controls.Add(reportLabel);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(pictureBox1);
			Name = "SightingsForm";
			Text = "SnapCat";
			WindowState = FormWindowState.Maximized;
			Paint += set_background;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private void set_background(object sender, PaintEventArgs e)
		{
			Rectangle screen = Screen.FromControl(this).Bounds;
			Width = screen.Width;
			Height = screen.Height;

			LinearGradientBrush linGrBrush = new LinearGradientBrush(
				new Point(0, 0),
				//new Point(500, 500),
				new Point(0, Height), 
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
			e.Graphics.FillRectangle(linGrBrush, 0, 0, Width, Height);

		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox textBox1;
		private Button button1;
		private Button button2;
		private Label reportLabel;
		private Label label2;
		private Label viewLabel;
		private Label label4;
	}
}
