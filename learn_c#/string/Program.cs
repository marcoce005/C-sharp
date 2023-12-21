using System;

namespace prova
{
    class program
    {
        static void Main()
        {
            String parola = "pippo pluto";

            Console.WriteLine("ciao {0}", parola);
            Console.WriteLine(parola.Length);       // lunghezza della parola / stringa

            Console.WriteLine(parola.IndexOf("pl"));           // restituisce la locazione ch appare per la prima volta di quel pezzo di stringa -- da (-1) se non c'e'
                                                               // si puo' anche passare l'indice da cui partire

            Console.WriteLine(parola.Equals("pippopluto"));    // restituisce un bool T-F
            Console.WriteLine(parola.CompareTo("gino va al mercato"));          // restiuisce -1 se il primo e' maggiore, 0 se sono uguali, 1 se il secondo e' maggiore o se confrontato con un 'null'
                                                                                // c'e' anche il compare ordinar che si usa con caratteri speciali ma con stesso significato

            // SUBSTRING
            String x = parola.Substring(3);
            Console.WriteLine(x);       // crea una nuova stringa dall'indice dato

            var arr = parola.Split(" ");
            Console.WriteLine(arr.Length);      // lunghezza dell'array creato
            foreach (String a in arr)
                Console.WriteLine(a);
        }
    }
}