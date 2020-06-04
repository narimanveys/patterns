namespace CommandPattern
{
    public class GarageGateCommand : ICommand
    {
        private GarageGate gg;

        public GarageGateCommand(GarageGate _gg)
        {
            gg = _gg;
        }

        public void Execute()
        {
            gg.Open();
        }

        public void Undo()
        {
            gg.Close();
        }
    }
}