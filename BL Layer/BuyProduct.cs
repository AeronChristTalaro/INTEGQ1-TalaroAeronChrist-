using System;
using System.Collections.Generic;
using System.Text;
using Data_Layer;
namespace BL_Layer
{

    class BuyProduct
      

    {
        ListDatas LD = new ListDatas();
        ShowProducts Sp = new ShowProducts();
        OpeningScreenFunction OP = new OpeningScreenFunction();
        public void buyproduct()
        {
            string seperator = "-----------";
            Sp.showAllProducts2();
            Console.WriteLine("\n\n1.Clothes\n2.Appliances");
            Console.Write("What product would you like to buy?");
            string answer = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Account Balance:" + LD.balance);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("             Buy Products\n");
            Console.ForegroundColor = ConsoleColor.White; ;
            if (answer == "1")
            {
                Console.WriteLine("Clothes");
                LD.Clothes.ForEach(Console.WriteLine); Console.WriteLine(seperator);
                Console.WriteLine("Clothes Price");
                LD.ClothesPrice.ForEach(Console.WriteLine); Console.WriteLine(seperator);

                Console.WriteLine("Enter the Number of the Item you want to Purchased:");
                string answer2 = Console.ReadLine();
                if (answer2 == "1")
                {
                    Console.WriteLine(LD.balance = LD.balance - 250);

                }
                else if (answer2 == "2")
                {
                    Console.WriteLine(LD.balance = LD.balance - 200);
                }
                else if (answer2 == "3")
                {
                    Console.WriteLine(LD.balance = LD.balance - 150);
                }
                else if (answer2 == "4")
                {
                    Console.WriteLine(LD.balance = LD.balance - 200);
                }
                else
                {
                    Console.WriteLine("Error... Returning to Main Screen");
                    Console.ReadKey();
                    OP.OpeningScreen();
                }

                Console.WriteLine("Item Successfully Purchased");
                Console.ResetColor();
                Console.WriteLine("Returning to Main Screen");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + ", ");
                    System.Threading.Thread.Sleep(500);

                }
                Console.Clear();
                OP.LoginScreenQuestion();

            }

        }
    }
    } 
