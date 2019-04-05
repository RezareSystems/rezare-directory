# Testing structure

 - https://codeutopia.net/blog/2015/04/11/what-are-unit-testing-integration-testing-and-functional-testing/
 - https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-2.2
 
## Project Types

The projects under *src* should have corresponding test projects, with each project containing certain types of tests:
 - unit
 - integration
 - functional
 
The test project naming convention is based on code examples provided with the book: *Dependency Injection: Principles, Practices, and Patterns*

Company.Product.Feature.Tests.Unit
Company.Product.Feature.Tests.Integration
Company.Product.Feature.Tests.System


### Unit Tests



### Integration Tests

If Integration tests follow the Company.Product.Feature.Tests.Integration approach,
then they should only be concerned with ensuring components within the project are able to work and communicate well with each other.

### Functional or System Tests

https://dzone.com/articles/why-you-need-to-care-about-automated-functional-te
https://www.softwaretestingclass.com/system-testing-what-why-how/

These tests are end to end (E2E), and is Black Box testing.

Should this be in its own project? Repositories such as https://github.com/aspnet/EntityFrameworkCore/tree/master/test
have projects named FunctionalTests.

This includes performance, load and stress testing.

Should there be a project for this type of testing in the solution, or is this testing all external to the solution?
Or is Functional testing just performed by dedicated Testers.
Is this where Selenium would live?

## Other types of automated testing

 - Acceptance Testing - this is performed by the stake holders or end users and is independent of the developers and testers.
   
   Acceptance Testing vs System Testing
   
   https://www.softwaretestingclass.com/difference-between-system-testing-and-acceptance-testing/
   https://inedo.com/blog/how-automation-can-help-you-at-all-five-stages-of-software-testing
   