namespace Orders.State.Pattern.App.DocumentStates;

public class ConfirmedDocumentState : DocumentState
{
    public override void Process()
    {
        Document.TransitionTo(new InvoicedDocumentState());
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}