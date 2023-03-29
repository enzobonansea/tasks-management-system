namespace app.Domain;

public class DomainEvent
{
    public const string NameMustBeNonEmptyErrorMessage = "Name must be non empty";

    private readonly string name;
    private readonly object? data;

    public DomainEvent(string name, object? data = null)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(DomainEvent.NameMustBeNonEmptyErrorMessage);

        this.name = name;
        this.data = data;
    }

    public string Name { get => this.name; }
    public object? Data { get => this.data; }
}