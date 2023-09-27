using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    //Single Inheritance
    public class Man
    {
        public string name;
        public int Age;

        public Man(string name,int Age)
        {
            this.name = name;
            this.Age = Age;
        }
    }
    public class Employee:Man
    {
        public int empId;
        public int salary;

        public Employee(string name, int Age, int empId, int salary) : base(name, Age)
        {
            this.empId = empId;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Age =" + Age);
            Console.WriteLine("EmpId =" + empId);
            Console.WriteLine("Salary =" + salary);
        }
    }

    //Multi-level Inheritance
    public class Grandparent
    {
        public void Home()
        {
            Console.WriteLine("Home");
        }
    }
    public class Parent : Grandparent
    {

        public void Bike()
        {
            Console.WriteLine("Bike");
        }
    }
    public class child : Parent
    {

    }

    //Multiple Inheritance - .net  doesn't support multiple Inheritance so we use Interface
    interface IPhone
    {
        public void GetPhoneDetails();

    }
    interface ICamera
    {
        public void GetCameraDetails();
    }

    public class Smartphone : IPhone, ICamera
    {
        public void GetPhoneDetails()
        {
            Console.WriteLine("Redmi");
        }
        public void GetCameraDetails()
        {
            Console.WriteLine("24 Mega Pixel Camera");
        }
        public void GetDetails()
        {
            Console.WriteLine("its a Redmi Smartphone");
        }
    }

    //Hierarchical Inheritance
    public class prnt
    {
        public void test()
        {
            Console.WriteLine("tst");
        }
    }
    public class son : prnt
    {

    }
    public class daughter : prnt
    {

    }
}
