# Rezare.rSite.Domain

The following is a description of each area in the Domain.
This project provides a location for storing the Domain-Driven Design 

## Entities

These are objects that have an identity, and need to be distinguishable, even when they have the same values.

## ValueObjects

These represent objects in the business domain.
They are the key building blocks of the domain, and are used to replace primitive types with simple domain types, such as *Name*.

ValueObjects are defined by how they handle equality. Two ValueObjects are equal if they have the same values, rather than the same reference.

Should ValueObjects should be immutable.


 - https://deviq.com/value-object/
 - https://martinfowler.com/bliki/ValueObject.html
 - https://enterprisecraftsmanship.com/2017/06/15/value-objects-when-to-create-one/
 

 
## Enums


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