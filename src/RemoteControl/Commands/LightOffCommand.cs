using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Excecute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
