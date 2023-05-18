namespace QuintaApp
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
			btnCarica = new Button();
			btnSalva = new Button();
			btnEsci = new Button();
			SuspendLayout();
			// 
			// txtTesto
			// 
			txtTesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtTesto.Location = new Point(20, 74);
			txtTesto.Margin = new Padding(5, 5, 5, 5);
			txtTesto.Multiline = true;
			txtTesto.Name = "txtTesto";
			txtTesto.Size = new Size(689, 561);
			txtTesto.TabIndex = 0;
			txtTesto.Text = "quello che è scritto nel campo di testo";
			// 
			// btnCarica
			// 
			btnCarica.Location = new Point(20, 18);
			btnCarica.Margin = new Padding(5, 5, 5, 5);
			btnCarica.Name = "btnCarica";
			btnCarica.Size = new Size(153, 46);
			btnCarica.TabIndex = 1;
			btnCarica.Text = "carica";
			btnCarica.UseVisualStyleBackColor = true;
			btnCarica.Click += btnCarica_Click;
			// 
			// btnSalva
			// 
			btnSalva.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnSalva.Location = new Point(182, 18);
			btnSalva.Margin = new Padding(5, 5, 5, 5);
			btnSalva.Name = "btnSalva";
			btnSalva.Size = new Size(378, 46);
			btnSalva.TabIndex = 2;
			btnSalva.Text = "salva";
			btnSalva.UseVisualStyleBackColor = true;
			btnSalva.Click += btnSalva_Click;
			// 
			// btnEsci
			// 
			btnEsci.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnEsci.Location = new Point(569, 19);
			btnEsci.Margin = new Padding(5, 5, 5, 5);
			btnEsci.Name = "btnEsci";
			btnEsci.Size = new Size(141, 45);
			btnEsci.TabIndex = 3;
			btnEsci.Text = "esci";
			btnEsci.UseVisualStyleBackColor = true;
			btnEsci.Click += btnEsci_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(730, 656);
			Controls.Add(btnEsci);
			Controls.Add(btnSalva);
			Controls.Add(btnCarica);
			Controls.Add(txtTesto);
			Margin = new Padding(5, 5, 5, 5);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtTesto;
		private Button btnCarica;
		private Button btnSalva;
		private Button btnEsci;
	}
}