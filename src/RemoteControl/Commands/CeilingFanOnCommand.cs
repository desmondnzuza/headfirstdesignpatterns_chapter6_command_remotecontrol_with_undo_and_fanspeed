using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly CeilingFan _fan;

        public CeilingFanOnCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Excecute()
        {
            _fan.Low();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}
