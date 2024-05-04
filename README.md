Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
Onion Architecture: (Yes/No) 
 
Have you heard of the Onion Architecture principle in software design?
--No, This is the first time i heard it and using it as a structure.
 
 
 
MVC Pattern: (Yes/No) 
 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
 --No, This is the first time of using this structure.
 
 
Web API: (Yes/No) 
 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
 --No, since i don't have a broad understanding about how Web API's works.
 
 

Application & Bottlenecks:
Onion Architecture:
 
 
Benefits: (1-3 keywords)
 
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
 
-Separation of Concerns
-Testability
-Flexibility
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 --Yes, The primary bottleneck encountered with Onion Architecture is the initial learning curve and setup overhead, especially for developers unfamiliar with the pattern.
   Additionally, maintaining the strict layering and dependencies can become challenging as the project grows in complexity.
 
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
 
 
 

MVC:

Components: (1-3 keywords each)
 
 
Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
--Components: Model (manages data), View (presents data to user), Controller (handles user interactions).
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)

Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
 
--Yes, Problems could happen when there is a close connection between the Controller and Model components, especially when it comes to managing changes and testing for bugs. Changes made to the model structure, for example, might require adjustments to the controllers as well, which could result in changes passing on across the program.
 

Web API:
 
 
Differences from MVC: (Yes/No and Briefly Explain)
 
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
--Web APIs primarily focus on providing data and services to be consumed by other applications, whereas traditional MVC applications are oriented towards serving dynamic web pages directly to users. 
  Web APIs typically use lightweight data exchange formats like JSON or XML for communication, while MVC applications generate HTML for rendering in web browsers.
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
--Yes, since i don't have a starter knowledge about how API's work in the structure of onion architecture and MVC.
 
