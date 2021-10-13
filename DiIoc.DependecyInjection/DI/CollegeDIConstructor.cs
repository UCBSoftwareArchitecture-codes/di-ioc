namespace DiIoc.DependecyInjection.DI
{
    public class CollegeDIConstructor
    {
        private IEvent _event;

        public CollegeDIConstructor(IEvent ie)
        {
            _event=ie;
        }
        public void GetEvents()  
        {  
            _event.LoadEventDetail();  
        }  
    }

}