// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*********Výpočet pí*******");
            Console.WriteLine("**************************");
            Console.WriteLine("******Lucie Matějková*****");
            Console.WriteLine("**************************\n\n");     
            Console.WriteLine();     


            Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(),out presnost)) {
                Console.Write("Nezadali jste přesnost. Zadejte znovu přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
            }

            



            double e =1;
            double faktorial=1;
            double n =1;

            while((1/faktorial) >=presnost){
                faktorial = faktorial *n;
                e = e + (1 / faktorial);
                
                n++;
            }


            Console.WriteLine("\n\nHodnota čísla PI: {0}", e);
  
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}