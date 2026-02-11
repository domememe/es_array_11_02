using System;
using static System.Console;
namespace es_1_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[30];
            int x;
            bool b;
            do
            {
                WriteLine("Quanti numeri vuoi");
                b = int.TryParse(ReadLine(), out x);
            } while (!b || x < 0 || x > 30);
            for (int i = 0; i < x; i++)
            {
                do
                {
                    WriteLine("Che numero vuoi");
                    b = int.TryParse(ReadLine(), out n[i]);
                } while (!b);
            }
            b = false;

            for (int i = 0; i < x; i++)
            {
                for (int j = i + 1; j < x; j++) //i + 1 perché così non controlla la stessa cella di i
                {
                    if (n[i] == n[j])
                    {
                        b = true;
                        break;
                    }
                }
            }

            if (b)
                WriteLine("0");
            else
                WriteLine("1");

        }

    }
}