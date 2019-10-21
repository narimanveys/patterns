using System;
using BurgerApp.Product;

namespace BurgerApp.Builder
{
    class CheeseburgerRecipe : Recipe
    {
        Cheeseburger cheese = new Cheeseburger();

        public Cheeseburger GetResult()
        {
            return cheese;
        }

        public override void GetBunBase()
        {
            cheese.AddLayer("cheeseburger base layer");
        }

        public override void GetFilling()
        {
            cheese.AddLayer("cheese!!!!");
            cheese.AddLayer("cutlet!!!!");
            cheese.AddLayer("cheese!!!!");
        }

        public override void GetBunTop()
        {
            cheese.AddLayer("cheeseburger top layer");
        }
    }
}