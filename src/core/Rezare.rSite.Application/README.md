# Rezare.rSite.Application

Application contains application-specific types and logic

This is also known as the Use Cases project. This is where the business logic resides and uses the objects from the Application layer.

## UseCases

This structures the project closer to behaviour-driven development (BDD).

http://www.plainionist.net/Implementing-Clean-Architecture-UseCases/

### Potential UseCases

 - Produce Links


## Interfaces

These are our external interfaces. These interfaces represent our external dependencies, and their implementations get injected into our use cases.

These are the interfaces that projects referencing Rezare.rSite.Application needs to implement to make use of the Application layer.



## Nuget Packages

### Analyzers

 - [StyleCop.Analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers)
 - [CSharpGuidelinesAnalyzer](https://csharpcodingguidelines.com/)
 - [SonarAnalyzer.CSharp](https://www.sonarsource.com/products/codeanalyzers/sonarcsharp.html)
 - [codecracker.CSharp](http://code-cracker.github.io/)
 - [Roslynator.Analyzers](https://github.com/JosefPihrt/Roslynator)
 - [Roslynator.CodeFixes](https://github.com/JosefPihrt/Roslynator)
 - [ErrorProne.NET](https://github.com/SergeyTeplyakov/ErrorProne.NET)
 - [ErrorProne.NET.Structs](https://github.com/SergeyTeplyakov/ErrorProne.NET)
 - [ErrorProne.NET.CoreAnalyzers](https://github.com/SergeyTeplyakov/ErrorProne.NET)
 - [ReflectionAnalyzers](https://github.com/DotNetAnalyzers/ReflectionAnalyzers)
 - [SecurityCodeScan](https://security-code-scan.github.io/)

 - [RoslynClrHeapAllocationAnalyzer](https://github.com/Microsoft/RoslynClrHeapAllocationAnalyzer) To install once VS2019 is supported.