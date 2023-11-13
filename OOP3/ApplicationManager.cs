using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
        public void Application1(ICreditManager creditManager)
        {


            creditManager.Calculate();
        }
        public void CreditFirstInformation(List<ICreditManager> credits)
        {

            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
