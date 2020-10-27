
**Inversion of Control (IOC)**

Inversion of Control (IOC), inverting the control to some other entity
What Inversion of control principle says?

Don't Call Me, we will call you

In other words, the Main class should not have a concrete implementation of an aggregated class, rather it should depend on abstraction of that class. 


**Dependency Injection (DI)**

IOC can be done using Dependency Injection (DI). It explains how to inject the concrete implementation into a class that is using abstraction, in other words an interface inside. The main idea of dependency injection is to reduce the coupling between classes and move the binding of abstraction and concrete implementation out of the dependent class.
In Simple words, DI is how one object know about other dependent object which is abstracted.
There are mainly 4 ways of achieving the Dependency Injection.

1. Injection via Constructor
2. Injection via Property
3. Injection via Method
4. Injection via Service Locator

**Advantages of implementing this principle**

It helps in class decoupling.
Due to decoupling, the reusability of the code is increased.
Improved code maintainability and testing.


**Reference**
https://www.c-sharpcorner.com/UploadFile/cda5ba/dependency-injection-di-and-inversion-of-control-ioc/

