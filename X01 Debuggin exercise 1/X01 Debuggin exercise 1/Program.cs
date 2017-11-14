using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
                 int sum = 0;
                 int count = 0;

            while (count <= 1001) //while (count <= 1000)
                 {

                if (count % 5 == 0)
                    if (count % 3 != 0)
                         {
                             sum = sum + count;
                             Console.WriteLine(sum + " (+" + count + ")");

                         }

                     if (count % 3 == 0)
                         if (count % 5 != 0)
                         {
                             sum = sum + count;
                             Console.WriteLine(sum + " (+" + count + ")");
                         }
                count++;

                 }

                 // 233168 ist das Ergebnis

                 // 201003 ist das korrekte Ergebnis!

                 Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}