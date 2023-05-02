bool casella = true; // bool: true, false
bool muro = false;
char carattere = 'c';
string testo = "ciao a tutti!";
uint numeroIntero = 1;
double numeroDecimale = 1.2;

bool[] riga = { true, false, true, true, true, true };

int indice = 0;
while (indice < riga.Length)
{
    Console.WriteLine(riga[indice]);
    indice = indice + 1;
}
//bool[][] scacchiera = {};
//scacchiera[0][0] = true;
//scacchiera[0][1] = false;
bool[,] scacchiera = {
                        {true, false, true, true, true,  true},
                        {true, false, true, true, false, false},
                        {true, false, true, true, false, true},
                        {true, true,  true, true, true,  true },
                        {true, false, false, false, true, false },
                        {true, true, false, true, true, true }
                     };

void disegnaScacchiera(int[] utente)
{
    int xMax = scacchiera.GetLength(0);
    int yMax = scacchiera.GetLength(1);
    for(int x=0; x < xMax; x++)
    {
        for(int y=0; y < yMax; y++)
        {
            if (utente[0] == x && utente[1] == y)
            {
                Console.Write("A");
            } else
            {
                //{x,y}
                if (scacchiera[x,y] == true)
                {
                    Console.Write("_");
                } else
                {
                    Console.Write("X");
                }
            }
        }
        Console.WriteLine();
    }
    Console.ReadLine();
    Console.Clear();
}


/*
 * partendo da un punto, devo arrivare in un altro punto
 * partendo da un punto, devo controllare se sono arrivato in un altro punto, altrimenti mi sposto
 * S10000
 * 010011
 * 010010
 * 000000
 * 011101
 * 00000F 
 */

int[] partenza = { 0, 0 };
int[] arrivo = { 5, 5 };

attraversa(partenza, arrivo);

void attraversa(int[] da, int[] a)
{
    disegnaScacchiera(da);
    scacchiera[da[0], da[1]] = false;
    if (da[0] == a[0] && da[1] == a[1])
    {
        Console.WriteLine("Sono arrivato!");
        Console.ReadLine();
    } else
    {
        int x = da[0]; // +1 -1
        int y = da[1]; // +1 -1
        if(x+1 < scacchiera.GetLength(0) && scacchiera[x+1, y])
        {
            // posso spostarmi a destra perchè sono ancora sulla scacchiera e non c'è un muro
            int[] destra = { x + 1, y };
            attraversa(destra, a);
        }
        if(x-1 > 0 && scacchiera[x-1, y])
        {
            // posso spostarmi a sinistra perchè sono ancora nella scacchiera e non c'è un muro
            int[] sinistra = { x - 1, y };
            attraversa(sinistra, a);
        }
        if(y+1 < scacchiera.GetLength(1) && scacchiera[x, y + 1])
        {
            // posso spostarmi verso il basso perchè sono nella scacchiera e non c'è un muro
            int[] giu = { x, y + 1 };
            attraversa(giu, a);
        }
        if(y-1 > 0 && scacchiera[x, y - 1])
        {
            // posso salire e la strada è libera
            int[] su = { x, y - 1 };
            attraversa(su, a);
        }
    }
}