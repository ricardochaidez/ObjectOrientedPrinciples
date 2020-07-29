using System;
using System.Threading;
using ObjectOrientedPrinciples.CoffeeService.Enum;
using ObjectOrientedPrinciples.CoffeeService.Model;

namespace ObjectOrientedPrinciples.CoffeeService
{
    public class SpecialtyCoffeeMachine : CoffeeMachine
    {
        public SpecialtyCoffeeMachine(Coffee coffee, CupSizeEnum cupSizeEnum) : base(coffee, cupSizeEnum)
        {

        }

        public Coffee BrewCoffee()
        {
            Coffee brewedCoffee = Coffee;

            switch (Coffee.CoffeeSelection)
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
            return brewedCoffee;
        }

        private Coffee BrewEspressoShot()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew espressoShot
            return Coffee;
        }

        private Coffee BrewAmericano()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew americano
            return Coffee;
        }

        private Coffee BrewDrip()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew drip coffee
            return Coffee;
        }

        private Coffee BrewPourOver()
        {
            DisplayProcessStep();
            //Do whatever needs to be done to brew pour over coffee
            return Coffee;
        }
    }
}
