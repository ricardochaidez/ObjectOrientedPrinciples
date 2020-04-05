using System;
using System.Threading;
using ObjectOrientedPrinciples.CoffeeService.Enum;
using ObjectOrientedPrinciples.CoffeeService.Model;

namespace ObjectOrientedPrinciples.CoffeeService
{
    public class CoffeeMachine
    {
        private Coffee _coffee;
        private double _ouncesOfWater;

        public CoffeeMachine(Coffee coffee, double ouncesOfWater)
        {
            _coffee = coffee;
            _ouncesOfWater = ouncesOfWater;
        }

        public Coffee BrewCoffee()
        {
            Coffee brewedCoffee = _coffee;

            switch (_coffee.CoffeeSelection)
            {
                case CoffeeSelectionEnum.Espresso:
                    brewedCoffee = BrewEspresso();
                    break;
                case CoffeeSelectionEnum.FilteredCoffee:
                    brewedCoffee = BrewFilteredCoffee();
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

        private Coffee BrewEspresso()
        {
            Console.WriteLine($"Brewing {_ouncesOfWater}oz of {_coffee.Name} espresso coffee");
            return _coffee;
        }

        private Coffee BrewFilteredCoffee()
        {
            Console.WriteLine($"Brewing {_ouncesOfWater}oz of {_coffee.Name} filtered coffee");
            return _coffee;
        }
    }
}
