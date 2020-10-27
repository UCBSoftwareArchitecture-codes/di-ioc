namespace DiIoc.InversionOfControl
{
    public class College
    {
        private IEvent _events;

        public College(IEvent e)
        {
            _events=e;
        }

        public void GetEvents()
        {
            _events.LoadEventDetail();
        }
    }
}