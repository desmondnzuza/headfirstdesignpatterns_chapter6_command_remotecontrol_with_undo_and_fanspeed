using System;

namespace RemoteControl.Appliances
{
    public class CeilingLight
    {
        public void On()
        {
            Console.WriteLine("CeilingLight is on");
        }

        public void Off()
        {
            Console.WriteLine("CeilingLight is off");
        }

        public void Dim()
        {
            Console.WriteLine("CeilingLight is now dim");
        }
    }
}
