// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*********název programu*******");
            Console.WriteLine("******************************");
            Console.WriteLine("********Lucie Matějková*******");
            Console.WriteLine("******************************\n\n");     
            Console.WriteLine();     
            

            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(),out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady (celé číslo): ");
            }


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
