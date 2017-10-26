using System;

namespace PersonSolution
{
    public class Person
    {
        public enum Gender { MALE, FEMALE };

        private int age;
        private String firstName;
        private String lastName;
        private Gender gender;

        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public Gender PersonGender { get => gender; set => gender = value; }

    }
}
