using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Application(ICreditManager creditManager)
        {

            HomeCreditManager homeCreditManager = new HomeCreditManager();
            homeCreditManager.Calculate();
        }
    }
}
