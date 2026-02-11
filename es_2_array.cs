using System;
using static System.Console;
namespace es_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[30];
            int metà;
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                n[i] = rnd.Next(0, 101);
            }

            for (int i = 0; i < 30; i++)
            {
                if (n[i] % 2 == 0) 
                {
                   metà = n[i] /2;
                    for (int j = 0; j < 30; j++)
                    {
                        if (n[j] == metà)
                        {
                            Write($"{n[i]} {metà}  ");
                        }
                    }
                }
                

            }
        }
    }
}