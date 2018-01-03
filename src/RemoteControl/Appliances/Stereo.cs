using System;

namespace RemoteControl.Appliances
{
    public class Stereo
    {
        private readonly string _area;

        public Stereo(string area)
        {
            _area = area;
        }

        public void On()
        {
            Console.WriteLine($"{_area} Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_area} Stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine($"{_area} Stereo is set for CD input");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_area} Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_area} Stereo is set for radio input");
        }

        public void SetVolume(int newVolume)
        {
            Console.WriteLine($"{_area} Stereo setting volume to {newVolume}");
        }
    }
}