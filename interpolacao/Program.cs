using System;

namespace interpolacao

{
    /*

      Formnatação de string para data e preço e outros
     */
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Para data : d para a variavel tipo Date onde só a data interessa.
            Para preço :c2 para a variavel preço onde precissão e moeda são necessário
            
             */
           var item = new Vegetal("Berinjela");
           var date = DateTime.Now;
           var price = 1.99m;
           var unit = Unidade.item;
           Console.WriteLine($"Em {date:t}, o preço do(a) {item} está {price:c2} por {unit}.");

           Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
    }
}
