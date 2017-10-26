using System;

namespace PersonSolution
{
    public class PersonService
    {
        public static Boolean AreEqual(Person person1, Person person2)
        {
            Boolean result = false;
            if (person1 != null && person2 != null &&
                person1.GetFirstName() == person2.GetFirstName() &&
                person1.GetLastName() == person2.GetLastName() &&
                person1.GetAge() == person2.GetAge() &&
                person1.GetPersonGender() == person2.GetPersonGender())
            {
                result = true;
            }

            return result;
        }

        public static Boolean AreNamesake(Person person1, Person person2)
        {
            Boolean result = false;

            if (person1 != null && person2 != null &&
                person1.GetFirstName() == person2.GetFirstName())
                result = true;

            return result;
        }

        public static Boolean HaveSameAge(Person person1, Person person2)
        {
            Boolean result = false;

            if (person1 != null && person2 != null &&
                person1.GetAge() == person2.GetAge())
                result = true;

            return result;
        }

        public static Person BuildPerson(String firstName, String lastName, int age, Person.Gender gender)
        {
            Person person = new Person();
            person.SetFirstName(firstName);
            person.SetLastName(lastName);
            person.SetAge(age);
            person.SetPersonGender(gender);
            return person;
        }

    }
}
