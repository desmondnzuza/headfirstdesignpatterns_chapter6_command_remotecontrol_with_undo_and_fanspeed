using System;

namespace RemoteControl.Appliances
{
    public class Thermostat
    {
        public void SetTemparature(int temparature)
        {
            Console.WriteLine($"Termostat setting temparature to {temparature}");
        }
    }
}