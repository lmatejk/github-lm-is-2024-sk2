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

            double i =1;
            double znamenko=1;
            double piCtvrt =1;

            while((1/i) >=presnost){
                i = i + 2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko *(1/i);
                if(znamenko==1){
                    Console.WriteLine("Zlomek: +1/{0}, aktulaní hodnota PI: {1}", i, piCtvrt*4);
                } else {
                    Console.WriteLine("Zlomek: -1/{0}, aktulaní hodnota PI: {1}", i, piCtvrt*4);
                }
            }


            Console.WriteLine("\n\nHodnota čísla PI: {0}", piCtvrt*4);
  
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}