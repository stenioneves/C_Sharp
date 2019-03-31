using System;

namespace controle
{
    class Program
    {
        static void Main(string[] args){
        int a = 5;
        int b = 3;
        if (a + b > 10)
     {
       Console.WriteLine("The answer is greater than 10");
      }
      else
      {
       Console.WriteLine("The answer is not greater than 10");
       }

       int control = 0;
       do {
           Console.WriteLine($" Do While:{control}");
           control++;
       } while (control<50);

       while(control <60){
            Console.WriteLine($" While {control}");
           control++;
       }
        for(control=0; control<80;control++){
            Console.WriteLine($" for {control}");
        }





    }
}
}