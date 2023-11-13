using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
   public class Program
    {
        static void Main(string[] args)
        {
            //FinanceCreditManager financeCreditManager = new FinanceCreditManager();
            //financeCreditManager.Calculate();

            ICreditManager financeCreditManager = new FinanceCreditManager();
           




            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
         





            //HomeCreditManager homeCreditManager = new HomeCreditManager();
            //homeCreditManager.Calculate();


            ICreditManager  homeCreditManager = new HomeCreditManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Application1(financeCreditManager);
            applicationManager.Application1(vehicleCreditManager, databaseLoggerService);
            //applicationManager.Application1(homeCreditManager);

            
           
           

            List<ICreditManager> credits = new List<ICreditManager> { financeCreditManager, vehicleCreditManager };

            //applicationManager.CreditFirstInformation(credits);



            Console.ReadLine();
           
        }
    }
}
