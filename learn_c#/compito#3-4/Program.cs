using System;
using System.IO;

namespace Name
{
    class utenti
    {
        static List<string> fill()
        {
            List<string> users = new List<string>();
            foreach (String line in File.ReadLines("./text.txt"))
                foreach (String name in line.Split("~"))
                {
                    users.Add(name);
                    break;
                }
            return users;
        }

        static int control_name(List<string> users)
        {
            string tmp;
            int tot = 0;
            for (int i = 0; i < users.Count; i++)
            {
                tmp = users.First();
                users.RemoveAt(0);
                foreach (string y in users)
                    if (y == tmp)
                        tot++;
                users.Add(tmp);
            }
            return tot;
        }

        static void Main()
        {
            List<string> users = fill();
            int value = control_name(users);

            if (value > 0)
                Console.WriteLine("\nCi sono delle persone omonime.");
            else
                Console.WriteLine("\nNon ci sono omonimi.");
        }
    }
}