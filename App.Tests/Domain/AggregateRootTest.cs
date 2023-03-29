using app.Domain;

public class AggregateRootTest
{
    [Fact]
    public void ItMustEmitCreatedEvent()
    {
        var aggregate = new SomeAggregate();
        Assert.Equal(aggregate.DomainEvents.Count(), 1);
        Assert.Equal(aggregate.DomainEvents.ElementAt(0), $"{nameof(SomeAggregate)}Created");
    }
}

class SomeAggregate : AggregateRoot
{
    public SomeAggregate() : base() { }
}