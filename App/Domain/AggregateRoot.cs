namespace app.Domain;

public abstract class AggregateRoot
{
    public IEnumerable<string> DomainEvents { get; private set; }

    public AggregateRoot()
    {
        this.DomainEvents = new List<string>() { $"{this.GetType().Name}Created" };
    }
}