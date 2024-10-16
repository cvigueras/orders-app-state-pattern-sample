namespace Orders.State.Pattern.App.DocumentModel;

public class Header
{
    public int Exercise { get; }
    public string Client { get; }

    private Header(int exercise, string client)
    {
        Exercise = exercise;
        Client = client;
    }

    public static Header Create(int ejercicio, string cliente)
    {
        return new Header(ejercicio, cliente);
    }
}