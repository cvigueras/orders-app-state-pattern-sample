namespace Orders.State.Pattern.App.DocumentStates;

public class ProcessedState : State
{
    public override void ProcessDocument()
    {
        if (Document.ProceessedTime.HasValue)
        {
            Document.TransitionTo(new ClosedState());
        }
    }
}