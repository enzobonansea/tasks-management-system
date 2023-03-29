using app.Domain;

namespace app.Tests;

public class ToDoTest
{
    [Fact]
    public void ItMustHaveNonEmptyTitle()
    {
        var creation = () => new ToDo("", "", DateTime.Now);
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.TitleMustBeNonEmptyErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustHaveNonEmptyDescription()
    {
        var creation = () => new ToDo("Some title", "", DateTime.Now);
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.DescriptionMustBeNonEmptyErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustHaveAFutureDate()
    {
        var yesterday = DateTime.Now.AddDays(-1);
        var creation = () => new ToDo("Some title", "Some description", yesterday);
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.DateMustBeFutureErrorMessage, exception.Message);
    }

    [Fact]
    public void ItMustEmitToDoCreatedEvent() { }
}