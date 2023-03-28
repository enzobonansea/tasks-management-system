using app.Domain;

namespace app.Tests;

public class ToDoTest
{
    [Fact]
    public void ItMustHaveNonEmptyTitle()
    {
        var creation = () => new ToDo("");
        var exception = Assert.Throws<ArgumentException>(creation);
        Assert.Equal(ToDo.TitleMustBeNonEmptyErrorMessage, exception.Message);
    }
}