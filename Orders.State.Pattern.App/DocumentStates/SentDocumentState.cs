namespace Orders.State.Pattern.App.DocumentStates;

public class SentDocumentState : DocumentState
{
    public override void Process()
    {
        //Only can be processed client invoices for the current year.
        if (Document!.Header.Exercise == DateTime.Now.Year)
        {
            Document.TransitionTo(new InvoicedClientsDocumentState());
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}