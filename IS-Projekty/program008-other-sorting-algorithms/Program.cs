using System;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("****************Řadící algoritmy***************");
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

//selection sort
            
            // for(int i =0;i<n-1;i++){
            //     int max = myArray[i];
            //     int maxPos = i;
            //     for(int j = i;j<n;j++){
            //         if(myArray[j]>max){
            //             max=myArray[j];
            //             maxPos=j;

            //         }   
            //     }
            //     int tmp = myArray[i];
            //     myArray[i] = myArray[maxPos];
            //     myArray[maxPos] = tmp;
            // }


//insertion sort
            // for(int i =0;i<n;i++){
            //     for(int j = i;j >= 0;j--){
            //         if(myArray[i]>myArray[j]){
            //             int tmp = myArray[i];
            //             int pos = i;
            //             while(pos-1>=-1 && myArray[i]>=myArray[pos]){
            //                 pos--;
            //             }
            //             for(int l = i;l>pos+1;l--){
            //                 myArray[l] = myArray[l-1];
            //             }
            //             myArray[pos+1] = tmp;
            //         }
            //     }
            // }
            
//shaker sort
            // for(int i =0;i<n-1;i++){
            //     for(int j =i;j<n-1;j++){
            //         if(myArray[j]<myArray[j+1]){
            //             int tmp = myArray[j];
            //             myArray[j] = myArray[j+1];
            //             myArray[j+1]= tmp;

            //         }
            //     }
            //     for(int j = n-i-1;j > 0;j--){
            //         if(myArray[j]>myArray[j-1]){
            //             int tmp = myArray[j];
            //             myArray[j] = myArray[j-1];
            //             myArray[j-1]= tmp;

            //         }
            //     }
            // }


//comb sort
            // int gap = n;
            // for(int i =0;i < n;i++){
            //     gap = gap*3/4;
            //     for(int j = 0;j+gap <n;j++){
            //         if(myArray[j] < myArray[j+gap]){
            //             int tmp = myArray[j];
            //             myArray[j] = myArray[j+gap];
            //             myArray[j+gap] = tmp;
            //         }
            //     }
            // }

//shell sort

            int gap = n;
            for(int i =0;i < n;i++){
                gap = gap/2;
                for(int j = i+gap;j <n-1;j++){
                    if(j>i){
                        for(int l = j;l>=-1;l =l - gap){
                            int tmp = myArray[j];
                            int pos = l;
                            
                            for(int k = i;l > pos+gap;k =k-gap){
                                myArray[l] = myArray[l-gap];
                            }
                        }        
                        myArray[l-gap] = tmp;
                       }
                        
                    }       
                }
            

            Console.WriteLine();
            Console.WriteLine("Seřazeno sestupně: ");
            for(int i = 0; i < n;i++){
                Console.Write("{0}, ", myArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}

