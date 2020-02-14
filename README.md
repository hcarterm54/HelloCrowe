# HelloCrowe
This project fills the requirements for Coding Example-Crowe Horwath(1)

## Specification
1.  Write a 'Hello World' program
2.  The program has one current business requirement – write “Hello World” to the console/screen.
3.  The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, or console applications, or windows services.
4.  The program should support future enhancements for writing to a database, console application, etc.
5.  Use common design patterns (inheritance, e.g.) to account for these future concerns.
6.  Use configuration files or another industry-standard mechanism for determining where to write the information to.
7.  Write unit tests to support the API.
8.  Post finished code on GitHub


## Sprint 1
From my analysis of the specs, the output can be directed to multiple destinations. I chose to implement this feature polymorphically
by defining a base output service with a write function that will have to be defined in each inherited type. Normally, using an abstract class would be called for if there were a common behavior or state that would be inherited by all derived classes, so in this case we could have used an interface. I chose abstract to illustrate the override feature of inheritance

Secondly, the source of the Hello World message must be interchangable. I implemented this via an interface IMessageService

Print ‘Hello World’
As a <user>, I want to display ‘Hello World’ to the console destination.

1. Create initial solution with Console Project application. Use .NET Framework 4.6.2. 
Alternatively I could have coded with .NET Core if cross-platform use were required.

2. MVP meets core requirement: write the message 'Hello World' in console.

## Sprint 2
As a user, I want to have the ability to change the destination of the message.

1. Refactor output functionality out of the Main method
2. Add a project to encapsulate the message services and output services.
3. Add a unit test project to cover the service project.

I created tests against the message service stubs provided for future expansion. Those tests will fail until the services are implemented. They provide the behavior required for the definition of done.
