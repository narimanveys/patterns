using BurgerApp.Builder;

namespace BurgerApp.Director
{
    internal class Chef
    {
        Recipe recipe;

        public Chef(Recipe recipe)
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