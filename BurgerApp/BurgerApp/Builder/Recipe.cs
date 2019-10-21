namespace BurgerApp.Builder
{
    internal interface IRecipe<T>
    {
        IRecipe<T> GetBunBase();
        IRecipe<T> GetBunTop();
        IRecipe<T> GetFilling();
        T Build();
    }
}