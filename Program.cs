using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        struct pair //объединение двух переменных

        {
            public int summa; //делаем публичными
            public int index;

            static void Main()
            {
                const int x = 5;

                pair[] massiv = new pair[x];
                int y = 0;

                Random random = new Random();// неопределенный тип переменной
                int[,] mas = new int[x, x];


                int k = 0;

                for (int i = 0; i < x; i++)
                    for (int j = 0; j < x; j++)
                        mas[i, j] = random.Next(-10, 10);

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)

                        Console.Write("{0} ", mas[i, j]);

                    Console.WriteLine();
                }

                Console.WriteLine();

                for (int i = 0; i < x; i++)

                    for (int j = 0; j < x; j++)
                        if (mas[i, j] == 0)
                        {
                            y = ++j;
                            break;
                        }

                Console.WriteLine("Номер первого столбца где имеется '0' = {0}", y);

                int summa1 = 0;

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                        if (((mas[i, j]) <= 0) && (j + 1) % 2 == 0)

                            summa1 += mas[i, j];
                    massiv[k].summa = summa1;
                    massiv[k].index = i;
                    summa1 = 0;
                    ++k;


                }

                for (int i = 0; i < x; i++)

                    Console.WriteLine("cymma {0}", massiv[i].summa);
                Console.WriteLine();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                        if (massiv[i].summa > massiv[j].summa)
                        {
                            int tempsum = massiv[i].summa;
                            massiv[i].summa = massiv[j].summa;
                            massiv[j].summa = tempsum;

                            int tempindex = massiv[i].index;
                            massiv[i].index = massiv[j].index;
                            massiv[j].index = tempindex;

                        }
                }

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)

                        Console.Write(" {0}", mas[massiv[i].index, j]);
                    Console.WriteLine();
                }
                Console.ReadKey();

            }

        }
    }
}
