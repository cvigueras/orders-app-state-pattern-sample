namespace Orders.State.Pattern.App.DocumentStates;

public class InvoicedClientsState : State
{
    public override void ProcessDocument()
    {
        Document.ProceessedTime = DateTime.Now;
        Document.TransitionTo(new ProcessedState());
    }
}