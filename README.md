# HelloCrowe
This project fills the requirements for Coding Example-Crowe Horwath(1)

## Specification
1.  Write a 'Hello World' program
  a.	The program has 1 current business requirement – write “Hello World” to the console/screen.
  b.	The program should have an API that is separated from the program logic to eventually support 
      mobile applications, web applications, or console applications, or windows services.
  c.	The program should support future enhancements for writing to a database, console application, etc.
      i.	Use common design patterns (inheritance, e.g.) to account for these future concerns.
      ii.	Use configuration files or another industry-standard mechanism for determining where to write the information to.
2.  Write unit tests to support the API.

3.  Post finished code on GitHub


## Sprint 1
From my analysis of the specs, the output can be directed to multiple destinations. I chose to implement this feature polymorphically
by defining a base message service with a write function that will have to be defined in each inherited type.

Secondly, the source of the Hello World message must be interchangable and 

Print ‘Hello World’
As a <user>, I want to display ‘Hello World’ to the console destination.

1. Create initial solution with Console Project application. Use .NET Framework 4.6.2. 
Alternatively could have coded with .NET Core if cross-platform use were required.

2. MVP meets core requirement: write the message 'Hello World' in console.

## Sprint 2
As a <user>, I want to have the ability to change the destination of the message.

1. Refactor output functionality out of the Main method
2. Add a project to encapsulate the message services.
  a. Abstract out the message service in order to implement polymorphic model for the message service.
2. Add a unit test project to cover the service project.
  
## Sprint 3


