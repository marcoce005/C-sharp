using System;

namespace Name
{

    class Parola
    {
        public string? Word { get; set; }     // il ? prende sia la stringa o il null se e' vuoto
    }

    class Program
    {
        private static string IN()
        {
            Console.WriteLine("\n\nInserire il nome:\t");
            string x = Console.ReadLine();
            if (x == null)
            {
                Console.WriteLine("\nErrore!!!");
                IN();
            }
            return x;
        }

        private static void no(string x)
        {
            Console.WriteLine("\n\nLa parola {0} non e' palindroma.", x);
        }

        private static void si(string x)
        {
            Console.WriteLine("\n\nLa parola {0} e' palindroma.", x);
        }

        private static void is_palindroma(string x)
        {
            Stack<char> ls = new Stack<char>();
            List<char> ll = new List<char>();

            bool different = false;

            foreach (char let in x)
            {
                ls.Push(let);
                ll.Add(let);
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (ls.First() != ll[i])
                {
                    no(x);
                    different = true;
                    break;
                }
                else
                    ls.Pop();
            }

            if (!different)
                si(x);
            return;
        }

        static void Main()
        {
            Parola p = new Parola();
            p.Word = IN();
            is_palindroma(p.Word);
        }
    }
}