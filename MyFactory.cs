using System;

namespace practise
{
    public class MyFactory
    {
        readonly ClientSystem CurSystem;
        public MyFactory(ClientSystem SystemName)
        {
            CurSystem = SystemName;
        }

        public PayRoll GetPayRoll()
        {
            PayRoll payRoll = null;
            switch (CurSystem)
            {
                case ClientSystem.Capgemini:
                    payRoll = new CGPayRoll();
                    break;
                case ClientSystem.LTI:
                    payRoll = new LTIPayRoll();
                    break;
                case ClientSystem.Merc:
                    payRoll = new MercPayRoll();
                    break;
                default:
                    break;
            }
            return payRoll;
        }
    }
}