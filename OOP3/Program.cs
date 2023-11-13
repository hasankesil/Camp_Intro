using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FinanceCreditManager financeCreditManager = new FinanceCreditManager();
            //financeCreditManager.Calculate();

            ICreditManager financeCreditManager = new FinanceCreditManager();
            financeCreditManager.Calculate();




            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            vehicleCreditManager.Calculate();





            //HomeCreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();


            ICreditManager  homeCreditManager = new HomeCreditManager();
            homeCreditManager.Calculate();

            Console.ReadLine();
        }
    }
}
