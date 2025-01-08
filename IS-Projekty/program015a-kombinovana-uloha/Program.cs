using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*****************Zapoctovy test****************");
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
                Console.WriteLine("{0}", myArray[i]);
            }
            
            // maximum a minimum + jejich pozice            
            int max = dm;
            int maxCount = 0;
            int[]maxPos = new int[maxCount];
            int min = hm;
            int minCount = 0;
            int[] minPos = new int[minCount];

            for(int i =0;i <n;i++){
                if(myArray[i]>max){
                    max = myArray[i];
                } else if (myArray[i]<min){
                    min = myArray[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //shaker sort
            for(int i =0;i < n;i++){
                for(int k = i; k<n-1;k++) {   
                    if(myArray[k] < myArray[k+1]){
                        int tmp = myArray[k];
                        myArray[k]= myArray[k+1];
                        myArray[k+1] = tmp;
                    }
                }
                for(int j = n-i-1;j > i;j--){
                    if(myArray[j] > myArray[j-1]){
                        int tmp = myArray[j];
                        myArray[j] = myArray[j-1];
                        myArray[j-1] = tmp;
                    }
                }
            }

            Console.WriteLine("Seřazený pole: ");
            for(int i = 0; i < n;i++){
                Console.Write("{0}, ", myArray[i]);
            }



            // druhy, treti a ctvrty nejvetsi 
            int largestNumbers = 4;      
            int[] largestArray = new int [largestNumbers];
            largestArray[0] = max;
            for(int i = 0;i < largestNumbers;i++){
                for(int j = 1; j < n;j++){
                    if(myArray[j] < myArray[j-1]){
                        largestArray[j] = myArray[j];
                        break;
                    }
                }
            }

            //median
            int median;
            median = myArray[n/2];

            //ctvrte nejvetsi do 2 soustavy

            int[]binaryArray = new int[32];
            int reminder;
            int binaryN = largestArray[3];

            for(int i = 0;i < 32;i++){
                reminder = binaryN % 2;
                binaryArray[i] = reminder;
                binaryN = (binaryN-reminder)/2;
                if(binaryN == 0){
                    break;
                }
                
            }
            


            //obrazec
            // for(int i = 1;i <= median;i++){
            //     for(int j = 1;j <=third;j++){
            //         Console.Write("* ");
            //     }
            //     Console.WriteLine();
            // }


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}