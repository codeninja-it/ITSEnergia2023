// scrivere un commento

/*
posso scrivere un commento su
più righe
 */

//costruisco una variabile
var variabile = 2;

Console.WriteLine(variabile);

variabile = variabile + 1;

Console.WriteLine(variabile);

if (variabile > 2)
    Console.WriteLine("è maggiore!");
else
{
    Console.WriteLine("è minore...");
    Console.WriteLine("...sì, decisamente...");
}

// funzione con un parametro che restituisce un risultato
string chiedi(string domanda)
{
    // parla con l'utente
    Console.WriteLine(domanda);
    // ascolta l'utente
    string risposta = Console.ReadLine();
    risposta = risposta.ToLower();
    risposta = risposta.Trim();
    // butta fuori a chi mi ha chiamata un risultato
    return risposta;
}

var comando = "";
do
{
    comando = chiedi("cosa vuoi...");

    switch (comando)
    {
        case "buongiorno":
        case "buona sera":
        case "ciao":
            var orario = DateTime.Now;
            if (orario.TimeOfDay.Hours < 13)
                Console.WriteLine("Buongiorno!");
            else if (orario.TimeOfDay.Hours < 23)
                Console.WriteLine("Buona sera!");
            else
                Console.WriteLine("Buona notte!");
            break;
        case "che ore sono":
            Console.WriteLine( DateTime.Now.TimeOfDay );
            break;
        case "che giorno siamo":
        case "che giorno è":
            Console.WriteLine( DateTime.Today );
            break;

        case "aiuto":
            Console.WriteLine("I comandi che conosco sono:");
            Console.WriteLine("\t- che ore sono");
            Console.WriteLine("\t- che giorno è");
            Console.WriteLine("\t- ciao");
            break;

        default:
            /*
             *  \n  carattere ascii 10  new line
             *  \r  carattere ascii 13  carriage raturn
             *  \t  carattere ascii 9   tabulatore
             *  \"  carattere ascii 34  virgolette
             */
            Console.WriteLine("non ho capito...\npuoi ripetere?");
            break;
    }

} while (comando != "esci");