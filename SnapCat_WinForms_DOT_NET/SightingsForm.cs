using System.Drawing;
using System.Drawing.Drawing2D;

namespace SnapCat_WinForms_DOT_NET
{
	public partial class SightingsForm : Form
	{
		public SightingsForm()
		{
			InitializeComponent();
		}


		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int size = -1;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
			if (result == DialogResult.OK) // Test result.
			{
				string file = openFileDialog1.FileName;
				try
				{
					if(Path.GetExtension(file).Equals(".png")){ 
						string text = File.ReadAllText(file);
						size = text.Length;
						pictureBox1.Image = new Bitmap(file);
						//pictureBox1.Image = Image.FromFile(text);
						//Image.FromFile(text);
					}
				}
				catch (IOException)
				{
				}
			}
		}
		//bitmap, metafile, icon, JPEG, GIF, or PNG file
		//extensions of .bmp, .ico, .gif, .wmf, .jpg.
	}
}
