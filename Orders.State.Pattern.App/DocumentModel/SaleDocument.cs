namespace Orders.State.Pattern.App.DocumentModel
{
    public class Document
    {
        private DocumentStates.State _state;
        public Header Header { get; set; }
        public Lines Lines { get; set; }
        public DateTime? ProceessedTime { get; set; }
        public bool Clossed { get; set; }
        public Tipo Tipo { get; set; }


        public void TransitionTo(DocumentStates.State state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void ProcessDocument()
        {
            _state.ProcessDocument();
        }
    }
}
