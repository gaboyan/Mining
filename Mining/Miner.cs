using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mining
{
    class Miner
    {
        private string _name;
        private int _health;
        private int _amountsperhit;
        private int _hitsperday;
        private const int maxHealth= 100;
        private const int minHealth = 0;

        public int AmountsPerHit;

        public int HitsPerDay;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            }
        }

        public int Health {
            get { return this._health; }
            set { this._health = value;
                if (value > maxHealth) this._health = maxHealth;
                if (value < minHealth) this._health = minHealth;
            }
        }
    }
    }

