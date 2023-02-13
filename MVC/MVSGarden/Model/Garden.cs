using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVSGarden.Model
{
   public  class Garden
    {
        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitable { get; set; }
        public int KgFruits { get; set; }
        public decimal CalculateSum()
        {
            return 1.94m * (this.KgFruits * this.PriceFruits + this.KgVegitable * this.PriceVegitables);
        }
    }
}
