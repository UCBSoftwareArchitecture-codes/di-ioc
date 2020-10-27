namespace DiIoc.DependecyInjection.DI
{
    public class EventLocator 
    {
        public IEvent LocateEvent(int index)  
        {  
            if (index == 1)  
                return new SoccerEvent();  
            else if (index == 2)  
                return new PartyEvent();  
            else  
                return new TechEvent();  
        }  
    }
}