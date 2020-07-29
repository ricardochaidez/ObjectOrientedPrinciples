using System;
using ObjectOrientedPrinciples.CoffeeService.Enum;
using ObjectOrientedPrinciples.CoffeeService.Model;

namespace ObjectOrientedPrinciples.CoffeeService
{
    public class CoffeeMachine
    {
        public Coffee Coffee;
        public string CupSizeName;

        public CoffeeMachine(Coffee coffee, CupSizeEnum cupSizeEnum)
        {
            Coffee = coffee;
            switch (cupSizeEnum)
            {
                case CupSizeEnum.Small:
                    CupSizeName = "Small";
                    break;
                case CupSizeEnum.Medium:
                    CupSizeName = "Medium";
                    break;
                case CupSizeEnum.Large:
                    CupSizeName = "Large";
                    break;
            }
        }

        public Coffee BrewCoffee()
        {
            Coffee brewedCoffee = Coffee;
            DisplayProcessStep();
            return brewedCoffee;
        }

        public void DisplayProcessStep()
        {
            Console.WriteLine($"Brewing {CupSizeName} cup of {Coffee.Name}");
        }

        public void DisplayFinalStep()
        {
            Console.WriteLine("Enjoy your fresh cup of joe!");
        }
    }
}
