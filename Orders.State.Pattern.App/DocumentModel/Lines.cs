namespace Orders.State.Pattern.App.DocumentModel;

public class Lines
{
    public List<Line> Values { get; set; } = new List<Line>();

    public bool HasZeroPrices()
    {
        return Values.Any(x => x.Price == 0);
    }
}