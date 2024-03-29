﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVSTransport.Views
{
   public  class Display
    {
        public int Km { get; set; }
        public string TimeOfDay { get; set; }

        public double TotalPrice { get; set; }
        public Display()
        {
            this.Km = 0;
            this.TimeOfDay = string.Empty;
        }
        public void GetValues()
        {
            this.Km = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();
            this.TotalPrice = 0;
            this.GetValues();
        }
        public void ShowResult()
        {
            Console.WriteLine($"{this.TotalPrice:f2}");
        }
    }
}
