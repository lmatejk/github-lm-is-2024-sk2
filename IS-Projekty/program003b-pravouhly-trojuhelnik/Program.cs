using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("********* Pravoúhlý trojúhledník ***********");
            Console.WriteLine("********************************************");
            Console.WriteLine("************* Lucie Matějková **************");
            Console.WriteLine("********************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce (celé číslo): ");
            }
            
            Console.WriteLine();
            // for(int i=1; i<= height; i++) {
            //     string part = string.Concat(Enumerable.Repeat("* ", i));
            //     Console.Write(part);      
            //     System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(500));
            //     Console.WriteLine();
            // }
            for(int i=1; i <=height ;i++){
                for(int j = 1;j <=i;j++){
                    Console.Write("* ");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(200));
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            
            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }    
    }
}
