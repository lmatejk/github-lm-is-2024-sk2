using System;
using System.Security.AccessControl;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*********Výpis řady*******");
            Console.WriteLine("**************************");
            Console.WriteLine("******Lucie Matějková*****");
            Console.WriteLine("**************************\n\n");     
            Console.WriteLine();     
            

            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(),out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }
            // výpis vstupní hodnoty 
            Console.WriteLine("===================");        
            Console.WriteLine("Uživatel zadal : {0}", number);
            Console.WriteLine("===================\n\n");        

            int suma = 0;
            int numberBackup = number;
            int digit;
            int soucin = 1;

            if(number <0){
                number = - number;
            }

            while(number >= 10) {
                digit = number % 10; // % operátor - zbytek po dělení
                number = (number-digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                soucin = soucin * digit;
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            soucin = soucin * number; 

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma); 
            Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}",numberBackup,soucin);          
  

            //opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}

