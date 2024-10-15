namespace Orders.State.Pattern.App.DocumentStates;

public class ClosedState : State
{
    public override void ProcessDocument()
    {
        Document.Clossed = true;
        Console.WriteLine("The document has been closed.");
    }
}