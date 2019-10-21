using System;
using System.Collections.Generic;

namespace BurgerApp.Product
{
    internal class Cheeseburger
    {
        private readonly List<string> layers = new List<string>();

        public void AddLayer(string layer)
        {
            layers.Add(layer);
        }

        public void GiveAway()
        {
            foreach (var layer in layers) Console.WriteLine(layer);
        }
    }
}