// Användar inmattning
using System.IO.Compression;
using System.Runtime.ExceptionServices;

Console.WriteLine("Bräd storlek?");
string chessBoardSize = Console.ReadLine();

// Parsar string -> int
int storlek = Int32.Parse(chessBoardSize);

// print brädstorlek 
Console.WriteLine(storlek);

// While-loop med nest for-loop och if-sats som checkar udda/jämna tal, sedan skriver ut rätt ruta beroende på jämna/udda tal samt beroende på om rad nummret är udda/jämn.
int i = 0;
while (i < storlek)
{
    for (int y = 0; y < storlek; y++)
        {
            if ((i + y) % 2 == 0) {
            Console.Write("◼︎");
            } else {
            Console.Write("◻︎");
            }
        }
    Console.WriteLine("");
    i++;
    }