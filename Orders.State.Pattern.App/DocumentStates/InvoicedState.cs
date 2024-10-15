namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedState : State
{
    public override void ProcessDocument()
    {
        if (!Document.Lines.HasZeroPrices())
        {
            Document.TransitionTo(new ProcessedState());
        }
    }
}