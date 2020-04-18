using System;
using System.Threading;
using ObjectOrientedPrinciples.CoffeeService.Enum;
using ObjectOrientedPrinciples.CoffeeService.Model;

namespace ObjectOrientedPrinciples.CoffeeService
{
    public class CoffeeMachine
    {
        private Coffee _coffee;
        private string _cupSizeName;

        public CoffeeMachine(Coffee coffee, CupSizeEnum cupSizeEnum)
        {
            _coffee = coffee;
            switch (cupSizeEnum)
            {
                case CupSizeEnum.Small:
                    _cupSizeName = "Small";
                    break;
                case CupSizeEnum.Medium:
                    _cupSizeName = "Medium";
                    break;
                case CupSizeEnum.Large:
                    _cupSizeName = "Large";
                    break;
            }
        }

        public Coffee BrewCoffee()
        {
            Coffee brewedCoffee = _coffee;

            switch (_coffee.CoffeeSelection)
            {
                case CoffeeSelectionEnum.EspressoShot:
                    brewedCoffee = BrewEspressoShot();
                    break;
                case CoffeeSelectionEnum.Americano:
                    brewedCoffee = BrewAmericano();
                    break;
                case CoffeeSelectionEnum.Drip:
                    brewedCoffee = BrewDrip();
                    break;
                case CoffeeSelectionEnum.PourOver:
                    brewedCoffee = BrewPourOver();
                    break;
                default:
                    Console.WriteLine("Coffee Selection not chosen.");
                    break;
            }

            int count = 0;
            while (count <= 4)
            {
                Thread.Sleep(1000);
                Console.Write(".");
                count++;
            }

            brewedCoffee.IsBrewed = true;
            Console.WriteLine("Enjoy your fresh cup of joe!");

            return brewedCoffee;
        }

        private Coffee BrewEspressoShot()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew espressoShot
            return _coffee;
        }

        private Coffee BrewAmericano()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew americano
            return _coffee;
        }

        private Coffee BrewDrip()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew drip coffee
            return _coffee;
        }

        private Coffee BrewPourOver()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew pour over coffee
            return _coffee;
        }

        private void DisplayProcessStep()
        {
            Console.WriteLine($"Brewing {_cupSizeName} cup of {_coffee.Name}");
        }
    }
}
