using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;
namespace BL_Layer
{
    class LoginFunction
    {
        
        ListDatas LD = new ListDatas();
        OpeningScreenFunction OF = new OpeningScreenFunction();

        public void CreateAccount()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"                      (*>*)/ Login Screen !(*<*)!");
            Console.WriteLine("");
            Console.ResetColor();
            Console.Write("Create your Username:");
            LD.use = Console.ReadLine();
            Console.Write("Create your Password:");
            LD.pas = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Loading");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i + ", ");
                System.Threading.Thread.Sleep(500);
            }
            Console.Clear();
            LoginToAccount();
        }
        public void LoginToAccount()

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"                      (*>*)/ Login Screen !(*<*)!");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            
            if (username == LD.email && password == LD.pass||username ==LD.use&& password==LD.pas )
            {
                Console.Clear();
                OF.LoginScreenQuestion();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"                     (*>*)/ Login Screen !(*<*)!");
                Console.WriteLine("");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Username or Password");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Invalid Username or Password");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + ", ");
                    System.Threading.Thread.Sleep(500);

                }
                Console.Clear();
                LoginToAccount();
            }

        }
    }
}
