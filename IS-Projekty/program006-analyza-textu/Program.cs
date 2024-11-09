// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("*********Analýza textu*******");
            Console.WriteLine("*****************************");
            Console.WriteLine("*******Lucie Matějková*******");
            Console.WriteLine("******************************\n\n");     
            Console.WriteLine();     
            
            //vstup od uživatele - TO-DO

            //vstup od uživatele - špatná varianta
            //Console.Write("Zadejte první číslo řady: ");
            //int first = int.Parse(Console.ReadLine());

            //vstup od uživatele - lepší varianta
            Console.Write("\nZadejte text pro analýzu: ");
            
            string myText = Console.ReadLine();
            
            // Console.WriteLine();
            // Console.WriteLine(myText)
            // Console.WriteLine(myText.Length);
            // Console.WriteLine(myText[myText.Length-1]);
            
            string souhlasky = "aáieéěiíoóuůúyýAÁIEÉĚIÍOÓUŮÚYÝ";
            string samohlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";
            

            int souhlaskyPocet = 0;
            int samohlaskyPocet = 0;
            int cislicePocet = 0;
            int otherPocet =0;

            
            foreach(char znak in myText){
                if(souhlasky.Contains(znak)){
                    souhlaskyPocet++;}
                else if(samohlasky.Contains(znak)){
                    samohlaskyPocet++;}
                else if(cislice.Contains(znak)){
                    cislicePocet++;}
                else 
                    otherPocet++;
            }
                

            Console.WriteLine("Počet samohlásek: {0}",samohlaskyPocet);
            Console.WriteLine("Počet souhlásek: {0}", souhlaskyPocet);
            Console.WriteLine("Počet číslic: {0}", cislicePocet);
            Console.WriteLine("Počet ostatních znaků: {0}", otherPocet);
            


            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}