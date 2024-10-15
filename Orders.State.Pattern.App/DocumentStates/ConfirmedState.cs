namespace Orders.State.Pattern.App.DocumentStates;

public class ConfirmedState : State
{
    public override void ProcessDocument()
    {
        Document.TransitionTo(new InvoicedState());
    }
}