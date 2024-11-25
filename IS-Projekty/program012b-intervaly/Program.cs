// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("******************Intervaly********************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****************Lucie Matějková***************");
            Console.WriteLine("***********************************************\n\n");     
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
            
            Console.Write("Zadejte počet intervalů (celé číslo): ");
            int count;
            while(!int.TryParse(Console.ReadLine(),out count)) {
                Console.Write("Nezadali jste přesnost. Zadejte znovu počet intervalů (celé číslo): ");
            }


            Console.WriteLine("\n\n================");
            Console.WriteLine("Uživatel zadal počet: {0}, dolní mez: {1}, horní mez: {2}",n, dm, hm);
            Console.WriteLine("================\n\n");

            //declare pole
            int[]myArray = new int[n];
            int[]intervalArray = new int[count];


            //příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < n;i++){
                myArray[i] = randomNumber.Next(dm, hm);
                Console.Write("{0}, ", myArray[i]);
                int intervalNum = 0;
                bool exitLoop = false;
                for(double j = 1;j <= count;j++){
                    if(myArray[i]<= (j/count * hm)){
                        intervalArray[intervalNum] = intervalArray[intervalNum]+1;
                        exitLoop = true;
                    }
                    intervalNum++;
                    if(exitLoop){
                        break;
                    }

                }
            }

            
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            for(int i = 0;i <count;i++){
                Console.WriteLine("Interval_{0} <{1},{2}>: {3}", i+1,dm + (Convert.ToDouble(i)/count*hm) ,hm *Convert.ToDouble(i+1)/count,intervalArray[i]);
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}