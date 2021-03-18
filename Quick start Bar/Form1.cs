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
		int labelNum = 5;
		int cButton = 5;
		int lButton = 5;
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
			if(openfileDlg.ShowDialog() == DialogResult.OK)
			{
				label2.Text = openfileDlg.FileName;
				dirs_List.Add(label2.Text);
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
			createNewLabel();
			createNewConfigureButton();
			createNewLaunchButton();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		public void createNewLabel()
		{
			Label label = new Label();
			label.Text = ("Hello world");
			label.Left = 10;
			label.Top = (labelNum + 1) * 30;
			this.Controls.Add(label);
			if (labelNum < 15)
			{
				labelNum++;
			}
		}
	

		public void createNewConfigureButton()
		{
			Button configureButton = new Button();
			configureButton.Size = new Size(55, 20);
			configureButton.Text = ("Change");
			configureButton.Left = 150;
			configureButton.Top = (cButton + 1) * 30;
			this.Controls.Add(configureButton);
			if (cButton < 15)
			{
				cButton++;
			}
		}

		void configureButton_Click(object sender, EventArgs )

		public void createNewLaunchButton()
		{
			Button launchButton = new Button();
			launchButton.Size = new Size(55, 20);
			launchButton.Text = ("Launch");
			launchButton.Left = 200;
			launchButton.Top = (lButton + 1) * 30;
			this.Controls.Add(launchButton);
			if(lButton < 15)
			{
				lButton++;
			}
		}




	}
}
