using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Excecute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
