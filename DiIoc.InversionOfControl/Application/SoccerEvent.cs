using System;

namespace DiIoc.InversionOfControl
{
    public class SoccerEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Soccer Event Details");

        }
    }
}