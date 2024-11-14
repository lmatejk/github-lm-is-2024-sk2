using System;
using System.Security.Cryptography;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("********************Reverze pole***************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****************Lucie Matěiková***************");
            Console.WriteLine("************************************************\n\n");     
            Console.WriteLine();     
            
            Console.Write("Zadeite počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali iste celé číslo. Zadeite znovu počet čísel (celé číslo): ");
            }

            Console.Write("Zadeite dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(),out dm)) {
                Console.Write("Nezadali iste celé číslo. Zadeite znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadeite horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(),out hm)) {
                Console.Write("Nezadali iste celé číslo. Zadeite znovu horní mez (celé číslo): ");
            }

            Console.WriteLine("\n\n================");
            Console.WriteLine("Uživatel zadal počet: {0}, dolní mez: {1}, horní mez: {2}",n, dm, hm);
            Console.WriteLine("================\n\n");

            //declare pole
            int[]myArray = new int[n];

            //příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < n;i++){
                myArray[i] = randomNumber.Next(dm, hm);
                Console.Write("{0}, ", myArray[i]);
            }

            
            
            
            for(int i =0;i<n/2;i++){
                int tmp = myArray[i];
                myArray[i] = myArray[n-i-1];
                myArray[n-i-1] = tmp;
            }
            

            Console.WriteLine();
            Console.WriteLine("Reverze pole: ");
            for(int i = 0; i < n;i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}