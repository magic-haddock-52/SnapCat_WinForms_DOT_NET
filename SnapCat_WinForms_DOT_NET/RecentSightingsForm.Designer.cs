
using System.Drawing.Drawing2D;

namespace SnapCat_WinForms_DOT_NET
{
	partial class RecentSightingsForm
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
			button2 = new Button();
			label4 = new Label();
			recentViewLabel = new Label();
			recentReportLabel = new Label();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Location = new Point(307, 796);
			button2.Name = "button2";
			button2.Size = new Size(226, 94);
			button2.TabIndex = 4;
			button2.Text = "Report a Sighting";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
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
			label4.TabIndex = 10;
			label4.Text = "|";
			// 
			// recentViewLabel
			// 
			recentViewLabel.AutoSize = true;
			recentViewLabel.BackColor = Color.Transparent;
			recentViewLabel.Font = new Font("Georgia", 24F, FontStyle.Bold | FontStyle.Underline);
			recentViewLabel.ForeColor = Color.White;
			recentViewLabel.Location = new Point(849, 69);
			recentViewLabel.Name = "recentViewLabel";
			recentViewLabel.Size = new Size(518, 72);
			recentViewLabel.TabIndex = 9;
			recentViewLabel.Text = "View Sightings";
			recentViewLabel.Click += recentViewLabel_Click;
			// 
			// recentReportLabel
			// 
			recentReportLabel.AutoSize = true;
			recentReportLabel.BackColor = Color.Transparent;
			recentReportLabel.Font = new Font("Georgia", 24F, FontStyle.Bold);
			recentReportLabel.ForeColor = Color.White;
			recentReportLabel.Location = new Point(1542, 69);
			recentReportLabel.Name = "recentReportLabel";
			recentReportLabel.Size = new Size(604, 72);
			recentReportLabel.TabIndex = 8;
			recentReportLabel.Text = "Report a Sighting";
			recentReportLabel.Click += recentReportLabel_Click;
			// 
			// RecentSightingsForm
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2854, 1729);
			Controls.Add(label4);
			Controls.Add(recentViewLabel);
			Controls.Add(recentReportLabel);
			Controls.Add(button2);
			Name = "RecentSightingsForm";
			Text = "RecentSightingsForm";
			WindowState = FormWindowState.Maximized;
			Load += RecentSightingsForm_Load;
			Paint += set_background;
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

		private Button button2;
		private Label label4;
		private Label recentViewLabel;
		private Label recentReportLabel;
	}
}