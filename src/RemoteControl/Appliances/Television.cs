using System;

namespace RemoteControl.Appliances
{
    public class Television
    {
        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void SetInputChannel(string newChannnel)
        {
            Console.WriteLine($"TV changing channel to {newChannnel}");
        }

        public void SetVolume(int newVolume)
        {
            Console.WriteLine($"TV setting volume to {newVolume}");
        }
    }
}
