using System;

namespace RemoteControl.Appliances
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("GarageDoor stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("GarageDoor lights are on");
        }

        public void LightOff()
        {
            Console.WriteLine("GarageDoor lights are off");
        }
    }
}
