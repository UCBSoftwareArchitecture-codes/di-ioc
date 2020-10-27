namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIProperty
    {
        private IEvent _events;
        public IEvent TheEvent
        {
            set
            {
                _events = value;
            }
        }

    }
}