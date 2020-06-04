using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();
            var light = new Light();
            remoteControl.SetCommand(new LightCommand(light));
            remoteControl.PushButton();
            remoteControl.PushUndo();

            var garageGate = new GarageGate();
            remoteControl.SetCommand(new GarageGateCommand(garageGate));
            remoteControl.PushButton();
            remoteControl.PushUndo();
            Console.Read();
        }
    }
}
