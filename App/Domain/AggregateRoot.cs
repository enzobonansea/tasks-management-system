public abstract class AggregateRoot
{
    public IEnumerable<string> DomainEvents { get; private set; }

    public AggregateRoot()
    {

    }
}