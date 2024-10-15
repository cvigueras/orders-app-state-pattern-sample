namespace Orders.State.Pattern.App.Models
{
    public class Document
    {
        public State _state;
        public Header Header { get; set; }
        public Lines Lines { get; set; }
        public DateTime? ProceessedTime { get; set; }
        public bool Clossed { get; set; }
        public Tipo Tipo { get; set; }


        public void TransitionTo(State state)
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
