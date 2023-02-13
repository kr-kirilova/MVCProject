using MVSGarden.Model;
using MVSGarden.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVSGarden.Controllers
{
   public class GardenController
    {
        private Display display;
        private Garden garden;
       public GardenController()
        {
            display = new Display();
            garden = new Garden(display.PriceVegitables , display.PriceFruits ,display.KgFruits , display.KgVegitable);
            display.Total = garden.CalculateSum();
            display.ShowResult();
        }
    }
}
