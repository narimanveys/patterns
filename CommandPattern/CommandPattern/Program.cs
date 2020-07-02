using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();
            var light = new Light();
            var garageGate = new GarageGate();
            remoteControl.SetCommand(new LightCommand(light), new GarageGateCommand(garageGate));
            remoteControl.PushButton();
            remoteControl.PushButton();


            Console.Read();
        }
    }
}
