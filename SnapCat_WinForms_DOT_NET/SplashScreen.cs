using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapCat_WinForms_DOT_NET
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
		}


		public void StartForm()
		{
			Application.Run(new SplashScreen());
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
