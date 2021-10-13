namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIServiceLocator
    {
        private IEvent _event;
        private EventLocator _el;
        public CollegeDIServiceLocator(int index)
        {
            _el = new EventLocator();
            this._event = _el.LocateEvent(index);
        }
        public void GetEvents()
        {
            _event.LoadEventDetail();
        }
    }
}