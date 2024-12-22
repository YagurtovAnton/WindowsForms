using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clock
{
	public partial class ChooseFontForm : Form
	{
		public ChooseFontForm()
		{
			InitializeComponent();
			LoadFonts();
		}

		void LoadFonts()
		{
			Directory.SetCurrentDirectory("..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());

			
		
		}

		private void btnok_click(object sender, EventArgs e)
		{
		}
	}
}
