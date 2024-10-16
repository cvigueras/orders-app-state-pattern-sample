namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedClientsDocumentState : DocumentState
{
    public override void Process()
    {
        Document!.ProcessedTime = DateTime.Now;
        Document.TransitionTo(new ProcessedDocumentState());
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}