// See https://aka.ms/new-console-template for more information
public interface ISpecifcation<T>
{
    bool IsSatisfiedBy(T specifcation);
}

public class LetterOnlySpecification<stingg> : ISpecifcation<string>
{
    public bool IsSatisfiedBy(string specifcation)
    {
        return true;
    }
}
