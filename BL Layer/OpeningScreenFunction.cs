using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;
namespace BL_Layer
{
    public class OpeningScreenFunction
    {
        ListDatas LD = new ListDatas();
       
        public void OpeningScreen()
        {
            Console.Title = "Online Shopping";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"              (*>*)/ WELCOME to Online Shopping Merch !(*<*)!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("     1.View Products");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("       2.Login to your Account  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("        3.Create Account  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\nEnter No: ");
            string answer = Console.ReadLine();
            Console.Clear();

            switch (answer)
            {
                case "1":
                    ShowProducts bl = new ShowProducts();
                    bl.showAllProducts();
                    break;
                case "2":
                    LoginFunction LF = new LoginFunction();
                    LF.LoginToAccount();
                    break;
                case "3":
                    LoginFunction Login = new LoginFunction();
                    Login.CreateAccount();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Value");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("System Restarting");
                    for (int i = 3; i > 0; i--)
                    {
                        Console.Write(i + ", ");
                        System.Threading.Thread.Sleep(500);

                    }
                    Console.Clear();
                    OpeningScreen();

                    break;
            }
        }

        public void LoginScreenQuestion()
        {
            Console.Title = "Online Shopping";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"       (*>*)/ WELCOME to Online Shopping Merch !(*<*)!\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write($"\t\t\t\t\t\t\tAccount Balance:");
            Console.ResetColor();
            //Console.WriteLine(LD.balance);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" 1.View Products");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" 2.Buy Products  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 3.Add Balance  ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" 4.Log Out  \n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write("Enter No: ");
            string answer = Console.ReadLine();
            Console.Clear();

            switch (answer)
            {
                case "1":
                    ShowProducts bl = new ShowProducts();
                    bl.showAllProducts1();
                    break;
                case "2":
                    BuyProduct bp = new BuyProduct();
                    bp.buyproduct();
                    
                    break;
                case "3":
                    CreditCard cred = new CreditCard();
                    cred.OpeningCreditCard();
                    break;
                //add acccount balance
                case "4":
                    OpeningScreen();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Value");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("System Restarting");
                    for (int i = 3; i > 0; i--)
                    {
                        Console.Write(i + ", ");
                        System.Threading.Thread.Sleep(500);

                    }
                    Console.Clear();
                    LoginScreenQuestion();
                    ;
                    break;

            }


        }
      
    }
}
