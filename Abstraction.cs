using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
        public abstract class Person
        {
            public string name { get; set; }
            public int age { get; set; }
            public string address { get; set; }
            public long phonenumber { get; set; }

            public void test()
            {

            }

        }
    public class student : Person
    {
        public int rollnumber { get; set; }

        public student(string name, int age, string address, long phonenumber, int rollnumber)

        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.phonenumber = phonenumber;

        }
        public void show()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(address);
            Console.WriteLine(phonenumber);
        }
    }
}
