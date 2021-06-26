namespace Person.Domain
{
    public interface ICloneable<T>
    {
        T ShallowCopy();
        T DeepCopy();
    }
}