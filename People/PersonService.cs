using System;

namespace PersonSolution
{
    public static class PersonService
    {
        public static Boolean AreEqual(Person person1, Person person2)
        {
            Boolean result = false;
            if (person1 != null && person2 != null &&
                person1.FirstName == person2.FirstName &&
                person1.LastName == person2.LastName &&
                person1.Age == person2.Age &&
                person1.PersonGender == person2.PersonGender)
            {
                result = true;
            }

            return result;
        }

        public static Boolean AreNamesake(Person person1, Person person2)
        {
            Boolean result = false;

            if (person1 != null && person2 != null &&
                person1.FirstName == person2.FirstName)
                result = true;

            return result;
        }

        public static Boolean HaveSameAge(Person person1, Person person2)
        {
            Boolean result = false;

            if (person1 != null && person2 != null &&
                person1.Age == person2.Age)
                result = true;

            return result;
        }

        public static Person BuildPerson(String firstName, String lastName, int age, Person.Gender gender)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Age = age;
            person.PersonGender = gender;
            return person;
        }

    }
}
