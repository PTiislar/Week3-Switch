using System;

namespace Grading
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm kusib, mis hinde kasutaja sai
            //kui kasutaja sai 'A', konsool kuvab "Suureparane!",
            //'B', konsool kuvab "Vaga hea!".
            //'C', konsool kuvab "Hea!",
            //'D', konsool kuvab "Rahuldav!",
            //'E', konsool kuvab "Kasin!",
            //'F', konsool kuvab "Puudulik!",
            // kui kasutaja siestab midagi muud, siis konsool kuvab "vale vaartus"

            //kasitame IF

            Console.WriteLine("Sisesta oma tulemus:");
            //char- character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            
            if(userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if(userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if(userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if(userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if(userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if(userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale väärtus!");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
