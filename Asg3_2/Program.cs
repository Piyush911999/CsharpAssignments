using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg3_2
{  
    class Program
    {
        public static void Main(string[] args)
        {
            Employee ob1 = new Hr();
            ob1.HrSalary();
            Employee ob2 = new Developer();
            ob2.DevSalary();
        }
    }

    public abstract class Employee
    {
        public string Id;
        public string Name;
        public string Designation;
        public int Experience;
        public double AnnualSalary;
        public string JoiningDate;


        abstract public void HrSalary();
        abstract public void DevSalary();
    }

    public class Hr : Employee
    {
        public override void DevSalary()
        {
            throw new NotImplementedException();
        }
        public override void HrSalary()
        {
            Hr ob1 = new Hr();
            ob1.Designation = "HR";
            ob1.Experience = 4;
            ob1.AnnualSalary = 8000 + (1000 * 4);
            Console.WriteLine("The salary for HR is " + ob1.AnnualSalary);
        }

    }

    public class Developer : Employee
    {
        public override void DevSalary()
        {
            Developer ob2 = new Developer();
            ob2.Designation = "Developer";
            ob2.Experience = 5;
            ob2.AnnualSalary = 8000 + (2000 * 5);
            Console.WriteLine("The salary for Developer is " + ob2.AnnualSalary);
        }
        public override void HrSalary()
        {
            throw new NotImplementedException();
        }
    }

}
