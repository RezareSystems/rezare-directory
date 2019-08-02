# r-Site
A website showing all the useful Rezare links.

## Tools in use
 - **Swashbuckle.AspNetCore**
   This allows Swagger to be used to access Api end points.
   Swagger json documentation can also be generated and loaded into PostMan.

## Nuget Packages
   
 - xunit
 - xunit.runner.visualstudio
 - FluentAssertions

### Analyzers

 - xunit.analyzers
 - FluentAssertions.Analyzers
 
## Layers

Trying to avoid anaemic models anti-pattern, so models should be rich (have functionality rather than just being DTOs).

### core

#### Rezare.rSite.Domain

This holds all core entities of the project
 - Domain Logic - logic that only relates to the domain objects.
 - Entities
 - Enterprise Business rules
 
#### Rezare.rSite.Application
 - The business logic

 - Application Business Rules
   - The rules that govern what should occur in a given situation, such as Creating a new database object, the application layer facilitates these actions.

### infrastructure
 

 
 https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio