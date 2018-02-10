namespace DecoratorDP
{
    public class WheatBread : Decorator
    {
        public WheatBread(SandwichComponent sandwichComponent) : base(sandwichComponent)
        {
            _name = "Wheat Bread";
            _price = 0.50m;
        }
    }
}