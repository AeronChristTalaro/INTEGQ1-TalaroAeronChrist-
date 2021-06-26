using System;
using Data_Layer;
namespace BL_Layer
{
    public class ShowProducts
    {

        ListDatas listData = new ListDatas();

        ReturnClass returnClass = new ReturnClass();
        public void showClothes()
        {
            Console.WriteLine("Clothes: ");
            Console.ForegroundColor = ConsoleColor.Red;
            listData.Clothes.ForEach(Console.Write);
            Console.WriteLine("  \n ");
            Console.ResetColor();
        }
        public void showApplliances()

        {
            Console.WriteLine("Appliances: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            listData.Appliances.ForEach(Console.Write);
            Console.WriteLine(" \n  ");
            Console.ResetColor();
        }

        public void showAllProducts()
        {
            showClothes();
            showApplliances();
            returnClass.ReturnFunction();


        }
        public void showAllProducts1()
        {
            showClothes();
            showApplliances();
            returnClass.ReturnFunction1();


        }
        public void showAllProducts2()
        {
            showClothes();
            showApplliances();
        }
    }
}