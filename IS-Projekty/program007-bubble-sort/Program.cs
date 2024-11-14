using System;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Security.AccessControl;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********Bubble sort náhodných čísel***********");
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****************Lucie Matějková***************");
            Console.WriteLine("************************************************\n\n");     
            Console.WriteLine();     
            
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(),out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(),out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
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
            //-1, protože poslední neřešíme

            Console.WriteLine();

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();

            int numberCompare =0;
            int numberChange = 0;

            for(int i = 0;i < n-1;i++){
                for(int j =0;j<n-i-1;j++){
                    if(myArray[j] < myArray[j+1]){
                        int tmp = myArray[j];
                        myArray[j]=myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange++;
                    }
                    numberCompare++;
                }
            }
            myStopwatch.Stop();


            Console.WriteLine("Seřazeno sestupně: ");
            for(int i = 0; i < n;i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n\nČas potřebý na seřazení pole algoritmem Bubble Sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet provonání: {0}", numberCompare);
            Console.WriteLine("\n\nPočet výměn: {0}", numberChange);
            Console.ResetColor();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
