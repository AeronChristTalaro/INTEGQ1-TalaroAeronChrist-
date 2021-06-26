using System;
using BL_Layer;
using Data_Layer;
namespace UILAYER
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WindowHeight = 30;
            Console.WindowWidth = 80;
        
            OpeningScreenFunction ops = new OpeningScreenFunction();

            ops.OpeningScreen();


        }

    }
}
