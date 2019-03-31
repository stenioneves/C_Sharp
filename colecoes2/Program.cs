using System;
using System.Collections.Generic;

namespace colecoes2
{
    class Program
    {
        static void Main(string[] args)
        {

            var fibonacciNumeros = new List<int> {1, 1};
            var proximo= fibonacciNumeros[fibonacciNumeros.Count-1];
            var proximo2 = fibonacciNumeros[fibonacciNumeros.Count-2];
             fibonacciNumeros.Add(proximo+proximo2);
            

             foreach(var item in fibonacciNumeros){
                 //Console.WriteLine(item);
               
             }

             DesafioFibonacci ds = new DesafioFibonacci();

             ds.Fibonacci();








































        }
    }
}
