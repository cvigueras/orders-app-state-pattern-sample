namespace Orders.State.Pattern.App.DocumentModel;

public class Lines
{
    public IEnumerable<Line> Values { get; set; }

    public bool HasZeroPrices()
    {
        return Values.Any(x => x.Price == 0);
    }
}