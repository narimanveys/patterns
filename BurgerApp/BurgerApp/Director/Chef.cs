using BurgerApp.Builder;

namespace BurgerApp.Director
{
    internal class Chef
    {
        IRecipe recipe;

        public Chef(IRecipe recipe)
        {
            this.recipe = recipe;
        }

        public void Gather()
        {
            recipe.GetBunBase();
            recipe.GetFilling();
            recipe.GetBunTop();
        }
    }
}