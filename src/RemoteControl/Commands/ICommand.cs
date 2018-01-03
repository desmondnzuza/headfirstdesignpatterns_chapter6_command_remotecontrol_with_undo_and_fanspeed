namespace RemoteControl.Commands
{
    public interface ICommand
    {
        void Excecute();
        void Undo();
    }
}
