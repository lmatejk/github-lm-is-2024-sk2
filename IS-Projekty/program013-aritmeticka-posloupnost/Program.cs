using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("***************************************");
            Console.WriteLine("*********Aritmetická posloupnost*******");
            Console.WriteLine("***************************************");
            Console.WriteLine("*************Lucie Matějková***********");
            Console.WriteLine("***************************************\n\n");     
            Console.WriteLine();     
            

            Console.Write("Zadejte počet čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
            }
            
            Console.Write("Zadejte diferenci (celé číslo): ");
            int diff;
            while(!int.TryParse(Console.ReadLine(),out diff)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu diferenci (celé číslo): ");
            }

            Console.Write("Zadejte první prvek (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(),out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu první prvek(celé číslo): ");
            }

            
            int[]myArray = new int[n];
            myArray[0] = first;
            int sum = first;

            for(int i = 1; i <n;i++){
                myArray[i] = myArray[i-1]+diff;
                sum = sum+myArray[i];
            }

            for(int i = 0;i < n;i++){
                Console.Write("{0}; ", myArray[i]);
            }
            Console.WriteLine("\nSoučet hodnot: {0}", sum);


            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
