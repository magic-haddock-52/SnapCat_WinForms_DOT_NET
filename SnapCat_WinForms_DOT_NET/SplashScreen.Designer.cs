namespace SnapCat_WinForms_DOT_NET
{
	partial class SplashScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(952, 216);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1000, 1000);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Georgia", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(1146, 1270);
			label1.Name = "label1";
			label1.Size = new Size(612, 146);
			label1.TabIndex = 1;
			label1.Text = "SnapCat";
			label1.Click += label1_Click;
			// 
			// SplashScreen
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(2884, 1729);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "SplashScreen";
			Text = "SplashScreen";
			WindowState = FormWindowState.Maximized;
			Load += SplashScreen_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
	}
}