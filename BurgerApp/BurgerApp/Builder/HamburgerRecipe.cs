using System;
using BurgerApp.Product;

namespace BurgerApp.Builder
{
    class HamburgerRecipe : Recipe
    {
        Hamburger hamburger = new Hamburger();

        public Hamburger GetHamburger()
        {
            return hamburger;
        }

        public override void GetBunBase()
        {
            hamburger.AddLayer("Hamburger base layer");
        }

        public override void GetFilling()
        {
            hamburger.AddLayer("cutlet!!!!");
            hamburger.AddLayer("lettuce leaf");
        }

        public override void GetBunTop()
        {
            hamburger.AddLayer("Hamburger top layer");
        }
    }
}