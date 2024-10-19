using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class ConfirmedDocumentState : DocumentState
{
    public ConfirmedDocumentState(Document document) : base(document)
    {
        Document = document;
    }

    public override void Process()
    {
        Document!.TransitionTo(new InvoicedDocumentState(Document));
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}