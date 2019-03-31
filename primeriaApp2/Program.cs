using System;

namespace primeriaApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome= "Stenio";
            Console.WriteLine(nome);
            nome= "sergio";
            Console.WriteLine($"Olá {nome}"); // Interpolação de caracteres $
            string friendFirst= "Elimar";
            string friendSecond= "Rafael";

            Console.WriteLine($"Meus amigos são {friendFirst} e {friendSecond} !");
            Console.WriteLine($"O nome {friendFirst} tem {friendFirst.Length} Letras! ");//Método Length conta os caracteres
            Console.WriteLine($"O nome {friendSecond} tem  {friendSecond.Length} Letras");

            /*
             Método Trim remove espaços 
            
             */

             string saudacao = "      Olá Mundo!      ";
             Console.WriteLine($"[{saudacao}]");

             string trimmedSaudacao =saudacao.TrimStart(); //Remove o espaco em branco da esquerda.
             Console.WriteLine($"[{trimmedSaudacao}]");
             trimmedSaudacao= saudacao.TrimEnd();  //Remove o espaco em branco da direita.
             Console.WriteLine($"[{trimmedSaudacao}]");
             trimmedSaudacao= saudacao.Trim();
             Console.WriteLine($"[{trimmedSaudacao}]");//Remove o espaco em branco dos dois lados.
             string dizOla=" Olá mundo!";
             Console.WriteLine(dizOla);
             dizOla= dizOla.Replace("Olá","Meu");
             Console.WriteLine(dizOla);
             Console.WriteLine(dizOla.ToUpper()); // Maiúscula 
             Console.WriteLine(dizOla.ToLower()); // minúscula 

             /*
              Contains-> verificar se objeto está contido na string
             
              */


              string letraMusical= "You say goodbye, and I say hello";
              Console.WriteLine(letraMusical.Contains("goodbye"));
              Console.WriteLine(letraMusical.Contains("greetings"));

              //desafio StartWith EndWith

              Console.WriteLine(letraMusical.StartsWith("You"));
              Console.WriteLine(letraMusical.EndsWith("hello"));
              Console.WriteLine(letraMusical.StartsWith("say"));
              Console.WriteLine(letraMusical.EndsWith("goodbye"));


        }
    }
}
