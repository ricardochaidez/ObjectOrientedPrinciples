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
                Console.WriteLine($"{coffee.ID} - {coffee.Name}");
            }

            string coffeeInput = Console.ReadLine();
            int selectedCoffeeID = 0;
            if (!int.TryParse(coffeeInput, out selectedCoffeeID))  { Console.WriteLine("Invalid Input"); return;}

            Coffee selectedCoffee = coffeeSelections.FirstOrDefault(x => x.ID == selectedCoffeeID);
            if (selectedCoffee == null) { Console.WriteLine("Coffee selection does not exists"); return; }

            Console.WriteLine("Select Size:");
            Console.WriteLine("1 - Small");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Large");

            string cupSizeInput = Console.ReadLine();
            byte cupSizeEnumID = 0;
            if (!byte.TryParse(cupSizeInput, out cupSizeEnumID) || cupSizeEnumID < 1 || cupSizeEnumID > 3) { Console.WriteLine("Invalid Input"); return; }

            var cupSizeEnum = (CupSizeEnum)cupSizeEnumID;

            var coffeeMachine = new CoffeeMachine(selectedCoffee, cupSizeEnum);
            var brewedCoffee = coffeeMachine.BrewCoffee();
            coffeeMachine.DisplayFinalStep();
        }

        private static List<Coffee> GetCoffeeSelections()
        {
            var coffeeSelections = new List<Coffee>();

            var espressoShotCoffee = new Coffee
            {
                ID = 1,
                Name = "Espresso-Shot",
                Quantity = 2, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Light,
                CoffeeSelection = CoffeeSelectionEnum.EspressoShot
            };
            coffeeSelections.Add(espressoShotCoffee);

            var dripCoffee = new Coffee
            {
                ID = 2,
                Name = "Drip Coffee",
                Quantity = 3, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Medium,
                CoffeeSelection = CoffeeSelectionEnum.Drip
            };
            coffeeSelections.Add(dripCoffee);

            var americanoCoffee = new Coffee
            {
                ID = 3,
                Name = "Americano",
                Quantity = 2, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Dark,
                CoffeeSelection = CoffeeSelectionEnum.Americano
            };

            coffeeSelections.Add(americanoCoffee);

            var pourOverCoffee = new Coffee
            {
                ID = 4,
                Name = "Pour Over Coffee ",
                Quantity = 2, //Tablespoons
                RoastTypeEnum = RoastTypeEnum.Dark,
                CoffeeSelection = CoffeeSelectionEnum.PourOver
            };

            coffeeSelections.Add(pourOverCoffee);

            return coffeeSelections;
        }
    }
}
