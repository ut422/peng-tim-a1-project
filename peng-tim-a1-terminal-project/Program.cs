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

                // second joke interaction
                Console.WriteLine("\nwanna to hear another one? (yes/no)");

                string secondJoke = Console.ReadLine();

                if (secondJoke == "yes")
                {
                    Console.WriteLine("ahem: Why don't eggs tell jokes?");
                    Console.WriteLine("do you know? --> (yes/no)");

                    string eggJoke = Console.ReadLine();

                    if (eggJoke == "yes")
                    {
                        Console.WriteLine("the answer is: 'Because they might crack up!'");
                    }
                    else
                    {
                        Console.WriteLine("fine, I'll tell you: 'Because they might crack up!'");
                    }
                }
                else if (secondJoke == "no")
                {
                    Console.WriteLine("alright fine, I'll stop... for now.");
                }
                else
                {
                    Console.WriteLine("who cares, I'm gonna take that as a yes whether you like it or not: 'Because they might crack up!'");
                }

                // end
                Console.WriteLine("\nalright, that's enough dad jokes for one day");
            }
            else if (response == "no")
            {
                Console.WriteLine("no dad jokes?");
            }
            else
            {
                Console.WriteLine("dad jokes next time I guess");
            }
        }
    }
}