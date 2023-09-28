using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ArrayMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, n = 1, o = 0, p = 0;
            char x ='a';
            
            int [,] tabla = new int [5,5];

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    //Console.Write("R{0} ",i);
                    //Console.Write("E{0} ",j);
                    tabla[i, j] = n++;
                    Thread.Sleep(150);
                    Console.Write(tabla[i,j]);
                    
                    
                }
                Console.WriteLine();
            }

            char[,] alpha = new char[5, 5];

            for (o = 0; o < 5; o++)
            {
                for (p = 0; p < 5; p++)
                {
                    alpha[o, p] = x++;
                    Thread.Sleep(150);
                    Console.Write(alpha[o, p]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("renglon 0  " + alpha[0, 0]);
            Console.WriteLine("renglon 1  " + alpha[1, 0]);
            Console.WriteLine("renglon 2  " + alpha[2, 0]);
            Console.WriteLine("renglon 3  " + alpha[3, 0]);
            Console.WriteLine("renglon 4  " + alpha[4, 0]);
           
            Console.ReadKey();
        }
    }
}
