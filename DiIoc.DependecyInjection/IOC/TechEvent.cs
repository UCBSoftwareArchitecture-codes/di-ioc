using System;

namespace DiIoc.DependecyInjection
{
    public class TechEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Technology Event Details");

        }
    }
}