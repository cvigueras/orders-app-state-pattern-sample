using Orders.State.Pattern.App.DocumentModel;

namespace Orders.State.Pattern.App.DocumentStates
{
    public abstract class DocumentState(Document? document)
    {
        protected Document? Document = document;

        public abstract void Process();
        public abstract string GetState();
    }
}
