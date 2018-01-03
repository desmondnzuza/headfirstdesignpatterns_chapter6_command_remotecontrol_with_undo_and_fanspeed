using System.Text;
using RemoteControl.Commands;

namespace RemoteControl.Controllers
{
    public class RemoteControlWithUndo
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        public RemoteControlWithUndo()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Excecute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Excecute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuffer = new StringBuilder();
            stringBuffer.Append("\n------ Remote Control ------\n");
            for (var i = 0; i < _onCommands.Length; i++)
            {
                stringBuffer.Append($"[slog {i}] {_onCommands[i].GetType()}  {_offCommands[i].GetType()} \n");
            }

            stringBuffer.Append($"[undo] {_undoCommand.GetType()}");

            return stringBuffer.ToString();
        }
    }
}

