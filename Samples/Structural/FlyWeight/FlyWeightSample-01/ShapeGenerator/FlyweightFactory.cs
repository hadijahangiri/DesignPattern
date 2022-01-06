using System.Collections;

namespace ShapeGenerator
{
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public IFlyweight GetFlyweight(string key)
        {
            if (_flyweights.Contains(key))
            {
                return _flyweights[key] as IFlyweight;
            }
            else
            {
                ConcreteFlyweight newFlyweight = new ConcreteFlyweight();

                // Set properties of new flyweight here.

                _flyweights.Add(key, newFlyweight);
                return newFlyweight;
            }
        }
    }
}
