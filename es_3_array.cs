using System;
using static System.Console;
namespace es_3_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b, fine = false;
            int i;
            float[] n = new float[100];
            float cont = 0;
            for ( i = 0; i < n.Length && !fine; i++)
            {
                do
                {
                    WriteLine("Dimmi un numero");
                    b = float.TryParse(ReadLine(), out n[i]);
                } while (!b || n[i] == 0);

                cont += n[i];
                if (cont > 50)
                {
                    fine = true;
                }
            }
            
            cont = i; // serve per il ciclo for dopo perché non si può mettere n.lenght


            if (i >= 3)
            {
                for (i = 0; i < cont; i++)
                {
                    for (int j = 0; j < cont; j++)
                    {
                        if (i != j)
                        {
                            if (n[i] / n[j] == n[0])
                            {
                                WriteLine($"Il rapporto tra {n[i]} e {n[j]} è {n[0]}");
                            }
                        }
                        
                    }
                }
            }
            else
                WriteLine("Con la somma dei numeri che hai inserito sei arrivato a 50 o di più con meno di 3 numeri");
            
        }
    }
}