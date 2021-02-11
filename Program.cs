using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFactory CGFactory = new MyFactory(ClientSystem.Capgemini);
            var CGPayroll = CGFactory.GetPayRoll();
            CGPayroll.AddEmployee();
            CGPayroll.GetSalary();
            CGPayroll.DeleteEmployee();
            CGPayroll.UpdateEmployee();

            MyFactory LTIFactory = new MyFactory(ClientSystem.LTI);
            var LTIPayroll = LTIFactory.GetPayRoll();
            LTIPayroll.AddEmployee();
            LTIPayroll.GetSalary();
            LTIPayroll.DeleteEmployee();
            LTIPayroll.UpdateEmployee();
            

            MyFactory MercFactory = new MyFactory(ClientSystem.Merc);
            var MercPayroll = MercFactory.GetPayRoll();
            MercPayroll.AddEmployee();
            MercPayroll.GetSalary();
            MercPayroll.DeleteEmployee();
            MercPayroll.UpdateEmployee();
            Console.ReadLine();
        }
    }


}
