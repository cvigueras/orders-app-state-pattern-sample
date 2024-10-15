using Orders.State.Pattern.App.Models;

namespace Orders.State.Pattern.App.DocumentStates
{
    public class InitState : State
    {
        public override void ProcessDocument()
        {
            //If document lines is greater than one, the document is considered a provider invoice.
            if (Document.Lines.Values.Count() > 1)
            {
                Document.Tipo = Tipo.Factura_Proveedor;
                Document.TransitionTo(new ConfirmedState());
            }

            Document.Tipo = Tipo.Factura_Cliente;
            Document.TransitionTo(new SentState());
        }
    }
}
