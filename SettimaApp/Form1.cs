namespace SettimaApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string PulisciTesto(string testo)
		{
			string nuovo = "";
			string buoni = "abcdefghilmnopqrstuvzxyjkàèéìòù0123456789";
			testo = testo.ToLower().Trim();
			foreach(char carattere in testo)
			{
				if (buoni.Contains(carattere))
				{
					nuovo = nuovo + carattere;
				} else
				{
					nuovo = nuovo + " ";
				}
			}

			return nuovo;
		}

		private void btnEstrai_Click(object sender, EventArgs e)
		{
			// prendo il testo dell'utente
			string daAnalizzare = txtTesto.Text;
			// riduco i caratteri che potrebbero darmi noia a soli spazi
			daAnalizzare = PulisciTesto(daAnalizzare);
			// decido che alcune parole sono da evitare
			string[] daEvitare = new string[]{"", "a", "abbastanza", "abbia", "abbiamo", "abbiano", "abbiate", "accidenti", "ad", "adesso", "affinché", "agl", "agli", "ahime", "ahimè", "ai", "al", "alcuna", "alcuni", "alcuno", "all", "alla", "alle", "allo", "allora", "altre", "altri", "altrimenti", "altro", "altrove", "altrui", "anche", "ancora", "anni", "anno", "ansa", "anticipo", "assai", "attesa", "attraverso", "avanti", "avemmo", "avendo", "avente", "aver", "avere", "averlo", "avesse", "avessero", "avessi", "avessimo", "aveste", "avesti", "avete", "aveva", "avevamo", "avevano", "avevate", "avevi", "avevo", "avrai", "avranno", "avrebbe", "avrebbero", "avrei", "avremmo", "avremo", "avreste", "avresti", "avrete", "avrà", "avrò", "avuta", "avute", "avuti", "avuto", "basta", "ben", "bene", "benissimo", "brava", "bravo", "buono", "c", "caso", "cento", "certa", "certe", "certi", "certo", "che", "chi", "chicchessia", "chiunque", "ci", "ciascuna", "ciascuno", "cima", "cinque", "cio", "cioe", "cioè", "circa", "citta", "città", "ciò", "co", "codesta", "codesti", "codesto", "cogli", "coi", "col", "colei", "coll", "coloro", "colui", "come", "cominci", "comprare", "comunque", "con", "concernente", "conclusione", "consecutivi", "consecutivo", "consiglio", "contro", "cortesia", "cos", "cosa", "cosi", "così", "cui", "d", "da", "dagl", "dagli", "dai", "dal", "dall", "dalla", "dalle", "dallo", "dappertutto", "davanti", "degl", "degli", "dei", "del", "dell", "della", "delle", "dello", "dentro", "detto", "deve", "devo", "di", "dice", "dietro", "dire", "dirimpetto", "diventa", "diventare", "diventato", "dopo", "doppio", "dov", "dove", "dovra", "dovrà", "dovunque", "due", "dunque", "durante", "e", "ebbe", "ebbero", "ebbi", "ecc", "ecco", "ed", "effettivamente", "egli", "ella", "entrambi", "eppure", "era", "erano", "eravamo", "eravate", "eri", "ero", "esempio", "esse", "essendo", "esser", "essere", "essi", "ex", "fa", "faccia", "facciamo", "facciano", "facciate", "faccio", "facemmo", "facendo", "facesse", "facessero", "facessi", "facessimo", "faceste", "facesti", "faceva", "facevamo", "facevano", "facevate", "facevi", "facevo", "fai", "fanno", "farai", "faranno", "fare", "farebbe", "farebbero", "farei", "faremmo", "faremo", "fareste", "faresti", "farete", "farà", "farò", "fatto", "favore", "fece", "fecero", "feci", "fin", "finalmente", "finche", "fine", "fino", "forse", "forza", "fosse", "fossero", "fossi", "fossimo", "foste", "fosti", "fra", "frattempo", "fu", "fui", "fummo", "fuori", "furono", "futuro", "generale", "gente", "gia", "giacche", "giorni", "giorno", "giu", "già", "gli", "gliela", "gliele", "glieli", "glielo", "gliene", "grande", "grazie", "gruppo", "ha", "haha", "hai", "hanno", "ho", "i", "ie", "ieri", "il", "improvviso", "in", "inc", "indietro", "infatti", "inoltre", "insieme", "intanto", "intorno", "invece", "io", "l", "la", "lasciato", "lato", "le", "lei", "li", "lo", "lontano", "loro", "lui", "lungo", "luogo", "là", "ma", "macche", "magari", "maggior", "mai", "male", "malgrado", "malissimo", "me", "medesimo", "mediante", "meglio", "meno", "mentre", "mesi", "mezzo", "mi", "mia", "mie", "miei", "mila", "miliardi", "milioni", "minimi", "mio", "modo", "molta", "molti", "moltissimo", "molto", "momento", "mondo", "ne", "negl", "negli", "nei", "nel", "nell", "nella", "nelle", "nello", "nemmeno", "neppure", "nessun", "nessuna", "nessuno", "niente", "no", "noi", "nome", "non", "nondimeno", "nonostante", "nonsia", "nostra", "nostre", "nostri", "nostro", "novanta", "nove", "nulla", "nuovi", "nuovo", "o", "od", "oggi", "ogni", "ognuna", "ognuno", "oltre", "oppure", "ora", "ore", "osi", "ossia", "ottanta", "otto", "paese", "parecchi", "parecchie", "parecchio", "parte", "partendo", "peccato", "peggio", "per", "perche", "perchè", "perché", "percio", "perciò", "perfino", "pero", "persino", "persone", "però", "piedi", "pieno", "piglia", "piu", "piuttosto", "più", "po", "pochissimo", "poco", "poi", "poiche", "possa", "possedere", "posteriore", "posto", "potrebbe", "preferibilmente", "presa", "press", "prima", "primo", "principalmente", "probabilmente", "promesso", "proprio", "puo", "pure", "purtroppo", "può", "qua", "qualche", "qualcosa", "qualcuna", "qualcuno", "quale", "quali", "qualunque", "quando", "quanta", "quante", "quanti", "quanto", "quantunque", "quarto", "quasi", "quattro", "quel", "quella", "quelle", "quelli", "quello", "quest", "questa", "queste", "questi", "questo", "qui", "quindi", "quinto", "realmente", "recente", "recentemente", "registrazione", "relativo", "riecco", "rispetto", "salvo", "sara", "sarai", "saranno", "sarebbe", "sarebbero", "sarei", "saremmo", "saremo", "sareste", "saresti", "sarete", "sarà", "sarò", "scola", "scopo", "scorso", "se", "secondo", "seguente", "seguito", "sei", "sembra", "sembrare", "sembrato", "sembrava", "sembri", "sempre", "senza", "sette", "si", "sia", "siamo", "siano", "siate", "siete", "sig", "solito", "solo", "soltanto", "sono", "sopra", "soprattutto", "sotto", "spesso", "sta", "stai", "stando", "stanno", "starai", "staranno", "starebbe", "starebbero", "starei", "staremmo", "staremo", "stareste", "staresti", "starete", "starà", "starò", "stata", "state", "stati", "stato", "stava", "stavamo", "stavano", "stavate", "stavi", "stavo", "stemmo", "stessa", "stesse", "stessero", "stessi", "stessimo", "stesso", "steste", "stesti", "stette", "stettero", "stetti", "stia", "stiamo", "stiano", "stiate", "sto", "su", "sua", "subito", "successivamente", "successivo", "sue", "sugl", "sugli", "sui", "sul", "sull", "sulla", "sulle", "sullo", "suo", "suoi", "tale", "tali", "talvolta", "tanto", "te", "tempo", "terzo", "th", "ti", "titolo", "tra", "tranne", "tre", "trenta", "triplo", "troppo", "trovato", "tu", "tua", "tue", "tuo", "tuoi", "tutta", "tuttavia", "tutte", "tutti", "tutto", "uguali", "ulteriore", "ultimo", "un", "una", "uno", "uomo", "va", "vai", "vale", "vari", "varia", "varie", "vario", "verso", "vi", "vicino", "visto", "vita", "voi", "volta", "volte", "vostra", "vostre", "vostri", "vostro", "è"};
			// spezzo tutto il testo per spazio per avere le singole parole
			string[] parole = daAnalizzare.Split(" ");
			lstRisultati.Items.Add($"numero di caratteri: {daAnalizzare.Length}");
			lstRisultati.Items.Add($"numero di parole: {parole.Length}");
			// mi costruisco un archivio per poterle contare
			Dictionary<string,int> archivio = new Dictionary<string,int>();
			// per ogni parola
			foreach(string singola in parole)
			{
				string parola = singola.ToLower().Trim();
				// se non è da evitare
				if (!daEvitare.Contains(parola) && parola.Length > 1)
				{
					// se è presente
					if (archivio.ContainsKey(parola))
					{
						// segno la nuova quantità
						archivio[parola] = archivio[parola] + 1;
					} else
					{
						// altrimenti la imposto in archivio come quantità = 1
						archivio.Add(parola, 1);
						// e scrivo a schermo il suo valore
						lstRisultati.Items.Add(parola);
					}
				}
				
			}
			// riordino l'archivio
			archivio = archivio.OrderByDescending(elemento => elemento.Value).ToDictionary(k => k.Key, v => v.Value);
			// svuoto la lista
			lstRisultati.Items.Clear();
			// ricarico nella lista quelli che sono gli elementi dell'archivio ordinato
			foreach (var elemento in archivio)
			{
				lstRisultati.Items.Add($"{elemento.Key}\t{elemento.Value}");
			}
			lstRisultati.Items.Add($"Numero di parole singole: {archivio.Count}");
		}
	}
}