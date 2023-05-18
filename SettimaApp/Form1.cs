namespace SettimaApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEstrai_Click(object sender, EventArgs e)
		{
			// prendo il testo dell'utente
			string daAnalizzare = txtTesto.Text;
			// riduco i caratteri che potrebbero darmi noia a soli spazi
			daAnalizzare = daAnalizzare.Replace(",", " ");
			daAnalizzare = daAnalizzare.Replace(".", " ");
			daAnalizzare = daAnalizzare.Replace(":", " ");
			daAnalizzare = daAnalizzare.Replace(";", " ");
			daAnalizzare = daAnalizzare.Replace("?", " ");
			daAnalizzare = daAnalizzare.Replace("!", " ");
			// spezzo tutto il testo per spazio per avere le singole parole
			string[] parole = daAnalizzare.Split(" ");
			lstRisultati.Items.Add($"numero di caratteri: {daAnalizzare.Length}");
			lstRisultati.Items.Add($"numero di parole: {parole.Length}");
			// mi costruisco un archivio per poterle contare
			Dictionary<string,int> archivio = new Dictionary<string,int>();
			// per ogni parola
			foreach(string singola in parole)
			{
				// se è presente
				if (archivio.ContainsKey(singola))
				{
					// segno la nuova quantità
					archivio[singola] = archivio[singola] + 1;
				} else
				{
					// altrimenti la imposto in archivio come quantità = 1
					archivio.Add(singola, 1);
					// e scrivo a schermo il suo valore
					lstRisultati.Items.Add (singola);
				}
			}
			// ruordino l'archivio
			archivio.OrderByDescending(elemento => elemento.Value);
			// svuoto la lista
			lstRisultati.Items.Clear();
			// ricarico nella lista quelli che sono gli elementi dell'archivio ordinato

			lstRisultati.Items.Add($"Numero di parole singole: {archivio.Count}");
		}
	}
}