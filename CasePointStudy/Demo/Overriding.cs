﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHOD_OVERRIDING
{

    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("This a method of PARENT class");
        }
    }
    class child : parent
    {
        public override void print()
        {
            Console.WriteLine("This a method of CHILD class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            parent p = new child();
            p.print();
            Console.ReadLine();
        }
    }
}
