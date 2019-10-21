using System;
using BurgerApp.Product;

namespace BurgerApp.Builder
{
    class CheeseburgerRecipe : IRecipe<Cheeseburger>
    {
        Cheeseburger cheese = new Cheeseburger();

        public Cheeseburger Build()
        {
            return cheese;
        }

        public IRecipe<Cheeseburger> GetBunBase()
        {
            cheese.AddLayer("cheeseburger base layer");
            return this;
        }

        public IRecipe<Cheeseburger> GetFilling()
        {
            cheese.AddLayer("cheese!!!!");
            cheese.AddLayer("cutlet!!!!");
            cheese.AddLayer("cheese!!!!");
            return this;
        }

        public IRecipe<Cheeseburger> GetBunTop()
        {
            cheese.AddLayer("cheeseburger top layer");
            return this;
        }
    }
}