﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoCenter
{
    static class Program
    {
        public static Cars car;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            car = new Cars();
            car.CarPriceStandard = 23000;
            car.CarPricePeral = 23500;
            car.CarPriceCustomized = 24500;

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutoCenter());
        }
       
    }
}
