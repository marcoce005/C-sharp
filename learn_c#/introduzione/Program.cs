using System;

public class car {
    public string marca {get; set;}
    public string modello {get; set;}

    public car() {
        marca = "BMW";
        modello = "i8";
    }
}

class Program           // BISOGNA PER FORZA METTERE UNA CLASSE
{
    public enum giorni
    {
        Lunedì = 0,
        Martedì = 1,
        Mercoledì = 2
    }

    public static void Main(string[] args)
    {
        int x = 10;
        double pippo = 9.99;
        Console.WriteLine("valore:\t{0}\nn2:\t{1}", x, pippo);       // il  {0} o {1} serve per selezionare il valore da stampare

        string p1 = "gino", p2 = "Gino", p3 = "gino";        // e' case sensitive
        Console.WriteLine("uguale:\t{0}", p1 == p2);
        Console.WriteLine("uguale:\t{0}", p1 == p3);

        Console.WriteLine("{0} {pippo}\n\n\n");       // se non c'e' la virgola stampa solo il testo, altrimenti se c'e' la ed usiamo le parentesi va in errore


        // TIPI ENUMERATIVI

        foreach (string s in Enum.GetNames(typeof(giorni)))     // stampa il nome corrispondente al giorno
            Console.WriteLine("{0}", s);

        foreach (int t in Enum.GetValues(typeof(giorni)))     // stampa il valore corrispondente al giorno
            Console.WriteLine("{0}", t);


        // OR nello SWITCH
        switch (x)
        {
            case 10:                // se e' 10 or 11 or 12
            case 11:
            case 12:
                Console.WriteLine("\n\nciao");
                break;
        }

        // AND nello SWITCH
        switch ((x, pippo))
        {
            case (10, 9.99):            // se x e' 10 and pippo e' 9.99
                Console.WriteLine("\n\nweeee");
                break;
        }


        // VETTORI
        int[] vet = new int[10];
        int[] vet2 = {0, 0, 1, 10};
        for (int i = 0; i < 10; i++)
            vet[i] = i;
        foreach (int z in vet)
            Console.WriteLine("{0}", z);

        // MATRICI
        int[,] matrix = new int[3, 2];      // una matrice 3 righe 2 colonne
        int[,,] cubo = new int[3, 2, 4];      // una matrice tridimensionale


        // classe esterna gestione
        car macchina = new car();
        Console.WriteLine("{0} {1} driver", macchina.modello, macchina.marca);
    }
}