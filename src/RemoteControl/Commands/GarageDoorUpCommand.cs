using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor _door;

        public GarageDoorUpCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Excecute()
        {
            _door.Up();
        }

        public void Undo()
        {
            _door.Down();
        }
    }
}
