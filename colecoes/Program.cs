using System;
using System.Collections.Generic;// Local onde estão os tipos de List genericos

namespace colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
          var nomes = new List<string>{"Stenio","Daniel","Carla"};

          foreach(var nome in nomes){
              Console.WriteLine($"Ola! {nome.ToUpper()}");
          }

          Console.WriteLine();
          nomes.Add("Sergio");
          nomes.Add("Mariana");
          nomes.Add("Fernanda");
          nomes.Remove("Carla");

          foreach(var nome in nomes){
              Console.WriteLine($"Ola! {nome.ToUpper()}");
          }
          Console.WriteLine($"Meu nome é {nomes[0]}.");
          Console.WriteLine($"Eu adicionei {nomes[2]},{nomes[4]} e {nomes[3]} na lista.");
          Console.WriteLine($"A lista tem  {nomes.Count} Pessoas");
          var index = nomes.IndexOf("Sergio");//IndexOf informar o indice do objeto informado dentro da lista
          if (index != -1)
          Console.WriteLine($"O nome {nomes[index]} está na posição {index}");

          var notFound = nomes.IndexOf("Not Found");
          Console.WriteLine($"O nome informado não foi encontrado em nenhuma posição,  retorno IndexOf  {notFound}");
          //Ordenação
          nomes.Sort();

          foreach(var nome in nomes){
              Console.WriteLine($"Ola! {nome.ToUpper()}");
          }





















        }
    }
}
