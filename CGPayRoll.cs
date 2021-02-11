using System;

namespace practise
{
    public sealed class CGPayRoll : PayRoll
    {
        public override void DeleteEmployee()
        {
            Console.WriteLine("CG DeleteEmployee");
        }

        public override void GetSalary()
        {
            Console.WriteLine("CG GetSalary");
        }

        public override void UpdateEmployee()
        {
            Console.WriteLine("CG UpdateEmployee");
        }
    }
}