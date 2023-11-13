using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();

            //customer1.CustomerFirstName = "Engin";
            //customer1.CustomerLastName = "demiroğ";
            //customer1.Id = 1;
            //customer1.CustomerNumber = "12345";
            //customer1.TcNo = "2222222222";
            //customer1.CompanyName = "?";

            //engin demiroğ
            RealCustomer realCustomer = new RealCustomer();
            realCustomer.Id = 1;
            realCustomer.CustomerNumber = "12345";
            realCustomer.CustomerFirstName = "engin";
            realCustomer.CustomerLastName = "demirog";
            realCustomer.TcNo = "222222222";

            // kodlama.io

            IndıvıdualCustomer ındıvıdualCustomer = new IndıvıdualCustomer();

            ındıvıdualCustomer.Id = 2;
            ındıvıdualCustomer.CustomerNumber = "5234";
            ındıvıdualCustomer.CompanyName = "kodlama.io";
            ındıvıdualCustomer.Vergino = "12312312";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new IndıvıdualCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(realCustomer);
            customerManager.Add(ındıvıdualCustomer);
            customerManager.Add(customer4);
            customerManager.Add(customer3);




        }
    }
}
