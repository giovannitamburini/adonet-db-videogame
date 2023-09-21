// See https://aka.ms/new-console-template for more information

/*
Vogliamo realizzare un programma che permetta di gestire i videogiochi che verranno utilizzati nei tornei.
Creiamo quindi una console app che all'avvio mostra un menu con la possibilità di :
1 - inserire un nuovo videogioco
2 - ricercare un videogioco per id
3 - ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
4 - cancellare un videogioco
5 - chiudere il programma

In base alla voce selezionata richiedere le informazioni necessarie per effettuare l'operazione desiderata.

Prevedere tutti i controlli di validazione dei dati (ad esempio non si può inserire un videogioco senza specificare il nome).
In caso di errori lanciare un'eccezione (che deve essere gestita a più alto livello).

Creare una classe VideogameManager che esponga tutti i metodi necessari al programma (es. InserisciVideogame(…), GetVideogameById(..), etc…).

Creare una classe Videogame da passare come parametro al metodo di inserimento nuovo videogioco e che venga restituita dai metodi di ricerca.
*/

using System.Data.SqlClient;

Console.Write("Prima di effettuare l'accesso inserisci il tuo nome utente: ");
string userName = Console.ReadLine();

Console.WriteLine($"Benvenuto {userName} nel sistema di gestione dei videogames che vengono utilizzati nei tornei");

while (true)
{


    Console.WriteLine(@"
1 - inserire un nuovo videogioco
2 - ricercare un videogioco per id
3 - ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
4 - cancellare un videogioco
5 - chiudere il programma
");

    Console.Write("Prego seleziona l'opzione che desideri effettuare: ");
    int selectedOption = int.Parse(Console.ReadLine());


    switch (selectedOption)
    {
        case 1:

            Console.WriteLine("Hai selezionato l'opzione 1: inserire un nuovo videogioco");

            break;
        case 2:

            Console.WriteLine("Hai selezionato l'opzione 2: ricercare un videogioco per id");

            break;
        case 3:

            Console.WriteLine("Hai selezionato l'opzione 3: ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input");

            break;
        case 4:

            Console.WriteLine("Hai selezionato l'opzione 4: cancellare un videogioco");

            break;
        case 5:

            Console.WriteLine("Hai selezionato l'opzione 5: chiudere il programma");

            break;

        default:
            Console.WriteLine("Non hai selezionato un opzione valida");
            break;
    }
}

