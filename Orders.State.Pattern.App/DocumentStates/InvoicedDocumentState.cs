using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedDocumentState : DocumentState
{
    public InvoicedDocumentState(Document document) : base(document)
    {
        Document = document;
    }

    public override void Process()
    {
        if (!Document!.Lines!.HasZeroPrices())
        {
            Document.TransitionTo(new ProcessedDocumentState(Document));
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}