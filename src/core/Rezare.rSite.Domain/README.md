# Rezare.rSite.Domain

The Domain contains enterprise-wide types and logic

The following is a description of each area in the Domain.
This project provides a location for storing the Domain-Driven Design 

## SeedWork

This is where the base objects are stored that are used with other classes in the domain.
Other names for this folder could possibly be: Shared, Common, Infrastructure, Base, Model, BaseModel ?

According to the following link:
https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/seedwork-domain-model-base-classes-interfaces
It is recommended that this folder be called SeedWork, though Common, SharedKernel, or something similar is also accepted.
This article also links to these:
https://www.artima.com/forums/flat.jsp?forum=106&thread=8826
https://martinfowler.com/bliki/Seedwork.html


## Entities

These are objects that have an identity, and need to be distinguishable, even when they have the same values.


 
## Enumerations


## Exceptions


## ValueObjects

These represent objects in the business domain.
They are the key building blocks of the domain, and are used to replace primitive types with simple domain types, such as *Name*.

ValueObjects are defined by how they handle equality. Two ValueObjects are equal if they have the same values, rather than the same reference.

Should ValueObjects should be immutable.


 - https://deviq.com/value-object/
 - https://martinfowler.com/bliki/ValueObject.html
 - https://enterprisecraftsmanship.com/2017/06/15/value-objects-when-to-create-one/

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
 - [Microsoft.CodeAnalysis.FxCopAnalyzers](https://github.com/dotnet/roslyn-analyzers)
 
 - [SecurityCodeScan.VS2017](https://security-code-scan.github.io/) To install once Warning CS4032 has been fixed.
 - [RoslynClrHeapAllocationAnalyzer](https://github.com/Microsoft/RoslynClrHeapAllocationAnalyzer) To install once VS2019 is supported.
