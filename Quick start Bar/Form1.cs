using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Quick_start_Bar
{
	public partial class Start : Form
	{
		List<string> dirs_List = new List<string>();
		int height = SystemInformation.VirtualScreen.Height;
		int width = SystemInformation.VirtualScreen.Width;
		public Start()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(width - 284, 0);
			this.Size = new Size(284, width);
			this.button3.Location = new Point(width - (width - 50), height - (height - 50));
		}

		//minimise button
		private void button1_Click(object sender, EventArgs e)
		{
			Hide();
			notifyIcon1.Visible = true;	
		}

		//restore size button
		private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon1.Visible = false;
		}

		//exit button
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//changing directory button
		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label2.Text = openfileDlg.FileName;
				dirs_List.Add(label2.Text);
			}

		}

		private void button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label3.Text = openfileDlg.FileName;
				dirs_List.Add(label3.Text);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label4.Text = openfileDlg.FileName;
				dirs_List.Add(label4.Text);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label5.Text = openfileDlg.FileName;
				dirs_List.Add(label5.Text);
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label6.Text = openfileDlg.FileName;
				dirs_List.Add(label6.Text);
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfileDlg = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Choose a Application",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "exe",
				Filter = "executables (*.exe)|*.exe",
				RestoreDirectory = true,

			};
			if (openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label7.Text = openfileDlg.FileName;
				dirs_List.Add(label7.Text);
			}
		}

		//launching application button
		private void button4_Click(object sender, EventArgs e)
		{

			if (label2.Text != String.Empty && System.IO.File.Exists(label2.Text))
			{
				System.Diagnostics.Process.Start(label2.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}

		}

		private void button5_Click(object sender, EventArgs e)
		{
		
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			if (label3.Text != String.Empty && System.IO.File.Exists(label3.Text))
			{
				System.Diagnostics.Process.Start(label3.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (label4.Text != String.Empty && System.IO.File.Exists(label4.Text))
			{
				System.Diagnostics.Process.Start(label4.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (label5.Text != String.Empty && System.IO.File.Exists(label5.Text))
			{
				System.Diagnostics.Process.Start(label5.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (label6.Text != String.Empty && System.IO.File.Exists(label6.Text))
			{
				System.Diagnostics.Process.Start(label6.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (label7.Text != String.Empty && System.IO.File.Exists(label7.Text))
			{
				System.Diagnostics.Process.Start(label7.Text);
			}
			else
			{
				Console.WriteLine("Process has not been selected");
			}
		}


	}
}
