using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;
namespace BL_Layer
{
    class CreditCard
    {
        OpeningScreenFunction OF = new OpeningScreenFunction();
        LoginFunction LF = new LoginFunction();

        
        OpeningScreenFunction op = new OpeningScreenFunction();
        ListDatas LD = new ListDatas();
        public void OpeningCreditCard()
        {

            Console.WriteLine($"1.Debit Card:\t 2.Credit Card:\t 3.Gamers Card");
            Console.WriteLine("Enter # Credit Card Type");
            string answer = Console.ReadLine();
            
            if (answer == "1")
            {
                Console.WriteLine($"Debit Card:{LD.debitcard}");
                Console.WriteLine("How much balance would you add to your acc:");
                Console.WriteLine("Enter Balance:");
                int balance = Convert.ToInt32(Console.ReadLine());
                LD.debitcard = LD.debitcard - balance;
                LD.balance = LD.balance + balance;
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\tAccount Balance" + LD.balance);
                OF.LoginScreenQuestion();
                

            }
            else if (answer == "2")
            {
                Console.WriteLine($"Credit Card:{LD.creditcard}");
                Console.WriteLine("How much balance would you add to your acc:");
                Console.WriteLine("Enter Balance:");
                LD.balance = Convert.ToInt32(Console.ReadLine());
                LD.creditcard = LD.creditcard - LD.balance;

                
            }
            else if (answer == "3")
            {

                Console.WriteLine($"Gamers Card:{LD.gamerscard}");
                Console.WriteLine("How much balance would you add to your acc:");
                Console.WriteLine("Enter Balance:");
                int balance = Convert.ToInt32(Console.ReadLine());
                LD.gamerscard = LD.gamerscard - balance;
                LD.balance = LD.balance + balance;
            }
            else
            {
                Console.WriteLine("Invalid Value");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("System Returning");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + ", ");
                    System.Threading.Thread.Sleep(500);

                }
                Console.Clear();
                op.LoginScreenQuestion();
            }
            Console.WriteLine("Return to Online Shopping 1.Yes or 2.No:");
            Console.WriteLine("Enter No# of your answer:");
            string answer2 = Console.ReadLine();
            if (answer2 == "1")
            {
                Console.WriteLine("Returning to Online Shopping");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + ", ");
                    System.Threading.Thread.Sleep(500);

                }
                Console.Clear();
                op.LoginScreenQuestion();

            }
            else if (answer2 == "2")
            {
                Console.WriteLine("Your Account Balance is added to the system");
            }
            else
            {
                Console.WriteLine("Invalid Value");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("System Returning");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + ", ");
                    System.Threading.Thread.Sleep(500);

                }
                Console.Clear();
                op.LoginScreenQuestion();

            }

        }

    }
    
}
