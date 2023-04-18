using System;

int chiedi(string domanda){
    // chiedo all'utente che tabellina vuole
    Console.Write(domanda);
    var risposta = Console.ReadLine();
    var numero = int.Parse(risposta);
    return numero;
}

int moltiplicazione(int a, int b)
{
    // calcolo la moltpilicazione
    int risultato = a * b;
    // restituisco il risultato
    return risultato;
}



var numero = chiedi("Tabellina : ");
var ripetizioni = chiedi("Ripetizioni : ");

Console.WriteLine("controllo in testa");
// sfrutto una variabile per ricordarmi 1
var volta = 0;
// ripeto per 100 volte 
while (volta < ripetizioni)
{
    Console.Write(numero);
    Console.Write(" x ");
    Console.Write(volta);
    Console.Write(" = ");
    // il risultato della tabellina
    Console.WriteLine(   moltiplicazione(numero, volta)  );
    // ricordandomi di cambiare lo stato
    volta = volta + 1;
}