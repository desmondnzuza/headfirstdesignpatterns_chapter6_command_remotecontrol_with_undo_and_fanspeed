using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Excecute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
        }
    }
}
