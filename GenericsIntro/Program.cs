﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList myList = new MyList();
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");

        }
    }
}
