namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIServiceLocator
    {
        private IEvent _events;
        private EventLocator _el;
        public CollegeDIServiceLocator(int index)
        {
            _el = new EventLocator();
            this._events = _el.LocateEvent(index);
        }
        public void GetEvents()
        {
            _events.LoadEventDetail();
        }
    }
}