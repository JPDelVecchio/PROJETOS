using System;
using System.Collections.Generic;

namespace Fibinacci
{
    class Program
    { 
        
        static void Main(string[] args)
        { 
            Console.WriteLine("limite do Fibonacci!!! \n Prox. a 350");

            int limite = 0;
            limite = 350;
            int anterior = 0, atual = 1;

            while (atual < limite)
            { 
                int x  = SequenciaFibonacci(anterior, atual);
                anterior = atual;
                atual = x;
                Console.WriteLine(atual); 

            }
        }
        public static int SequenciaFibonacci(int ant, int at)
        {
            int y = ant + at;
            return y;
        }
    }
}
