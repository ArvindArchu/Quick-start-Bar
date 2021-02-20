using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_start_Bar
{
	public partial class Start : Form
	{
		int height = SystemInformation.VirtualScreen.Height;
		int width = SystemInformation.VirtualScreen.Width;
		public Start()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(width - 284, 0);
			this.Size = new Size(284, width);				
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			notifyIcon1.Visible = true;
			
		}

		private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			this.Location = new Point(width - 50, height - 850);
		}
	}
}
