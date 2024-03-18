using System.Drawing.Drawing2D;

namespace SnapCat_WinForms_DOT_NET
{
	public partial class SightingsForm : Form
	{
		public SightingsForm()
		{
			InitializeComponent();
		}



		public void CustomizeLinearGradients(PaintEventArgs e)
		{
			LinearGradientBrush linGrBrush = new LinearGradientBrush(
			   new Point(0, 10),
			   new Point(200, 10),
			   Color.FromArgb(255, 0, 0, 0),     // Opaque black
			   Color.FromArgb(255, 255, 0, 0));  // Opaque red

			float[] relativeIntensities = { 0.0f, 0.5f, 1.0f };
			float[] relativePositions = { 0.0f, 0.2f, 1.0f };

			//Create a Blend object and assign it to linGrBrush.
			Blend blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
			linGrBrush.Blend = blend;

			e.Graphics.FillEllipse(linGrBrush, 0, 30, 200, 100);
			e.Graphics.FillRectangle(linGrBrush, 0, 155, 500, 30);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
