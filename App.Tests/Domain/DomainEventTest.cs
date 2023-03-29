using app.Domain;

public class DomainEventTest
{
    [Fact]
    public void ItMustHaveNonEmptyName()
    {
        var creation = () => new DomainEvent("");
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(DomainEvent.NameMustBeNonEmptyErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustHaveTheDesiredName()
    {
        var domainEvent = new DomainEvent("Some name");
        Assert.Equal(domainEvent.Name, "Some name");
    }

    [Fact]
    public void ItMustHaveTheDesiredDate()
    {
        var aDomainEvent = new DomainEvent("Some name");
        Assert.Equal(aDomainEvent.Data, null);
        var data = new { Property = "Value" };
        var anotherDomainEvent = new DomainEvent("Some name", data);
        Assert.Equal(anotherDomainEvent.Data, data);
    }
}