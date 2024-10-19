using Orders.State.Pattern.App.DocumentStates;

namespace Orders.State.Pattern.App.DocumentModel
{
    public class Document
    {
        private DocumentState _state;
        public Guid Number { get; }
        public Header Header { get; }
        public Lines? Lines { get; }
        public DateTime? ProcessedTime { get; set; }
        public bool Closed { get; private set; }
        public Tipo Type { get; private set; }

        private Document(Header header)
        {
            Number = Guid.NewGuid();
            Header = header;
            Lines = new Lines();
            _state = new InitDocumentState(this);
        }

        public static Document Create(Header header)
        {
            return new Document(header);
        }

        public void RegisterLine(Line line)
        {
            Lines!.Values.Add(line);
        }

        public void TransitionTo(DocumentState state)
        {
            Type = state switch
            {
                ConfirmedDocumentState => Tipo.FacturaProveedor,
                SentDocumentState => Tipo.FacturaCliente,
                _ => Type
            };
            _state = state;
        }

        public void Process()
        {
            _state.Process();
        }

        public void Close()
        {
            Closed = true;
        }

        public string GetState() => _state.GetState();
    }
}
