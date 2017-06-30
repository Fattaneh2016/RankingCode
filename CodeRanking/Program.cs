using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Console.Read();
            Console.ReadLine();
            int tipPercent = Console.Read();
            Console.ReadLine();
            int taxPercent = Console.Read();
            Console.ReadLine();

            tipPercent= (int) (mealCost * tipPercent) / 100;
            taxPercent = (int) (mealCost * taxPercent) / 100;
            var totalCost = (int)mealCost + taxPercent + tipPercent;

            Console.WriteLine(totalCost);
            Console.ReadLine();

            //totalCost = (int)Math.Round(totalCost + 0.5);
            //Console.WriteLine(totalCost);
            //Console.ReadLine();
        }
    }
}
