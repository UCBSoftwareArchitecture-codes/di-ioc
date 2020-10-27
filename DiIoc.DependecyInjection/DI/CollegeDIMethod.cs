namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIMethod
    {
        private IEvent _events;
        public void GetEvent(IEvent theEvent)
        {
            this._events = theEvent;

        }
    }
}