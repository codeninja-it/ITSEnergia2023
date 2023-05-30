using System.Text.RegularExpressions;

namespace RegEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string dacercare = @"(\d*);(\d*);\w*;error";
            MatchCollection trovati = Regex.Matches(txtTesto.Text, dacercare, RegexOptions.Multiline);
            foreach (Match singolo in trovati)
            {
                string idCentralina = singolo.Groups[1].Value;
                string voltaggio = singolo.Groups[2].Value;
                lstRisultati.Items.Add($"{DateTime.Now}\tcentralina {idCentralina} con voltaggio {voltaggio}volt");
            }
        }

        private void orologio_Tick(object sender, EventArgs e)
        {
            lstRisultati.Items.Clear();
            string dacercare = @"(\d*);(\d*);\w*;error";
            MatchCollection trovati = Regex.Matches(txtTesto.Text, dacercare, RegexOptions.Multiline);
            foreach (Match singolo in trovati)
            {
                string idCentralina = singolo.Groups[1].Value;
                string voltaggio = singolo.Groups[2].Value;
                lstRisultati.Items.Add($"{DateTime.Now}\tcentralina {idCentralina} con voltaggio {voltaggio}volt");
            }
        }
    }
}