using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mining
{
    class Mine
    {
        private const int MinAmmount = 0;
        private const int MaxAmmount= 10000;
        private string _name;
        private string _state;
        private int _ammount;

        public string Name
        {
            get
            {
                return this.Name;
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

        public int Ammount
        {
            get
            {
                return this._ammount;
            }
            set
            {
                if (value < MinAmmount) this._ammount = 0;
                else
                {
                    if (value > MaxAmmount) this._ammount = 10000;
                    else
                    {
                        this._ammount = Convert.ToInt32(value);

                    }
                }
                //this._ammount = _ammount; 
            }
        }

        public string State
        {
            get
            {
                if (this.Ammount >= 8000)
                {
                    return  "Good";
                }
                else
                {
                    if (this.Ammount >= 4000)
                    {
                        return  "So-So";
                    }
                    else
                    {
                        if (this.Ammount >= 100)
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
