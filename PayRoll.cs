using System;

namespace practise
{
    public abstract class PayRoll  :IPayRoll
    {
        public virtual void AddEmployee()
        { 
            Console.WriteLine("Base AddEmployee"); 
        }

        public virtual void DeleteEmployee()
        {
             Console.WriteLine("Base DeleteEmployee"); 
        }

        public virtual void GetSalary()
        {
            Console.WriteLine("Base GetSalary"); 
        }

        public virtual void UpdateEmployee()
        {
            Console.WriteLine("Base UpdateEmployee"); 
        } 
    }
}