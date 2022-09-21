using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To QGames" );
            
        

            int bill = 0;char ch = 'Y';
            do
            {
            Game:
                Console.WriteLine("Enter \n1 for chess \n2 for sudoku  \n3 for 8 ball pool \n4 to Quit completely");
                int game = int.Parse(Console.ReadLine());
               
                switch (game)
                {

                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Welcome to Chess Master game \nselect game mode \n1 for online costs 25 Rs  \n2 for offline costs 15 Rs \n3.Back to Qgames ");
                        int mode = int.Parse(Console.ReadLine());
                        if (mode == 1)
                        {
                            Console.WriteLine("This game costs 25 Rs\n");
                            bill += 25;
                        }
                        else if (mode == 2)
                        {
                            Console.WriteLine("This game costs 15 Rs\n");
                            bill += 15;
                        }
                        else if (mode == 3)
                            goto Game;
                        
                        else
                        {
                            Console.WriteLine("choose correct mode of play");
                            goto case 1;
                        }
                        Console.WriteLine("Do You Want to Play again \nClick Y for yes any key for No");
                        ch = Convert.ToChar(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Welcome to sudoku \nThis game costs 20rs \nChoose\n1.to pay and play \n2.to Back to Qgames  ");
                        int mode2 = int.Parse(Console.ReadLine());
                        if (mode2 == 1) bill += 20;
                        else if (mode2 == 2) goto Game;
                       // else if (mode2 == 3) goto case 2;
                        else { Console.WriteLine("Choose correct option"); goto case 2; }
                        Console.WriteLine("Do You Want to Play again \nClick Y for yes any key for No");
                        ch = Convert.ToChar(Console.ReadLine());

                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Welcome To 8 ball pool \nThis is a online game");
                        Console.WriteLine("Choose \n1.to play in Sydney with 50rs \n2.to play in manchester with 100rs \n3.to Back to Qgames \n4.to Back to this game");
                        int m3 = int.Parse(Console.ReadLine());
                        if (m3 == 1) bill += 50;
                        else if (m3 == 2) bill += 100;
                        else if ((m3 == 3)) goto Game;
                        else if ((m3 == 4)) goto case 3;
                        else { Console.WriteLine("Choose correct place to play"); goto case 3; }
                        Console.WriteLine("Do You Want to Play again \nClick Y for yes any key for No");
                        ch = Convert.ToChar(Console.ReadLine());
                        break;
                    case 4:
                        ch = 'N';
                        break;
                    default:
                        Console.WriteLine("Please press Correct Number");
                        goto Game;

                }
            } while (ch == 'Y' || ch=='y');
            Console.WriteLine
                ();

            Console.WriteLine("The total game cost is Rupees {0} only \nThankyou!!",bill);
            Console.ReadLine();    
        }
    }
}
