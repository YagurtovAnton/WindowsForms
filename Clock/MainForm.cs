using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
			if (cbShowTime.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.ToString("yyyy:ss");
			}
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			cbShowTime.Visible = false;
			btnHideControls.Visible = false;
			this.TransparencyKey = this.BackColor;
			this.FormBorderStyle=FormBorderStyle.None;
			labelTime.BackColor = Color.AliceBlue;
			this.ShowInTaskbar = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show
				(
				this,
				"Похравляем, вы заполучили камнем времени",
				"info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
				);
		}
	}
}
