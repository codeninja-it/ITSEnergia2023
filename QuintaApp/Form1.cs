namespace QuintaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            string testo = System.IO.File.ReadAllText("appunti.txt");
            txtTesto.Text = testo;
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string testo = txtTesto.Text;
            // lo scrivo nel file "appunti.txt"
            System.IO.File.WriteAllText("appunti.txt", testo);
        }
    }
}