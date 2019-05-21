using System.Collections.Generic;
using Rezare.rSite.Domain.SeedWork;
using Xunit;

namespace Rezare.rSite.Domain.Tests.SeedWork.ValueObjectTests
{
    public class ValueObjectScenarios
    {
        public static TheoryData<ValueObject, ValueObject, string> DifferentValueObjectsScenarios()
        {
            var valueObjectA = new BaseObject();
            var valueObjectB = new HelloObject();
            var valueObjectC = new ByeObject();

            var becauseMessage = "these objects are different";

            return new TheoryData<ValueObject, ValueObject, string>
            {
                { null, valueObjectA, becauseMessage },
                { valueObjectA, null, becauseMessage },
                { valueObjectB, valueObjectC, becauseMessage }
            };
        }

        public static TheoryData<ValueObject, ValueObject, string> EquivalentObjectsScenarios()
        {
            var baseObjectA = new BaseObject();
            var baseObjectB = new BaseObject();

            return new TheoryData<ValueObject, ValueObject, string>
            {
                { baseObjectA, baseObjectB, "both ValueObjects have equivalent instances" },
                { baseObjectB, baseObjectA, "both ValueObjects have equivalent instances" }
            };
        }

        public static TheoryData<ValueObject, ValueObject, string> NullValueObjectsScenario()
        {
            return new TheoryData<ValueObject, ValueObject, string>
            {
                { null, null, "both ValueObjects are null" }
            };
        }

        /// <summary>
        /// A child object is not equal to the parent object as it should expect
        /// a component to compare for equality that the parent object will not have.
        /// Therefore, when Equals is used to test the equality between a child and parent object,
        /// it should return false.
        /// Both base.Equals(derived) and derived.Equals(base) should be false.
        /// What about the case where Derived does not override GetEqualityComponents? Should this be false?
        /// It is expected that such a situation would/should not occur.
        /// </summary>
        /// <returns>The given scenario.</returns>
        public static TheoryData<ValueObject, ValueObject, string> DerivedObjectsAreNotEqualScenarios()
        {
            var baseObject = new BaseObject();
            var derivedObject = new DerivedObject();
            var derivedObjectNoEqualityComponents = new DerivedObjectNoEqualityComponents();

            var differentEqualityComponentsMessage =
                "Base Object is a different type to Derived Object and has different equality components";
            var differentTypesMessage = "Base Object is a different type to Derived Object";

            return new TheoryData<ValueObject, ValueObject, string>
            {
                { baseObject, derivedObject, differentEqualityComponentsMessage },
                { baseObject, derivedObjectNoEqualityComponents, differentTypesMessage },
                { derivedObject, baseObject, differentEqualityComponentsMessage },
                { derivedObject, derivedObjectNoEqualityComponents, differentTypesMessage },
                { derivedObjectNoEqualityComponents, baseObject, differentTypesMessage },
                { derivedObjectNoEqualityComponents, derivedObject, differentTypesMessage }
            };
        }

        public class HelloObject : ValueObject
        {
            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return "Hello";
            }
        }

        public class ByeObject : ValueObject
        {
            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return "Bye";
            }
        }

        public class BaseObject : ValueObject
        {
            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return "Base Hello";
            }
        }

        public class DerivedObject : BaseObject
        {
            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return "Hello Derived";
            }
        }

        public class DerivedObjectNoEqualityComponents : BaseObject
        {
        }
    }
}
