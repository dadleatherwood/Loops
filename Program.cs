using System;

namespace Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach (var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 ==0) 
            //    {
            //        Console.WriteLine(i);
            //        i++;
            //    }
            //}

            //case where while loop would make sense

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@ECHO: " + input);
                    continue; //returns to the beginning of the loop
                }
                break;

            }
        }
    }
}
