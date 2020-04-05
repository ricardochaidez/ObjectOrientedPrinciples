using ObjectOrientedPrinciples.CoffeeService.Enum;

namespace ObjectOrientedPrinciples.CoffeeService.Model
{
    public class Coffee
    {
        public int ID;
        public string Name;
        public double Quantity;
        public RoastTypeEnum RoastTypeEnum;
        public CoffeeSelectionEnum CoffeeSelection;
        public bool IsBrewed;
    }
}
