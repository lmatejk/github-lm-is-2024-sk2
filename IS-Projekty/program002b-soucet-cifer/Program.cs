using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("*********Součet cifer*******");
            Console.WriteLine("****************************");
            Console.WriteLine("******Lucie Matějková*******");
            Console.WriteLine("****************************\n\n");     
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
            
            if(number <0){
                number = - number;
            }
            
            //convert to string + get string length
            string num_string = number.ToString();
            int num_length = num_string.Length;
            
            int suma = 0;
            int multi = 1;
            int numberBackup = number;
            int digit;

            for(int i = 0; i < num_length ;i++){
                digit = int.Parse(num_string[i].ToString());
                suma = suma + digit;
                multi = multi * digit;
            }


            Console.WriteLine("Digit = {0}", number);

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma); 
            Console.WriteLine("\n\nSoučin cifer čísla {0} je {1}",numberBackup,multi);          
  

            //opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}