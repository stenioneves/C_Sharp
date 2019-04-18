using System;
using System.Collections.Generic;

/*
  Desafio proposto pela Microsot de continuar a seguencia até 20ª posição.Essa classe foi cirada para executar 
  desafio.
 */
namespace colecoes2{

   class DesafioFibonacci
   {
       
       public void Fibonacci(){
           var fibonacciNumeros = new List<int> {1, 1};
            var proximo=0;
            var proximo2 =0;
             


                for(int i=0;i<20;++i){//atualiza, aqui é a sacada incremento primerior.
                    proximo=fibonacciNumeros[fibonacciNumeros.Count-1];
                    proximo2 = fibonacciNumeros[fibonacciNumeros.Count-2];
                     fibonacciNumeros.Add(proximo+proximo2);
                     Console.WriteLine(fibonacciNumeros[i]);

                }




       }





   }












}