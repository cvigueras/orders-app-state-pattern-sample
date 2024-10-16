namespace Orders.State.Pattern.App.DocumentStates;

public class ProcessedDocumentState : DocumentState
{
    public override void Process()
    {
        if (Document.ProcessedTime.HasValue)
        {
            Document.TransitionTo(new ClosedDocumentState());
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}