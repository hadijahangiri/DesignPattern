using System;
using System.Collections.Generic;

namespace Person.Domain
{
    public class Person : ICloneable<Person>
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string fullName, int age, Address address)
        {
            FullName = fullName;
            Age = age;
            Address = address;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
           var person = (Person)this.MemberwiseClone();
           person.Address = new Address(person.Address.Street, person.Address.Plaque, person.Address.Unit);
           return person;
        }
    }
}
