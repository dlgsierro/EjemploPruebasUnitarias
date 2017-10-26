using NUnit.Framework;

namespace PersonSolution.Tests
{
    [TestFixture()]
    public class PersonServiceTests
    {
        [Test()]
        public void BuildPersonTest()
        {
            Person person = PersonService.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Assert.IsNotNull(person);
        }

        [Test()]
        public void AreEqualTest()
        {
            Person person0 = PersonService.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Person person1 = PersonService.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Assert.IsTrue(PersonService.AreEqual(person0, person1));

            Person person2 = PersonService.BuildPerson("Juan", "Perez", 41, Person.Gender.MALE);
            Assert.IsFalse(PersonService.AreEqual(person1, person2));

            Person person3 = PersonService.BuildPerson("Gonzalo", "Sierro", 42, Person.Gender.MALE);
            Assert.IsFalse(PersonService.AreEqual(person1, person3));

            Person person4 = PersonService.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.FEMALE);
            Assert.IsFalse(PersonService.AreEqual(person1, person4));
        }

        [Test()]
        public void AreNamesakeTest()
        {
            Person person1 = PersonService.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Person person2 = PersonService.BuildPerson("Juan", "Perez", 41, Person.Gender.MALE);
            Assert.IsFalse(PersonService.AreNamesake(person1, person2));

            Person person3 = PersonService.BuildPerson("Gonzalo", "Perez", 41, Person.Gender.MALE);
            Assert.IsTrue(PersonService.AreNamesake(person1, person3));
        }
    }
}