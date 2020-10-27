namespace DiIoc.Problem
{
    public class College
    {
        private TechEvents _events;
        // What Happend if we want to add or hanlde more than one event

        public College()
        {
            _events = new TechEvents();
        }

        public void GetEvents()
        {
            _events.LoadEventDetail();
        }
    }
}