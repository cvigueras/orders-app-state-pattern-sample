namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedDocumentState : DocumentState
{
    public override void Process()
    {
        if (!Document.Lines!.HasZeroPrices())
        {
            Document.TransitionTo(new ProcessedDocumentState());
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}