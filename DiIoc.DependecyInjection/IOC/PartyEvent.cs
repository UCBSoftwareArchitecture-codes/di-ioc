using System;
namespace DiIoc.DependecyInjection
{
    public class PartyEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Party Event Details");
        }
    }
}