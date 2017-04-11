using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mining
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string temp;

            Mine mine1 = new Mine();
            mine1.Name = "Zangezur";
            mine1.Type = MineType.Uran;
            mine1.Ammount = 8200;
            temp = mine1.State;
            Console.WriteLine(temp);
            Console.Read();
        }
    }
}
