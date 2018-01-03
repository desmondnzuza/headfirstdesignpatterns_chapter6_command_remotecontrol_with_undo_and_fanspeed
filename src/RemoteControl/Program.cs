using System;
using RemoteControl.Appliances;
using RemoteControl.Commands;
using RemoteControl.Controllers;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControlWithUndo();

            var livingRoonLight = new Light("Living Room");

            var livingRoomLightOn = new LightOnCommand(livingRoonLight);
            var livingRoomLightOff = new LightOffCommand(livingRoonLight);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPressed();
            remoteControl.OffButtonWasPressed(0);
            remoteControl.OnButtonWasPressed(0);
            Console.WriteLine(remoteControl);
            remoteControl.UndoButtonWasPressed();

            Console.ReadLine();
        }
    }
}
