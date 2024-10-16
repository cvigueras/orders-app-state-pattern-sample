namespace Orders.State.Pattern.App.DocumentStates;

public class ClosedDocumentState : DocumentState
{
    public override void Process()
    {
        Document!.CloseDocument();
        Console.WriteLine("The document has been closed.");
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}