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
			labelTime.BackColor=Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			SetVisibilidity(false);
		}
		
		void SetVisibilidity(bool visible)
		{
			cbShowTime.Visible = visible;
			cbShowWeekDay.Visible = visible;
			btnHideControls.Visible = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor; ;
			this.FormBorderStyle = visible ?FormBorderStyle.FixedToolWindow: FormBorderStyle.None;
			this.ShowInTaskbar = visible;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
			if (cbShowTime.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.ToString("yyyy:ss");
			}
			if (cbShowWeekDay.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = labelTime.Text;

		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			cbShowTime.Visible = false;
			btnHideControls.Visible = false;
			this.TransparencyKey = this.BackColor;
			this.FormBorderStyle = FormBorderStyle.None;
			labelTime.BackColor = Color.AliceBlue;
			this.ShowInTaskbar = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			/*MessageBox.Show
				(
				this,
				"Похравляем, вы заполучили камнем времени",
				"info",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
				);
			cbShowTime.Visible = true;
			btnHideControls.Visible = true;
			this.TransparencyKey = Color.Empty;
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			labelTime.BackColor = Color.AliceBlue;
			this.ShowInTaskbar = true;*/
			//SetVisibilidity(true);
			SetVisibilidity(cmShowControls.Checked = false);
		}


		private void cmExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost=cmTopmost.Checked;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked=cbShowTime.Checked;
		}
		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekDay.Checked=cmShowWeekDay.Checked;
		}

		private void cmShowWeekDay_Click(object sender, EventArgs e)
		{
			cmShowWeekDay.Checked = cbShowWeekDay.Checked;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if(!this.TopMost)
			{
				this.TopMost=true;
				this.TopMost = false;
			}
		}

		private void cmShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibilidity(cmShowControls.Checked);
		}

		private void labelTime_Click(object sender, EventArgs e)
		{

		}

		private void SetColor(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			switch ((sender as ToolStripMenuItem).Text)
			{
				case "Background color": dialog.Color = labelTime.BackColor; break;
				case "Foreground color": dialog.Color = labelTime.ForeColor; break;
			}
			dialog.Color=labelTime.BackColor;
			if(dialog.ShowDialog() == DialogResult.OK)
				//labelTime.BackColor=dialog.Color;
			{
				switch((sender as ToolStripMenuItem).Text)
				{
					case "Background color":labelTime.BackColor=dialog.Color; break;
					case "Foreground color":labelTime.ForeColor=dialog.Color; break;
				}
			}
		}
	}
	
}
