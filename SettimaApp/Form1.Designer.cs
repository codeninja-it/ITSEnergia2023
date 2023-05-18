namespace SettimaApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtTesto = new TextBox();
			btnEstrai = new Button();
			lstRisultati = new ListBox();
			SuspendLayout();
			// 
			// txtTesto
			// 
			txtTesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtTesto.Location = new Point(12, 12);
			txtTesto.Multiline = true;
			txtTesto.Name = "txtTesto";
			txtTesto.ScrollBars = ScrollBars.Vertical;
			txtTesto.Size = new Size(809, 707);
			txtTesto.TabIndex = 0;
			// 
			// btnEstrai
			// 
			btnEstrai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnEstrai.Location = new Point(12, 725);
			btnEstrai.Name = "btnEstrai";
			btnEstrai.Size = new Size(809, 46);
			btnEstrai.TabIndex = 1;
			btnEstrai.Text = "estrai";
			btnEstrai.UseVisualStyleBackColor = true;
			btnEstrai.Click += btnEstrai_Click;
			// 
			// lstRisultati
			// 
			lstRisultati.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			lstRisultati.FormattingEnabled = true;
			lstRisultati.ItemHeight = 32;
			lstRisultati.Location = new Point(837, 12);
			lstRisultati.Name = "lstRisultati";
			lstRisultati.Size = new Size(519, 740);
			lstRisultati.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1368, 788);
			Controls.Add(lstRisultati);
			Controls.Add(btnEstrai);
			Controls.Add(txtTesto);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtTesto;
		private Button btnEstrai;
		private ListBox lstRisultati;
	}
}