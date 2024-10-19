using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class SentDocumentState : DocumentState
{
    public SentDocumentState(Document document) : base(document)
    {
        Document = document;
    }

    public override void Process()
    {
        //Only can be processed client invoices for the current year.
        if (Document!.Header.Exercise == DateTime.Now.Year)
        {
            Document.TransitionTo(new InvoicedClientsDocumentState(Document));
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}