using System;

namespace DadJokes101
{
    class Program
    {
        static void Main()
        {
            // introduction
            Console.WriteLine("dad jokes.");
            Console.WriteLine("dad jokes? (yes/no)");

            string response = Console.ReadLine();

            // ready check
            if (response == "yes")
            {
                Console.WriteLine("ahem-");

                // first joke
                Console.WriteLine("\nWhy don't skeletons fight each other?");
                Console.WriteLine("do you know the answer? (yes/no)");

                string answer = Console.ReadLine();

                // joke punchline
                if (answer == "yes")
                {
                    Console.WriteLine("'They don't have the guts!'");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("here's the punchline anyways: 'They don't have the guts!'");
                }
                else
                {
                    Console.WriteLine("eh, who cares: 'They don't have the guts!'");
                }

              