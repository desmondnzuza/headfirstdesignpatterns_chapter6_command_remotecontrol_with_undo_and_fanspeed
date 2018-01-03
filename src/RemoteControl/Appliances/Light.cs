using System;

namespace RemoteControl.Appliances
{
    public class Light
    {
        private readonly string _area;

        public Light(string area)
        {
            _area = area;
        }

        public void On()
        {
            Console.WriteLine($"{_area} Light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_area} Light is off");
        }
    }
}