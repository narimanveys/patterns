namespace CommandPattern
{
    public class LightCommand : ICommand
    {
        private Light light;

        public LightCommand(Light _light)
        {
            light = _light;
        }

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}