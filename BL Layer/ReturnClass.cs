using System;
using System.Collections.Generic;
using System.Text;
namespace BL_Layer
{
    class ReturnClass
    {
        public void ReturnFunction()
        {
            OpeningScreenFunction ops = new OpeningScreenFunction();
            Console.WriteLine("Do you want to return 1.Yes or 2.No");
            Console.WriteLine("Enter number of your choice");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (answer) {
                case 1:
            ops.OpeningScreen();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Value");
                    Console.ResetColor();
                    Console.WriteLine("Try again");
                    for (int i = 3; i > 0; i--)
                    {
                        Console.Write(i + ", ");
                        System.Threading.Thread.Sleep(500);

                    }
                    Console.Clear();
                    ReturnFunction();
                    ;
                    break;
            }
        }
        public void ReturnFunction1()
        {
            OpeningScreenFunction ops = new OpeningScreenFunction();
            Console.WriteLine("Do you want to return 1.Yes or 2.No");
            Console.WriteLine("Enter number of your choice");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (answer)
            {
                case 1:
                    ops.LoginScreenQuestion();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Value");
                    Console.ResetColor();
                    Console.WriteLine("Try again");
                    for (int i = 3; i > 0; i--)
                    {
                        Console.Write(i + ", ");
                        System.Threading.Thread.Sleep(500);

                    }
                    Console.Clear();
                    ReturnFunction1();
                    ;
                    break;
            }
        }
    }
}
