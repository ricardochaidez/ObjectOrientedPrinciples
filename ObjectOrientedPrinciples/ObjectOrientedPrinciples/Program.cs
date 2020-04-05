using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPrinciples.CoffeeService.Enum;
using ObjectOrientedPrinciples.CoffeeService.Model;
using ObjectOrientedPrinciples.CoffeeService;

namespace ObjectOrientedPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number for coffee selection:");

            List<Coffee> coffeeSelections = GetCoffeeSelections();
            foreach (var coffee in coffeeSelections)
            {
                Console.WriteLine($"{coffee.ID} - {coffee.Name} {coffee.RoastTypeEnum} Roast. {coffee.CoffeeSelection}");
            }

            string coffeeInput = Console.ReadLine();
            int selectedCoffeeID = 0;
            if (!int.TryParse(coffeeInput, out selectedCoffeeID))  { Console.WriteLine("Invalid Input"); return;}

            Coffee selectedCoffee = coffeeSelections.FirstOrDefault(x => x.ID == selectedCoffeeID);
            if (selectedCoffee == null) { Console.WriteLine("Coffee selection does not exists"); return; }

            Console.Write("Enter ounces of water:");
            string ouncesOfWaterInput = Console.ReadLine();
            double ouncesOfWater;
            if (!double.TryParse(ouncesOfWaterInput, out ouncesOfWater)) { Console.WriteLine("Invalid Input"); return; }

            var coffeeMachine = new CoffeeMachine(selectedCoffee, ouncesOfWater);
            var brewedCoffee = coffeeMachine.BrewCoffee();
        }

        private static List<Coffee> GetCoffeeSelections()
        {
            var coffeeSelections = new List<Coffee>();

            var colombianCoffee = new Coffee
            {
                ID = 1,
                Name = "Colombian",
                Quantity = 2, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Light,
                CoffeeSelection = CoffeeSelectionEnum.Espresso
            };
            coffeeSelections.Add(colombianCoffee);

            var arabicCoffee = new Coffee
            {
                ID = 2,
                Name = "Arabic",
                Quantity = 3, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Medium,
                CoffeeSelection = CoffeeSelectionEnum.FilteredCoffee
            };
            coffeeSelections.Add(arabicCoffee);

            var ethiopianCoffee = new Coffee
            {
                ID = 3,
                Name = "Ethiopian ",
                Quantity = 2, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Dark,
                CoffeeSelection = CoffeeSelectionEnum.Espresso
            };

            coffeeSelections.Add(ethiopianCoffee);

            return coffeeSelections;
        }
    }
}
