namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand command;

        public RemoteControl() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void PushButton()
        {
            command.Execute();
        }
        public void PushUndo()
        {
            command.Undo();
        }
    }
}