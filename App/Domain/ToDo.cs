namespace app.Domain;

public class ToDo {
    public const string TitleMustBeNonEmptyErrorMessage = "Title most be non empty";

    private readonly string title;
    
    public ToDo(string title) {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException(ToDo.TitleMustBeNonEmptyErrorMessage);
        
        this.title = title;
    }
}