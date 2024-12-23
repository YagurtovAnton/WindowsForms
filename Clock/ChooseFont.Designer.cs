namespace Clock
{
	partial class ChooseFontForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFontForm));
			this.cbFonts = new System.Windows.Forms.ComboBox();
			this.nudFontSize = new System.Windows.Forms.NumericUpDown();
			this.ChooseFont = new System.Windows.Forms.Label();
			this.FontSize = new System.Windows.Forms.Label();
			this.labelExample = new System.Windows.Forms.Label();
			this.btnCansel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// cbFonts
			// 
			this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFonts.FormattingEnabled = true;
			this.cbFonts.Location = new System.Drawing.Point(24, 35);
			this.cbFonts.Name = "cbFonts";
			this.cbFonts.Size = new System.Drawing.Size(491, 24);
			this.cbFonts.TabIndex = 0;
			// 
			// nudFontSize
			// 
			this.nudFontSize.Location = new System.Drawing.Point(509, 35);
			this.nudFontSize.Name = "nudFontSize";
			this.nudFontSize.Size = new System.Drawing.Size(120, 22);
			this.nudFontSize.TabIndex = 1;
			// 
			// ChooseFont
			// 
			this.ChooseFont.AutoSize = true;
			this.ChooseFont.Location = new System.Drawing.Point(24, 16);
			this.ChooseFont.Name = "ChooseFont";
			this.ChooseFont.Size = new System.Drawing.Size(80, 16);
			this.ChooseFont.TabIndex = 2;
			this.ChooseFont.Text = "ChooseFont";
		
			// 
			// FontSize
			// 
			this.FontSize.AutoSize = true;
			this.FontSize.Location = new System.Drawing.Point(509, 16);
			this.FontSize.Name = "FontSize";
			this.FontSize.Size = new System.Drawing.Size(60, 16);
			this.FontSize.TabIndex = 3;
			this.FontSize.Text = "Font size";
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Location = new System.Drawing.Point(24, 88);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(60, 16);
			this.labelExample.TabIndex = 4;
			this.labelExample.Text = "Example";
			// 
			// btnCansel
			// 
			this.btnCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCansel.Location = new System.Drawing.Point(537, 302);
			this.btnCansel.Name = "btnCansel";
			this.btnCansel.Size = new System.Drawing.Size(75, 23);
			this.btnCansel.TabIndex = 5;
			this.btnCansel.Text = "Cancel";
			this.btnCansel.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(456, 302);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "Ok";
			this.btnOK.UseVisualStyleBackColor = true;
			
			// 
			// ChooseFontForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 367);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCansel);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.FontSize);
			this.Controls.Add(this.ChooseFont);
			this.Controls.Add(this.nudFontSize);
			this.Controls.Add(this.cbFonts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ChooseFontForm";
			this.Text = "ChooseFont";
			((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbFonts;
		private System.Windows.Forms.NumericUpDown nudFontSize;
		private System.Windows.Forms.Label ChooseFont;
		private System.Windows.Forms.Label FontSize;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.Button btnCansel;
		private System.Windows.Forms.Button btnOK;
	}
}