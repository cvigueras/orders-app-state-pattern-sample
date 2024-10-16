using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates
{
    public class InitDocumentState : DocumentState
    {
        public override void Process()
        {
            //If document lines is greater than one, the document is considered a provider invoice.
            if (Document.Lines!.Values.Count() > 1)
            {
                Document.TransitionTo(new ConfirmedDocumentState());
                return;
            }
            Document.TransitionTo(new SentDocumentState());
        }

        public override string GetState()
        {
            return this.GetType().Name;
        }
    }
}
