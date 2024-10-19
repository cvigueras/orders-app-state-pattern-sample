using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates
{
    public class InitDocumentState : DocumentState
    {
        public InitDocumentState(Document document) : base(document)
        {
            Document = document;
        }

        public override void Process()
        {
            //If document lines is greater than one, the document is considered a provider invoice.
            if (Document!.Lines!.Values.Count() > 1)
            {
                Document.TransitionTo(new ConfirmedDocumentState(Document));
                return;
            }
            Document.TransitionTo(new SentDocumentState(Document));
        }

        public override string GetState()
        {
            return this.GetType().Name;
        }
    }
}
