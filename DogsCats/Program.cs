﻿using System;

namespace DogsCats
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Are you more like a cat or a dog?");
                string userChoice = Convert. ToString(Console.ReadLine().ToLower());
                if (userChoice == "cat")
                {
                    Console.WriteLine("You are a home-lover.");
                }
                else if (userChoice == "dog")
                { 
                    Console.WriteLine("You rtygoeare a par.");
                }
                else
                { 
                    Console.WriteLine($"You are a {userChoice} friend.");
                }
            }
        }
}

