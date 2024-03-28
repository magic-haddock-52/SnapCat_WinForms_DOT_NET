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
	public partial class RecentSightingsForm : Form
	{


		public RecentSightingsForm()
		{
			Thread t = new Thread(new ThreadStart(loadForm));
			t.Start();
			Thread.Sleep(5000);
			InitializeComponent();
		}

		public void loadForm()
		{
			Application.Run(new SplashScreen());
		}


		private void RecentSightingsForm_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void recentViewLabel_Click(object sender, EventArgs e)
		{

		}

		private void recentReportLabel_Click(object sender, EventArgs e)
		{
			var frm = new SightingsForm();
			frm.Location = this.Location;
			frm.StartPosition = FormStartPosition.Manual;
			frm.FormClosing += delegate { this.Show(); };
			frm.Show();
			this.Hide();
		}
	}
}
