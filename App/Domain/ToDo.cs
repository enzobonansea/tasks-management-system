namespace app.Domain;

public class ToDo
{
    public const string TitleMustBeNonEmptyErrorMessage = "Title most be non empty";
    public const string DescriptionMustBeNonEmptyErrorMessage = "Description must be non empty";
    public const string DateMustBeFutureErrorMessage = "Date must be future";

    private readonly string title;
    private readonly string description;
    private readonly DateTime date;

    public ToDo(string title, string description, DateTime date)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(ToDo.TitleMustBeNonEmptyErrorMessage);
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException(ToDo.DescriptionMustBeNonEmptyErrorMessage);
        if (date < DateTime.Now) throw new ArgumentException(ToDo.DateMustBeFutureErrorMessage);

        this.title = title;
        this.description = description;
        this.date = date;
    }
}