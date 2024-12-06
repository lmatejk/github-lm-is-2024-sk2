// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*********2D pole**********");
            Console.WriteLine("**************************");
            Console.WriteLine("******Lucie Matějková*****");
            Console.WriteLine("**************************\n\n");     
            Console.WriteLine();     

            Console.Write("Zadejte počet řádků (celé číslo): ");
            int m;
            while(!int.TryParse(Console.ReadLine(),out m)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet řádků (celé číslo): ");
            }
            
            Console.Write("Zadejte počet sloupců (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(),out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu počet sloupců (celé číslo): ");
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
            
            Console.Write("Zadejte hledané číslo (celé číslo): ");
            int hledaneCislo;
            while(!int.TryParse(Console.ReadLine(),out hledaneCislo)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu hledané číslo (celé číslo): ");
            }

            int[,]pole = new int[m,n];
            int count = 0;

            Random randomNumber = new Random();


            Console.WriteLine("Náhodná čísla: ");
            for(int i = 0; i < m;i++){
                for(int j = 0;j < n;j++){
                    pole[i,j] = randomNumber.Next(dm,hm);
                    if(pole[i,j]==hledaneCislo){
                        count++;
                    }
                    Console.Write("{0} ",pole[i,j]);
                }
                Console.WriteLine();
            }

            if(count==0){
                Console.WriteLine("\nHledané číslo nebylo nalezeno.");
            } else {
                Console.WriteLine("\nHledané číslo {0} nalezeno. Počet výskytů {1}.", hledaneCislo, count);
            }


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
