using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedClientsDocumentState : DocumentState
{
    public InvoicedClientsDocumentState(Document document) : base(document)
    {
        Document = document;
    }

    public override void Process()
    {
        Document!.ProcessedTime = DateTime.Now;
        Document.TransitionTo(new ProcessedDocumentState(Document));
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}