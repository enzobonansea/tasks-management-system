using app.Domain;

public class AggregateRootTest
{
    [Fact]
    public void ItMustEmitCreatedEvent()
    {
        var aggregate = new SomeAggregate();
        Assert.Equal(aggregate.DomainEvents.Count(), 1);
        var domainEvent = aggregate.DomainEvents.ElementAt(0);
        Assert.Equal(domainEvent.Name, $"{nameof(SomeAggregate)}Created");
        Assert.Equal(domainEvent.Data, null);

    }
}

class SomeAggregate : AggregateRoot
{
    public SomeAggregate() : base() { }
}