// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        
        //chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a"){
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("*********Vykresleni obrazcu*********");
            Console.WriteLine("************************************");
            Console.WriteLine("***********Lucie Matějková**********");
            Console.WriteLine("************************************\n\n");     
            Console.WriteLine();     
            

            // Console.Write("Zadejte číslo obrazce, které chcete vytisknout: ");
            // int figureNumber;
            // switch(!int.TryParse(Console.ReadLine(), out figureNumber)=1){
                

            // }


            Console.Write("Zadejte výšku (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(),out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku (celé číslo): ");
            }
            
            Console.Write("Zadejte šířku (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(),out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku (celé číslo): ");
            }



//obr 5
            for(int a=1;a<=height;a++){
                for (int b =1;b<=width;b++){
                    if (a==1 || a==height)
                        Console.Write("* ");
                    else if(a==b)
                        Console.Write("* ");
                    else 
                        Console.Write("  ");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


//obr 14
            for(int i = 1;i <= height;i++){
                if(i<=height/2)
                    for(int j = 1; j <=width;j++){
                        if(j<=width/2)
                            Console.Write("  "); 
                        else 
                            Console.Write("* ");
                    }
                else 
                    for(int j = 1; j <width;j++){
                        if(j<=width/2)
                            Console.Write("* "); 
                        else 
                            Console.Write("  ");

                }
                Console.WriteLine();
            }
//obr 15       

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine();


            // for(int h=1;h<=height;h++){
               
            //     if(height % 2 == 0)
            //         for(int g=1;;g++){

                        
            //             if(g==height/2 || g==height/2+1)
            //                 Console.Write("* ");
            //             else 
            //                 Console.Write("  ");
            //         }
            //         Console.WriteLine();
            //}
//obr 12
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            for(int c=1;c<=height;c++){
                if(c%2 !=0)
                    for(int d=1;d<=width;d++){
                        if(d%2==0)
                            Console.Write("* ");
                        else    
                            Console.Write("  ");
                    }
                else
                    for(int d=1;d<=width;d++){
                        if(d%2!=0)
                            Console.Write("* ");
                        else    
                            Console.Write("  ");
                    } 
            Console.WriteLine();
               
                
            }


            Console.WriteLine();
            

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
