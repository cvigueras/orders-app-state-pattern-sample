using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates
{
    public abstract class DocumentState
    {
        protected Document Document;

        public void SetContext(Document document)
        {
            Document = document;
        }

        public abstract void Process();
        public abstract string GetState();
    }
}
