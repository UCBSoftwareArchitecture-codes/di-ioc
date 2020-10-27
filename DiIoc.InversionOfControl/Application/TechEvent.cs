using System;

namespace DiIoc.InversionOfControl
{
    public class TechEvent : IEvent
    {
        public void LoadEventDetail()
        {
            Console.WriteLine("Technology Event Details");

        }
    }
}