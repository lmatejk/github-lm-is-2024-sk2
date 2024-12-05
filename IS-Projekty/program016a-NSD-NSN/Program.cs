// See https://aka.ms/new-console-template for more information
using System;
//vypsat prvocisla - bude v zapoctu
class Program {
    static void Main() {
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            razitko();    
            
            ulong a = ziskatCislo("Zadejte přirozené číslo a: ");
            ulong b = ziskatCislo("Zadejte přirozené číslo b: ");

            ulong nsd = vypocitatNsd(a,b);
            ulong nsn = vypocitatNsn(a, b, nsd);

            zobrazeniVysledky( a,  b, nsd, nsn);

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }

    static void razitko() {
        Console.WriteLine("***************************");
        Console.WriteLine("*********NSD a NSN*********");
        Console.WriteLine("***************************");
        Console.WriteLine("******Lucie Matějková******");
        Console.WriteLine("***************************\n\n");     
        Console.WriteLine();     
    }

    static ulong ziskatCislo(string zprava) {
        Console.Write(zprava);
        ulong cislo;
        while(!ulong.TryParse(Console.ReadLine(),out cislo)) {
                Console.Write("Nezadali jste celé číslo. Znovu {0}", zprava);
        }
        
        return cislo;
    }

    static ulong vypocitatNsd(ulong a, ulong b){
        while(a != b){
            if(a > b)
                a = a-b;
            else 
                b = b-a;
        }
        
        return a;
    }

    static ulong vypocitatNsn(ulong a, ulong b, ulong nsd){
        return a*b/nsd;
    }
    
    static void zobrazeniVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, nsd);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"NSN čísel {a} a {b} je {nsn}");

        Console.ForegroundColor = ConsoleColor.White;

    }
}
