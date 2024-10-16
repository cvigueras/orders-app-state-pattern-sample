namespace Orders.State.Pattern.App.DocumentModel;

public class Line
{
    public Guid DocumentNumber { get; }
    public int Exercise { get;}
    public int LineNumber { get; }
    public string Mark { get; }
    public double Price { get; }

    private Line(Guid documentNumber, int exercise, int lineNumber, string mark, double price)
    {
        DocumentNumber = documentNumber;
        Exercise = exercise;
        LineNumber = lineNumber;
        Mark = mark;
        Price = price;
    }

    public static Line Create(Guid documentNumber, int exercise, int lineNumber, string mark, double price)
    {
        return new Line(documentNumber, exercise, lineNumber, mark, price);
    }
}