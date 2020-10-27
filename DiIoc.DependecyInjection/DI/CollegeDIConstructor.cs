namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIConstructor
    {
        private IEvent _events;

        public CollegeDIConstructor(IEvent ie)
        {
            _events=ie;
        }
        public void GetEvents()  
        {  
            _events.LoadEventDetail();  
        }  
    }

}