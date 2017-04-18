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
            int days;
            int _type = 0;

            Mine mine1 = new Mine();
            Console.WriteLine("MINE DATA");
            Console.WriteLine("___________________________");
            Console.Write("Input mine name: ");
            mine1.Name = Console.ReadLine();
            //hanq.Name = "Zangezur";
            while (_type < 1 || _type > 3)
            {
                Console.Write("Input mine type (1=Gold, 2=Silver, 3=Uran): ");
                _type = GetNumber(1, 3);
            }
            switch (_type) {
                case 1: mine1.Type = MineType.Gold; break;
                case 2: mine1.Type = MineType.Silver; break;
                case 3: mine1.Type = MineType.Uran; break;
            }

            Console.Write("Input mine amount (100 - 10 000): ");
            mine1.Amount = GetNumber(100, 10000);
            Console.WriteLine("");
            Console.WriteLine("MINERS DATA");
            Console.WriteLine("___________________________");

            Miner miner1 = new Miner();
            Console.Write("Input Miners Name: ");
            miner1.Name = Console.ReadLine();
            Console.Write("Miners hits per day (1-10): ");
            miner1.HitsPerDay = GetNumber(1, 10);
            Console.Write("Miners health % (10-100): ");
            miner1.Health = GetNumber(10, 100);
            Console.Write("Amount per hit (10-500): ");
            miner1.AmountsPerHit = GetNumber(10, 500);

            Console.Write("Insert days count or 0 for violent finish: ");
            days = GetNumber(0, 100000);

            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("______________Initial data_______________");
            Console.WriteLine("Mine: {0} / Type: {1} / Amount: {2}", mine1.Name, mine1.Type, mine1.Amount);
            Console.WriteLine("Miner: {0} / Health: {1}%", miner1.Name, miner1.Health);
            Console.WriteLine("-------------------");

            if (0 == days)
            {
                while (mine1.Amount > 0 && miner1.Health>0)
                {
                    days++;
                    mine1.Amount = mine1.Amount - miner1.HitsPerDay * miner1.AmountsPerHit;
                    if (mine1.Type == MineType.Uran) miner1.Health = miner1.Health - 10;
                    else miner1.Health = miner1.Health - 1;
                    
                        Console.WriteLine("After DAY {0}", days);
                        Console.WriteLine("Mine: {0} / Type: {1} / Amount: {2}", mine1.Name, mine1.Type, mine1.Amount);
                        Console.WriteLine("Miner: {0} / Health: {1}%", miner1.Name, miner1.Health);
                        Console.WriteLine("-------------------");
                }
                if (mine1.Amount < 1) Console.WriteLine("Mine {0} is empty!", mine1.Name);
                else Console.WriteLine("Miner {0} died!", miner1.Name);

            }
            else {
                for (int i = 1; i <= days; i++)
                {
                    mine1.Amount = mine1.Amount - miner1.HitsPerDay * miner1.AmountsPerHit;
                    if (mine1.Type == MineType.Uran) miner1.Health = miner1.Health - 10;
                        else miner1.Health = miner1.Health - 1;
                if (mine1.Amount > 0 && miner1.Health > 0)
                {
                    Console.WriteLine("After DAY {0}", i);
                    Console.WriteLine("Mine: {0} / Type: {1} / Amount: {2}", mine1.Name, mine1.Type, mine1.Amount);
                    Console.WriteLine("Miner: {0} / Health: {1}%", miner1.Name, miner1.Health);
                    Console.WriteLine("-------------------");
                }
                else
                        if (mine1.Amount < 1) Console.WriteLine("Mine {0} is empty;", mine1.Name);
                else Console.WriteLine("Miner {0} is dead;", miner1.Name);
                }
            }

            Console.Read();
        } 

           
        



        static public int GetNumber(int min, int max) {
            int result=-1;

            while (result < min || result > max)
            {
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    if (result < min || result > max) Console.Write("Wrong input, try again: ");
                }
                catch (FormatException)
                {
                    Console.Write("Wrong input, try again: "); result = -1;
                }
            };

            return result;
        }
    }
}
