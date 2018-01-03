using System;

namespace RemoteControl.Appliances
{
    public class HotTub    
    {
        public void Circulate(int degress)
        {
            Console.WriteLine($"HotTub is rotating by {degress}");
        }

        public void JetsOn()
        {
            Console.WriteLine("HotTub's jests are on");
        }

        public void JetsOff()
        {
            Console.WriteLine("HotTub's jests are off");
        }

        public void SetTemparature(int newTemparature)
        {
            Console.WriteLine($"HotTub's temparature changing to {newTemparature}");
        }
    }
}