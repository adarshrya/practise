using System;

namespace practise
{
    public sealed class LTIPayRoll : PayRoll
    {  
        public override void AddEmployee()
        {
             Console.WriteLine("LTI AddEmployee"); 
        }

        public override void DeleteEmployee()
        {
            Console.WriteLine("LTI DeleteEmployee"); 
        } 
        public override void GetSalary()
        {
            Console.WriteLine("LTI GetSalary"); 
        }
 
        public override void UpdateEmployee()
        {
            Console.WriteLine("LTI UpdateEmployee"); 
        }
    }
}