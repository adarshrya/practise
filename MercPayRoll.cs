using System;

namespace practise
{
    public sealed class MercPayRoll : PayRoll
    {
        public override void AddEmployee()
        {
            Console.WriteLine("Merc AddEmployee");
        }

        public override void DeleteEmployee()
        {
            Console.WriteLine("Merc DeleteEmployee");
        }

        public override void GetSalary()
        {
            Console.WriteLine("Merc GetSalary");
        }

        public override void UpdateEmployee()
        {
            Console.WriteLine("Merc GetSalary");
        }
    }
}