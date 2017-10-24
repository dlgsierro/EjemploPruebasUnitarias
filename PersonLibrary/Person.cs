using System;

namespace PersonSolution
{
    public class Person
    {
        public enum Gender { MALE, FEMALE };

        private String firstName;
        private String lastName;
        private int age;
        private Gender gender;

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public Gender GetPersonGender()
        {
            return this.gender;
        }

        public void SetPersonGender(Gender gender)
        {
            this.gender = gender;
        }

    }
}
