using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates;

public class ProcessedDocumentState : DocumentState
{
    public ProcessedDocumentState(Document document) : base(document)
    {
        Document = document;
    }

    public override void Process()
    {
        if (Document!.ProcessedTime.HasValue)
        {
            Document.TransitionTo(new ClosedDocumentState(Document));
        }
    }

    public override string GetState()
    {
        return this.GetType().Name;
    }
}