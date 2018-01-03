using System;

namespace RemoteControl.Appliances
{
    public class CeilingFan
    {
        private const int HIGH = 3;
        private const int MEDIUM = 2;
        private const int LOW = 1;
        private const int OFF = 0;

        private readonly string _area;
        private int _speed;

        public CeilingFan(string area)
        {
            _area = area;
            _speed = OFF;
        }

        public void High()
        {
            _speed = HIGH;
            Console.WriteLine($"{_area} CeilingFan set to high");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            Console.WriteLine($"{_area} CeilingFan set to medium");
        }

        public void Low()
        {
            _speed = LOW;
            Console.WriteLine($"{_area} CeilingFan set to low");
        }

        public void Off()
        {
            _speed = OFF;
            Console.WriteLine($"{_area} CeilingFan off");
        }

        public void GetSpeed()
        {
            Console.WriteLine($"{_area} CeilingFan speed if {_speed}");
        }
    }
}
