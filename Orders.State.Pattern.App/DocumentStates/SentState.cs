namespace Orders.State.Pattern.App.DocumentStates;

public class SentState : State
{
    public override void ProcessDocument()
    {
        //Only can be processed client invoices for the current year.
        if (Document.Header.Ejercicio == DateTime.Now.Year)
        {
            Document.TransitionTo(new InvoicedClientsState());
        }
    }
}