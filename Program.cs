using System;

namespace SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Inheritance
            /* Employee man = new Employee("naman",20,234,23000);
             man.name = "Madhur";
             man.Age = 20;
             man.empId = 123;
             man.salary = 23000;
             man.Display();

             //multi - level Inheritance
             child p = new child();
             p.Home();
             p.Bike();

             //Multiple Inheritance - using Interface as .net doesn't support multiple Inheritance
             IPhone phone= new Smartphone();
             phone.GetPhoneDetails(); */

            /*daughter d = new daughter();
            d.test();*/

            /*student s = new student("Madhur",20,"7234hyser",983473242,13);
            s.show();*/

            /*derived der = new derived();
            der.getinfo();*/

            Polymorphism pol = new Polymorphism();
            pol.getinfo();
        }
    }
}
