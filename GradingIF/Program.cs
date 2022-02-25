using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //mis hinde kasutaja sai;
            //kui kasutaja sai "A" konsool kuvab:;
            //"Suurepärane"
            //kui kasutaja sai "B" konsool kuvab:;
            //"Väga hea!";
            //kui kasutaja sai "C" konsool kuvab:;
            //"Hea!";
            //kui kasutaja sai "D" konsool kuvab:;
            //"Rahuldav";
            //kui kasutaja sai "E" konsool kuvab:;
            //"Kasin";
            //kui kasutaja sai midagi muud, siis konsool kuvab:;
            //"Puudulik"
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus!";
            // KASUTAME IF

            Console.WriteLine("Sisesta oma tulemus:");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Vaga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else
            {
                Console.WriteLine($"{userResult} on puudulik hinne");
            }
            Console.WriteLine("Kena paeva!");
        }
    }
}
