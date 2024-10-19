using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class ClosedDocumentState : DocumentState
{
    public ClosedDocumentState(Document document) : base(document)
    {
        Document = document;
    }
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