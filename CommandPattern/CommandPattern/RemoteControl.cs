namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand commandLight;
        ICommand commandGarage;
        private bool isOn = false;
        public RemoteControl() { }

        public void SetCommand(ICommand lightcom, ICommand garagecom)
        {
            commandLight = lightcom;
            commandGarage = garagecom;
        }

        public void PushButton()
        {
            if (!isOn)
            {
                commandLight.Execute();
                commandGarage.Execute();
                isOn = true;
            }
            else
            {
                commandLight.Undo();
                commandGarage.Undo();
                isOn = false;
            }

        }
    }
}