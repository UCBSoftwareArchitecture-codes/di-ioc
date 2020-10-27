using System;

namespace DiIoc.DependecyInjection
{
    public class SoccerEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Soccer Event Details");

        }
    }
}