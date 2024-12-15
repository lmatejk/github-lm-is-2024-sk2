// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("*********Převod z 10 do n soustavy*******");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*************Lucie Matějková*************");
            Console.WriteLine("*****************************************\n\n");     
            Console.WriteLine();     
            

            Console.Write("Zadejte číslo v desítkové soustavě (přirozenné číslo): ");
            uint cislo;
            while(!uint.TryParse(Console.ReadLine(),out cislo)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu číslo v desítkové soustavě (přirozené číslo): ");
            }

            Console.Write("Zadejte do jake soustavy chcete převést číslo (přirozenné číslo menší než 10): ");
            uint n;
            while(!uint.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu do jake soustavy chcete převést číslo (přirozené číslo menší než 10): ");
            }
           
           
            uint[] myArray = new uint[32];

            uint zaloha = cislo;
            uint zbytek;
            

            uint i = 0;
            while(cislo > 0){
                zbytek = cislo % n;
                cislo = (cislo - zbytek)/n;
                myArray[i] = zbytek;
                
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Celá část = {0}, zbytek = {1}",cislo, zbytek);

                i++;
            }
            
            Console.WriteLine("Poslední využitý index pole: {0}", i-1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nVýsledek:");

            for(uint j = i-1;j>=0&&j<=32;j--){
                Console.Write("{0}", myArray[j]);
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
            
    }
}
