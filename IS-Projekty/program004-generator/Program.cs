using System;
using System.Security.AccessControl;
using System.Security.Cryptography;


//chci, aby se program opakoval po stisku klávesy "a"
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************************");
    Console.WriteLine("*********Generátor pseudováhodných čísel*******");
    Console.WriteLine("***********************************************");
    Console.WriteLine("*****************Lucie Matějková***************");
    Console.WriteLine("************************************************\n\n");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel (celé číslo): ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez (celé číslo): ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez (celé číslo): ");
    }

    Console.WriteLine("\n\n================");
    Console.WriteLine("Uživatel zadal počet: {0}, dolní mez: {1}, horní mez: {2}", n, dm, hm);
    Console.WriteLine("================\n\n");

    //declare pole
    int[] myArray = new int[n];

    //příprava pro generování náhodných čísel
    Random randomNumber = new Random();
    int kladny = 0; int nulovy = 0; int zaporny = 0; int suda = 0; int licha = 0;

    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        

        
        myArray[i] = randomNumber.Next(dm, hm);
        Console.WriteLine("{0}", myArray[i]);
        if(myArray[i] > 0)
            kladny++;
        else if(myArray[i]<0)
            zaporny++;
        else
            nulovy++;

        if(myArray[i]%2==0)
            suda++; 
        else
            licha++;           
    }
    Console.WriteLine("Kladný: {0}, nulový: {1}, záporný: {2}", kladny, nulovy, zaporny);
    Console.WriteLine("Sudá: {0}, Lichá: {1}", suda,licha);


    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
