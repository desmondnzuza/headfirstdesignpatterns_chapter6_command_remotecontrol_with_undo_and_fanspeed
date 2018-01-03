using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private readonly CeilingFan _fan;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Excecute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.Low();
        }
    }
}
