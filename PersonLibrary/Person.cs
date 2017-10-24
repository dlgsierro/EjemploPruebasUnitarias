using System;

namespace PersonSolution
{
    public class Person
    {
        private String firstName;
        private String lastName;
        private int age;
        public enum Gender { MALE, FEMALE };
        private Gender gender;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public Gender PersonGender { get => gender; set => gender = value; }
    }
}
