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
            int k;


            Mine hanq = new Mine();
            hanq.Name = "Zangezur";
            hanq.Type = MineType.Uran;
            hanq.Ammount = 10;

            Miner Poghos = new Miner();
            Poghos.HitsPerDay=5;
            Poghos.Health = 98;
            Poghos.AmmountsPerHit = 300;

            Console.WriteLine("Insert Days count or leave blank for deadly finish.");
            k = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("State: " + hanq.State + ", Ammount: " + hanq.Ammount);
            Console.Read();
        }
    }
}
