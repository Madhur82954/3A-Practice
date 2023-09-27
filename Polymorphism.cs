using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    internal class Polymorphism
    {
        //Method Overloading
        /*public int Add(int a,int b)
        {
            return a + b;
        }
        //operator Overloading
        public string Add(string a,string b)
        {
            return a + b;
        }

        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }*/
        //Method overriding Runtime
        public virtual void getinfo()
        {
            Console.WriteLine("User Class");
        }
    }
    internal class derived :Polymorphism
    {
        public override void getinfo()
        {
            Console.WriteLine("Class");
        }
    }
}
