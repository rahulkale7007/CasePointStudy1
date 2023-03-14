﻿using System;

namespace METHOD_OVERLOADING
{
    class Program
    {

        public void Add()
        {
            int a = 20;
            int b = 30;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
       public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
               p.Add(2.5f, 1.5f);
            p.Add(10, 5);
            p.Add("Adil", "Mehmood");
            Console.ReadLine();
        }
    }
}
