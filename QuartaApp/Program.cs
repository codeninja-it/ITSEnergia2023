/*
 * D    on't
 * R    epeat
 * Y    ourself
 */

string chiedi(string domanda)
{
    Console.Write(domanda + ": ");
    return Console.ReadLine();
}

void analizza(string comando)
{
    if(comando == "nuovo")
    {

    } else if(comando == "modifica")
    {

    } else if (comando == "cancella")
    {

    } else if (comando == "vedi")
    {

    }
}

Contatto[] rubrica;



string nomeUtente = chiedi("Come ti chiami?");
Console.WriteLine("ciao " + nomeUtente);




/*
 * chiedere all'utente cosa vuole fare tra le operazioni concesse
 * C    reate
 * R    ead
 * U    pdate
 * D    elete
 * 
 * E    xit
 */

string comando = chiedi("Cosa vuoi fare?");
while (comando == "esci")
{
    analizza(comando);
}