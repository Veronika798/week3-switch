using System;

namespace GradingSwich
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

            Console.WriteLine("Sisesta oma tulemus:");
            string userResult = Console.ReadLine().ToUpper();

            switch (userResult)
            {
                case "A":
                    Console.WriteLine("Suureparane!");
                    break;
                case "B":
                    Console.WriteLine("Vaga hea!");
                    break;
                case "C":
                    Console.WriteLine("Hea!");
                    break;
                case "D":
                    Console.WriteLine("Rahuldav");
                    break;
                case "E":
                    Console.WriteLine("Kasin");
                    break;
                default:
                    Console.WriteLine($"{userResult} on puudulik hinne");
                    break;
                 
            }
            Console.WriteLine("Kena paeva!");




        }



    }
}
