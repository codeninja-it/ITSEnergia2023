/*
 * D    on't
 * R    epeat
 * Y    ourself
 */

using QuartaApp;

Contatto[] rubrica = { };

string chiedi(string domanda)
{
    Console.Write(domanda + ": ");
    return Console.ReadLine();
}

void analizza(string comando)
{
    if(comando == "nuovo")
    {
        // costruiamo una nuova variabile a forma di contatto
        Contatto nuovo;
        nuovo = new Contatto();
        // la valorizziamo con i tre parametri che voglio conservare
        nuovo.nome = chiedi("Nome");
        nuovo.cognome = chiedi("Cognome");
        nuovo.telefono = chiedi("Telefono");
        // appendiamo l'elemento alla rubrica
        rubrica = rubrica.Append(nuovo).ToArray();
        Console.WriteLine($" {rubrica.Length} elementi presenti in rubrica");
    } else if(comando == "modifica")
    {

    } else if (comando == "cancella")
    {

    } else if (comando == "vedi")
    {
        string chi = chiedi("Chi stai cercando?");
        for (int i=0; i < rubrica.Length; i++)
        {
            Contatto selezionato = rubrica[i];
            if(selezionato.nome.Contains(chi))
            {
                Console.WriteLine($"{i}: {selezionato.nome} {selezionato.cognome} {selezionato.telefono} {selezionato.creazione}");
            }            
        }
    } else if (comando == "pulisci")
    {
        Console.Clear();
    } else if (comando == "orologio")
    {
        Console.WriteLine(  DateTime.Now  );
    }
}

/*
 * chiedere all'utente cosa vuole fare tra le operazioni concesse
 * C    reate
 * R    ead
 * U    pdate
 * D    elete
 * 
 * E    xit
 */

string comando = "";
while (comando != "esci")
{
    analizza(comando);
    comando = chiedi("Cosa vuoi fare?");
}