using System;
using System.Security.Cryptography;
using System.Diagnostics;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********Vánoční kombinovaná úloha***********");
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
                Console.Write("{0} ,", myArray[i]);
            }
            Console.WriteLine();

            int[]origArray = myArray;
            Stopwatch myStopwatch1 = new Stopwatch();
            Stopwatch myStopwatch2 = new Stopwatch();


//comb sort a insertion sort
            myStopwatch1.Start();
            int gap = n;
            while(gap!=0){
                gap = gap*3/4;
                for(int i = 0;i+gap < n;i++){
                    if(myArray[i]<myArray[i+gap]){
                        int tmp = myArray[i];
                        myArray[i] = myArray[i+gap];
                        myArray[i+gap]=tmp;
                    }
                }
            }
            myStopwatch1.Stop();
            
            myStopwatch2.Start();
            for(int i =1;i < n;i++){
                if(origArray[i]>origArray[i-1]){
                    int tmp = origArray[i];
                    int pos = i;
                    while(pos-1>=-1 && myArray[i]>=myArray[pos]){
                        pos--;
                    }
                    for(int l = i;l>pos+1;l--){
                        myArray[l] = myArray[l-1];
                    }
                    myArray[pos+1] = tmp;
                    
                
                }
            }
               
    
            myStopwatch2.Stop();


            Console.Write("Seřazený pole: ");
            for(int i = 0;i <n;i++){
                Console.Write("{0} ,", origArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Čas řazení comb sortu: {0}", myStopwatch1);
            Console.WriteLine("Čas řazení insetion sortu: {0}", myStopwatch2);

//min a max
            int max = dm;
            int min = hm;

            for(int i = 0;i <n;i++){
                if(myArray[i]> max){
                    max = myArray[i];
                }
                if(myArray[i]<min){
                    min = myArray[i];
                }
            }
            Console.WriteLine("Minimum je: {0}, Maximum je: {1}", min, max);

//prumer a jeho zbytek
            int sum=0;
            for(int i =0;i <n;i++){
                sum = sum + myArray[i];
            }
            int average = sum/n;
            int rest = sum % n;

            Console.WriteLine("Celý průměr: {0}, zbytek: {1}", average, rest);

//stromeček
            
            for(int j = 0; j < average;j++){
                int space = average/2 + 1;
                int stars = 1;
                for(int i =0;i <j;i++){
                    for(int l = space; l >=0;l--){
                        Console.Write(" ");
                    }
                    space--;
                    for(int k = stars; k > 0;k--) {
                        Console.Write(" *");
                    }
                    stars++; 
                    Console.WriteLine();
                }
            }
            gap = average/5;
            for(int i = 0; i < average-1;i++){
                for(int j =gap; j > 0; j--){
                    Console.Write("  ");
                }
                for(int j = gap+1; j <=average-gap; j++){
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}