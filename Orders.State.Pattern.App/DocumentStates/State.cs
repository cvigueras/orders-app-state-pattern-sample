using Orders.State.Pattern.App.Models;

namespace Orders.State.Pattern.App.DocumentStates
{
    public abstract class State
    {
        protected Document Document;

        public void SetContext(Document document)
        {
            Document = document;
        }

        public abstract void ProcessDocument();
    }
}
