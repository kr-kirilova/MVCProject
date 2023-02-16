using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVSTransport.Model
{
  public   class Transport
    {
        public Transport(int km, string timeOfDay)
        {
           this.Km = km;
            this.TimeOfDay = timeOfDay;
        }

        public int Km { get; set; }
        public string TimeOfDay { get; set; }

        public double CalculatePrice()
        {
            double price = 0;
            if (this.Km >= 100)
            {
                price = this.Km * 0.06;
                return price;
            }
            else if (this.Km >= 20 && this.Km < 100)
            {
                price = this.Km * 0.09;
                return price;
            }
            else
            {
                if (this.TimeOfDay == "day")
                {
                    price = this.Km * 0.79 + 0.70;
                    return price;
                }
                else
                {
                    price = this.Km * 0.90 + 0.70;
                    
                }

            }    return price;
        }

    }
}

