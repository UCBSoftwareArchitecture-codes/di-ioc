using System;
namespace DiIoc.InversionOfControl
{
    public class PartyEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Party Event Details");
        }
    }
}