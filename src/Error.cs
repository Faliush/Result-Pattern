namespace Result;

public sealed class Error
{
    public Error(string title, string message)
        => (Title, Message) = (title, message);

    public string Title { get; }
    public string Message { get; }
    

    public static implicit operator string(Error error) => error?.Title ?? string.Empty;

    internal static Error None => new(string.Empty, string.Empty);
}
