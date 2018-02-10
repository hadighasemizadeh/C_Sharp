using System;

namespace DecoratorDP
{
    public abstract class SandwichComponent
    {
        public abstract string  Name  { get; }
        public abstract decimal Price { get; }
    }
}
