using System;

namespace RemoteControl.Appliances
{
    public class GardenLight
    {
        public void SetDuskTimer(string start, string end)
        {
            Console.WriteLine($"GardenLight set Dusk Timer to {start} - {end}");
        }

        public void SetDawnTimer(string start, string end)
        {
            Console.WriteLine($"GardenLight set Dawn Timer to {start} - {end}");
        }

        public void ManualOn()
        {
            Console.WriteLine("GardenLight is on");
        }

        public void ManualOff()
        {
            Console.WriteLine("GardenLight is off");
        }
    }
}
