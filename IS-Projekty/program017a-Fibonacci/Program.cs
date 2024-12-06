// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.WriteLine("*********Fabonacciho posloupnost*******");
            Console.WriteLine("***************************************");
            Console.WriteLine("************Lucie Matějková************");
            Console.WriteLine("***************************************\n\n");     
            Console.WriteLine();     
            

            Console.Write("Zadejte počet členů (celé číslo): ");
            ulong n;
            while(!ulong.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet členů (celé číslo): ");
            }
            ulong[]myArray = new ulong[n+1];
            myArray[0] = 0;
            myArray[1] = 1;
            ulong sum = 0;

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();            

            for(ulong i =2; i <= n; i ++){
                myArray[i]= myArray[i-1]+ myArray[i-2];
            }

            for(ulong i = 0;i <= n;i++){
                sum = sum + myArray[i];
                Console.Write("{0}, ", myArray[i]);
            }

            myStopwatch.Stop();

            Console.WriteLine("\n{0}. prvek posloupnosti je: {1}", n, myArray[n]);
            Console.WriteLine("Součet posloupnosti (do {0}. prvku): {1}", n,sum);
            Console.WriteLine("Čas trvání výpočtu: {0}", myStopwatch);



            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
