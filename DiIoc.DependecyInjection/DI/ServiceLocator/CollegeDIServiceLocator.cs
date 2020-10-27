namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIServiceLocator
    {
        private IEvent _events = null;
        EventLocator el = new EventLocator();
        public CollegeDIServiceLocator(int index)
        {
            this._events = el.LocateEvent(index);
        }
        public void GetEvents()
        {
            _events.LoadEventDetail();
        }
    }
}