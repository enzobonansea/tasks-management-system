namespace app.Domain;

public class ToDo
{
    public const string TitleMustBeNonEmptyErrorMessage = "Title most be non empty";
    public const string DescriptionMustBeNonEmptyErrorMessage = "Description must be non empty";

    private readonly string title;
    private readonly string description;

    public ToDo(string title, string description, DateTime date)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(ToDo.TitleMustBeNonEmptyErrorMessage);
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException(ToDo.DescriptionMustBeNonEmptyErrorMessage);

        this.title = title;
        this.description = description;
    }
}