// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime;

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

            int gap;
            bool right;
            bool up;
            bool down;
            int repeat;
            
//obr 1
            gap = 0;
            for(int i =1; i <=height;i++){
                if(i == height/2){
                    for(int j = 1; j <=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = 1; j <=width;j++){
                        if(j == gap+1 || j == width-gap || j == width/2){
                            Console.Write("* ");
                        } else {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
                gap++;
            }
//obr 2
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for(int i =1;i <=height;i++){
                if(i == 1 || i == height || i == height/2+1){
                    for(int j = 1;j<=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = 1; j <=width;j++){
                        if(j == 1 || j ==width/2+1 ||j==width){
                            Console.Write("* ");
                        } else {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine(); 
            }
//obr 3
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = 0;
            for(int i =1;i <=height;i++){
                if(i == 1||i == height){
                    for(int j = 1;j <=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = 1;j <=width;j++){
                        if(j==1 || j==width || j == gap+1 || j == width-gap){
                            Console.Write("* ");
                        } else {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
                gap++;
            }
//obr 4
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = width-1;
            for(int i = 1;i <= height;i++){
                if(i == 1 || i == height){
                    for(int j = 1;j <=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = gap-1;j >= 0;j--){
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                }
                gap--;
                Console.WriteLine();
            }

//obr 5
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
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
  
// obr 6
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = 0;
            for(int i = 1;i <=height;i++){
                for(int j = 1; j <=width;j++){
                    if(j == 1 || j == width || j== gap+1){
                        Console.Write("* ");    
                    } else {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
                gap++;
            }

//obr 7
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = width;
            for(int i = 1; i <=height;i++){
                for(int j = 1; j <=width;j++){
                    if(j == 1 || j == width || j == gap){
                        Console.Write("* ");    
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
                gap--;
            }
//obr 8
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            for(int i = 1; i <=height;i++){
                if(i % 2 == 1){
                    for(int j = 1; j <=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = 1;j <=width;j++){
                        if(j % 2 == 1){
                            Console.Write("* ");
                        } else {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
//obr 9
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for(int i = 1; i <=height;i++){
                if(i % 3 == 0){
                    for(int j = 1; j <=width;j++){
                        Console.Write("* ");
                    }
                } else {
                    for(int j = 1; j <=width;j++){
                        if(j % 3 == 0){
                            Console.Write("* ");
                        } else {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
//obr 10
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            right = true;
            for(int i = 1;i <= height;i++){
                if(i % 2 == 1){
                    for(int j = 1; j <=width;j++){
                        Console.Write("* ");
                    }
                } else if(right == false) {
                    Console.Write("* ");
                    right = true;

                } else {
                    for(int j = 1;j <=width;j++){
                        if(j < width){
                            Console.Write("  ");
                        } else {
                            Console.Write("* ");
                        }
                    }
                    right = false;
                }
                Console.WriteLine();
            }
//obr 11
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            up = false;
            down = true;
            for(int i = 1; i <=height;i++){
                for(int j = 1; j<=width;j++){
                    if(j %2==1){
                        Console.Write("* ");
                    } else if(i == 1){
                        if(up == false){
                            Console.Write("  ");
                            up = true;
                        } else {
                            Console.Write("* ");
                            up = false;
                        }
                    } else if(i == height){
                        if(down == false){
                            Console.Write("  ");
                            down = true;
                        } else {
                            Console.Write("* ");
                            down = false;
                        }
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
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

//obr 13
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            gap = width/2;
            for(int i = 1;i <= height;i++){
                if(i <=height/2){
                    if(i == 1 || i == height/2){
                        for(int j = 1;j <=width/2;j++){
                            Console.Write("* ");
                        }
                    } else {
                        for(int j = 1;j <=width/2;j++){
                            if(j == 1 || j == width/2){
                                Console.Write("* ");
                            } else {
                                Console.Write("  ");
                            }
                        }
                    }
                } else {
                    for(int j = gap; j >0;j--){
                        Console.Write("  ");
                    }
                    if(i == height/2+1 || i == height){   
                        for(int j = width/2+1; j <=width;j++){
                            Console.Write("* ");
                        }
                    } else {
                        for(int j = width/2+1; j <=width;j++){
                            if(j == width/2+1 || j == width){
                                Console.Write("* ");
                            } else {
                                Console.Write("  ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
//obr 14
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
           
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = width/2-1;
            for(int i = 1; i <=height/2;i++){
                for(int j = 1; j <=width;j++){
                    if(j == gap+1 || j== width-gap){
                        Console.Write("* ");
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
                if(i < height/2){
                    gap--;
                }
            }
            for(int i=height/2+1;i <=height;i++){
                for(int j = 1;j <=width;j++){
                    if(j == gap+1 || j == width-gap){
                        Console.Write("* ");
                    } else {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
                gap++;
            }
//obr 16
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = width/2-1;
            for(int i =1;i <=height/2;i++){
                for(int j = gap;j > 0; j--){
                    Console.Write("  ");
                }
                for(int j = gap+1; j <=width-gap;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                if(i < height/2){
                    gap--;
                }
            }
            for(int i = height/2+1; i <=height;i++){
                for(int j = gap; j > 0;j--){
                    Console.Write("  ");
                }
                for(int j = gap+1; j <= width-gap;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                gap++;
            }
//obr 17
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = 0;
            for(int i = 1;i <=height;i++){
                for(int l = gap; l > 0; l--){
                    Console.Write("  ");
                }
                int j = gap+1;
                while( j <=width){
                    for(int k = 1; k ==1 ;k++){
                        Console.Write("* ");
                        j++;
                    }
                    for(int k = 1; k <= 2; k++){
                        Console.Write("  ");
                        j++;
                    }
                }
                Console.WriteLine();
                if(gap == 0){
                    gap = 2;
                } else {
                    gap--;
                }
            } 
//obr 18
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = 0;
            right = true;
            for(int i = 1;i <=height;i++){
                for(int l = gap; l > 0; l--){
                    Console.Write("  ");
                }
                int j = gap+1;
                while(j <= width){
                    for(int k = 1; k == 1 && j <=width; k++){
                        Console.Write("* ");
                        j++;
                    }
                    for(int k = 1; k <=2 && j <=width;k++){
                        Console.Write("  ");
                        j++;
                    }
                }
                Console.WriteLine();
                if(right == true && gap < 3){
                    gap++;
                } else if(right == false && gap > 0){
                    gap--;
                } else {
                    if(right==false){
                        right = true;
                        gap++;
                    } else {
                        right = false;
                        gap--;
                    }
                }
            }
//obr 19
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            gap = 0;
            for(int i =1;i <=height/2;i++){
                for(int j = gap;j > 0;j--){
                    Console.Write("  ");
                }
                for(int j = gap+1; j <= width-gap;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                if(i < height/2){
                   gap++; 
                }
            }
            for(int i = height/2+1; i <=height;i++){
                for(int j = gap; j >0; j--){
                    Console.Write("  ");
                }
                for(int j = gap+1;j <= width-gap;j++){
                    Console.Write("* ");
                }
                Console.WriteLine();
                gap--;
            }
//obr 20
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            repeat = 2;
            right = false;
            int rep = repeat;
            for(int i = 1;i <=height;i++){
                int j = 1;
                
                while( j <=width){
                    for(int k = 0; k < 2; k++){
                        if(right == false){
                            for(int l = repeat; l >0 && j <= width; l--){
                                Console.Write("* ");
                                j++;
                            }
                            for(int l = repeat; l >0 && j <=width; l--){
                                Console.Write("  ");
                                j++;
                            }                          
                        } else {
                            for(int l = repeat; l >0; l--){
                                Console.Write("  ");
                                j++;
                            }
                            for(int l = repeat; l >0; l--){
                                Console.Write("* ");
                                j++;
                            }
                        }
                    }
                    if(right == false && rep > 1 || right == true && rep > 1){
                        rep--;
                    } else if( right == false){
                        right = true;
                        rep = repeat;
                    } else {
                        right = false;
                        rep = repeat;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
