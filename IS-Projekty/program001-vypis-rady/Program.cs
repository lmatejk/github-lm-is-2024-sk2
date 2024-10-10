using System;

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
            
            //vstup od uživatele - TO-DO

            //logika pro výpis řady - TO-DO

            //opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}


