using app.Domain;

namespace app.Tests;

public class ToDoTest
{
    [Fact]
    public void ItMustHaveNonEmptyTitle()
    {
        var creation = () => new ToDo("", "");
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.TitleMustBeNonEmptyErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustHaveNonEmptyDescription()
    {
        var creation = () => new ToDo("Some title", "");
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.DescriptionMustBeNonEmptyErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustHaveAFutureDate() { }

    [Fact]
    public void ItMustEmitToDoCreatedEvent() { }
}