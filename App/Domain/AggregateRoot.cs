namespace app.Domain;

public abstract class AggregateRoot
{
    public IEnumerable<DomainEvent> DomainEvents { get; private set; }

    public AggregateRoot()
    {
        this.DomainEvents = new List<DomainEvent>() { new DomainEvent($"{this.GetType().Name}Created") };
    }
}