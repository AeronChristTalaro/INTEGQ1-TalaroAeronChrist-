using System;
using System.Collections.Generic;
using System.Text;
namespace Data_Layer
{
    public class ListDatas
    {

        public List<string> Clothes = new List<string> { "1.T-shirt","2.Shorts","3.Undergarments", "4.Pants" };
        public List<int> ClothesQuantity = new List<int> { 500, 500, 500, 500 };
        public List<int> ClothesPrice = new List<int> {250, 200, 150, 200 };
        public List<string> Appliances = new List<string> { "1.Refrigerator: ", "   2.Microwave:   ", "     3.Washing Machine   ", "       4.Vacuum" };
        public List<int> AppliancesQuantity = new List<int> { 500, 500, 500, 500 };
        public List<int> AppliancePrice = new List<int> { 5000, 2500, 3000, 1200 };

       public string email = "user1";
       public string pass = "user1";
        public string use;
        public string pas;

        public int balance=6000;
        public int creditcard = 100000;
        public int debitcard = 10000;
        public int gamerscard = 1000;
    }
}
