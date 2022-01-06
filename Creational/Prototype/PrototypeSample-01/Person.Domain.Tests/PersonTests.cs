using System;
using System.Collections.Generic;
using Xunit;

namespace Person.Domain.Tests
{
    public class PersonTests
    {
        [Fact]
        public void ShallowCopy_probably_copy_just_object_correctly()
        {
            var fullName = "Hadi jahangiri";
            var secondFullName = "Robert C.Martin";
            var street = "Darya";
            var newStreet = "New street";
            var age = 32;
            var address = new Address(street, 10, 5);
            var person = new Person(fullName, age, address);
            var copyPerson = person.ShallowCopy();

            copyPerson.FullName = secondFullName;
            copyPerson.Address.Street = newStreet;

            Assert.Equal(person.FullName, fullName);
            Assert.Equal(person.Age, age);
            Assert.Equal(person.Address.Street, newStreet);
            Assert.NotEqual(person.Address.Street, street);
            Assert.Equal(copyPerson.FullName, secondFullName);
            Assert.Equal(copyPerson.Age, age);
            Assert.Equal(copyPerson.Address.Street, newStreet);
        }

        [Fact]
        public void DeepCopy_probably_copy_just_object_correctly()
        {
            var fullName = "Hadi jahangiri";
            var secondFullName = "Robert C.Martin";
            var street = "Darya";
            var newStreet = "New street";
            var age = 32;
            var address = new Address(street, 10, 5);
            var person = new Person(fullName, age, address);
            var copyPerson = person.DeepCopy();

            copyPerson.FullName = secondFullName;
            copyPerson.Address.Street = newStreet;

            Assert.Equal(person.FullName, fullName);
            Assert.Equal(person.Age, age);
            Assert.Equal(person.Address.Street, street);
            Assert.NotEqual(person.Address.Street, newStreet);
            Assert.Equal(copyPerson.FullName, secondFullName);
            Assert.Equal(copyPerson.Age, age);
            Assert.Equal(copyPerson.Address.Street, newStreet);
        }
    }
}
