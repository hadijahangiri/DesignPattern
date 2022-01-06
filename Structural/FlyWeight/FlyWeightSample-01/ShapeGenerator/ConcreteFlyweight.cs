using System;

namespace ShapeGenerator
{
    public class ConcreteFlyweight : IFlyweight
    {
        public void StatefulOperation(object o)
        {
            Console.WriteLine(o);
        }
    }
}