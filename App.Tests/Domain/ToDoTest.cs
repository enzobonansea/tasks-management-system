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
    public void ItMustHaveTheDesiredTitle()
    {
        var toDo = new ToDo("Some title", "Some description", DateTime.Now.AddDays(1));
        Assert.Equal(toDo.Title, "Some title");
    }

    [Fact]
    public void ItMustHaveTheDesiredDescription()
    {
        var toDo = new ToDo("Some title", "Some description", DateTime.Now.AddDays(1));
        Assert.Equal(toDo.Description, "Some description");
    }

    [Fact]
    public void ItMustHaveTheDesiredDate()
    {
        var date = DateTime.Now.AddDays(1);
        var toDo = new ToDo("Some title", "Some description", date);
        Assert.Equal(toDo.Date, date);
    }
}