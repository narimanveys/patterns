using System;
using BurgerApp.Builder;
using BurgerApp.Director;
using BurgerApp.Product;

namespace BurgerApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MENU:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Hamburger");
            Console.WriteLine("2. Cheeseburger");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n Type your choose number:");
            Console.ResetColor();

            int pickedNumber = Convert.ToInt32(Console.ReadLine());

            switch (pickedNumber)
            {
                case 1:
                    HamburgerSelected();
                    break;
                case 2:
                    CheeseSelected();
                    break;
                default:
                    Console.WriteLine("Паламалася я");
                    break;
            }

            Console.ReadKey();
        }

        private static void CheeseSelected()
        {
            CheeseburgerRecipe burgerRecipe = new CheeseburgerRecipe();

            Chef chef = new Chef(burgerRecipe);
            chef.Gather();

            Cheeseburger burger = burgerRecipe.GetResult();
            burger.GiveAway();
        }

        private static void HamburgerSelected()
        {
            HamburgerRecipe burgerRecipe = new HamburgerRecipe();

            Chef chef = new Chef(burgerRecipe);
            chef.Gather();

            Hamburger burger = burgerRecipe.GetHamburger();
            burger.GiveAway();
        }
    }
}