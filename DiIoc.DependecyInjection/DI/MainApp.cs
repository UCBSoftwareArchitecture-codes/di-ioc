namespace DiIoc.DependecyInjection.DI
{
    public class MainApp
    {
        public static void RunMain()
        {
            //1. Injection via Constructor
            //This methodology is already discussed above, where the object of the concrete class is passed to the constructor of the dependent class.
            CollegeDIConstructor collegeByConstructor = new CollegeDIConstructor(new SoccerEvent());

            //2. Injection via Property
            //This is the most commonly used methodology where we inject the concrete class by creating a property whose type is of Interface.
            CollegeDIProperty collegeByProperty = new CollegeDIProperty();
            collegeByProperty.TheEvent = new PartyEvent();

            //3. Injection via Method
            //In this methodology, the concrete class object is passed through the method parameter to the dependent class.
            CollegeDIMethod collegeByMethod = new CollegeDIMethod();
            collegeByMethod.GetEvent(new TechEvent());

            //4. Injection via Service Locator
            //A service locator can act like a simple runtime mapper. 
            //This allows code to be added at run-time without re-compiling the application and in some cases without having to even restart it.
            CollegeDIServiceLocator collegeByServiceLocator = new CollegeDIServiceLocator(1);
            collegeByServiceLocator.GetEvents();




        }
    }
}