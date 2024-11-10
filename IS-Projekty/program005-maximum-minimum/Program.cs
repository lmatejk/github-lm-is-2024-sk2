using System;
using System.Security.Cryptography;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*********Generátor - maximum a minimum*********");
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
                Console.Write("{0} ", myArray[i]);
            }
            int max = myArray[0];
            int min = myArray[0];
            int posMax = 0;
            int posMin = 0;
            int maxCount = 0;
            int minCount = 0;
                
                
            for(int i = 1;i < n;i++){
                if(myArray[i]>max){
                    max = myArray[i];
                    posMax = i;
                }

                if(myArray[i]<min){
                    min = myArray[i];
                    posMin = i;
                }
            }

            for(int i = 0;i < n;i++){
                if(myArray[i]==max){
                    maxCount++;
        
                }

                if(myArray[i]==min){
                    minCount++;
                }
            }
            int[]posMaxArray = new int[maxCount];
            int[]posMinArray = new int[minCount];
            
            int posi1 = 0;
            int posi2 = 0;
            for(int j = 0;j <n;j++){
                if (myArray[j]==max){
                    posMax = j;
                    posMaxArray[posi1] = posMax;
                    posi1++;
                    
                }
                if (myArray[j]==min){
                    posMin = j;
                    posMinArray[posi2] = posMin;
                    posi2++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Maximum je: {0}", max);
            Console.WriteLine("Počet max. hodnot: {0}", maxCount);
            Console.Write("Pozice max. hodnot: ");
            for(int i = 0;i < maxCount;i++){
                Console.Write("{0} ", posMaxArray[i]);

            }
            Console.WriteLine();
            Console.WriteLine("Minimum je: {0}", min);
            Console.WriteLine("Počet min. hodnot: {0}", minCount);
            Console.Write("Pozice min. hodnot: ");
            for(int i = 0;i < minCount;i++){
                Console.Write("{0} ", posMinArray[i]);
            }
            Console.WriteLine();


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}

