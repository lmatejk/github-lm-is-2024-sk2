using System;
using System.ComponentModel.DataAnnotations;
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
                Console.WriteLine("{0}", myArray[i]);
            }
            
            
            int max = dm;
            int min = hm;
           

// maximum a minimum
            for(int i =0;i <n;i++){
                if(myArray[i]>max){
                    max = myArray[i];
                } else if (myArray[i]<min){
                    min = myArray[i];
                }
            }
// druhy, treti a ctvry nejvetsi       
            int second;
            int third;
            int fourth;
            int median;

//shaker sort
            for(int i = 0;i < n-1;i++){
                if(myArray[i]<myArray[i+1]){
                    int tmp = myArray[i];
                    myArray[i] = myArray[i+1];
                    myArray[i+1] = tmp; 
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
