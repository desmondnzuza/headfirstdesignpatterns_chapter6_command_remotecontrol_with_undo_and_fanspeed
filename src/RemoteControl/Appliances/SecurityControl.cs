using System;

namespace RemoteControl.Appliances
{
    public class SecurityControl    
    {
        public void Arm()
        {
            Console.WriteLine("SecurityControl is armed");
        }

        public void Disarm()
        {
            Console.WriteLine("SecurityControl is disarmed");
        }
    }
}