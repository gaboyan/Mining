using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mining
{
    class Mine
    {
        private const int MinAmount = 0;
        private const int MaxAmount= 10000;
        private string _name;
        private string _state;
        private int _amount;

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

        public MineType Type;

        public int Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if (value < MinAmount) this._amount = 0;
                else
                {
                    if (value > MaxAmount) this._amount = 10000;
                    else
                    {
                        this._amount = Convert.ToInt32(value);

                    }
                }
                //this._ammount = _ammount; 
            }
        }

        public string State
        {
            get
            {
                if (this.Amount >= 8000)
                {
                    return  "Good";
                }
                else
                {
                    if (this.Amount >= 4000)
                    {
                        return  "So-So";
                    }
                    else
                    {
                        if (this.Amount >= 100)
                        {
                            return "Lori";
                        }
                        else
                        {
                            return "Pipec";
                        }
                        
                    }
                }

            }
            set
            {
            }
        }

        public Mine()
        {
                     
        }

    }


    enum MineType
    {
        Gold=1,
        Silver=2,
        Uran=3
    }
}
