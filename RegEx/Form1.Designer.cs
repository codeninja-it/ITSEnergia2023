namespace RegEx
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
            components = new System.ComponentModel.Container();
            txtTesto = new TextBox();
            lstRisultati = new ListBox();
            btnEsegui = new Button();
            orologio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // txtTesto
            // 
            txtTesto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTesto.Location = new Point(12, 12);
            txtTesto.Multiline = true;
            txtTesto.Name = "txtTesto";
            txtTesto.Size = new Size(1048, 504);
            txtTesto.TabIndex = 0;
            // 
            // lstRisultati
            // 
            lstRisultati.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstRisultati.FormattingEnabled = true;
            lstRisultati.ItemHeight = 32;
            lstRisultati.Location = new Point(1066, 12);
            lstRisultati.Name = "lstRisultati";
            lstRisultati.Size = new Size(723, 548);
            lstRisultati.TabIndex = 1;
            // 
            // btnEsegui
            // 
            btnEsegui.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEsegui.Location = new Point(12, 522);
            btnEsegui.Name = "btnEsegui";
            btnEsegui.Size = new Size(1048, 46);
            btnEsegui.TabIndex = 2;
            btnEsegui.Text = "esegui";
            btnEsegui.UseVisualStyleBackColor = true;
            btnEsegui.Click += btnEsegui_Click;
            // 
            // orologio
            // 
            orologio.Enabled = true;
            orologio.Interval = 5000;
            orologio.Tick += orologio_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 580);
            Controls.Add(btnEsegui);
            Controls.Add(lstRisultati);
            Controls.Add(txtTesto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTesto;
        private ListBox lstRisultati;
        private Button btnEsegui;
        private System.Windows.Forms.Timer orologio;
    }
}