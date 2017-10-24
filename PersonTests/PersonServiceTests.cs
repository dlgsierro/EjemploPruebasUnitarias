using NUnit.Framework;

namespace PersonSolution.Tests
{
    [TestFixture()]
    public class PersonServiceTests
    {
        [Test()]
        public void BuildPersonTest()
        {
            PersonService service = new PersonService();

            Person person = service.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Assert.IsNotNull(person);
        }

        [Test()]
        public void AreEqualTest()
        {
            PersonService service = new PersonService();

            Person person0 = service.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Person person1 = service.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Assert.IsTrue(service.AreEqual(person0, person1));

            Person person2 = service.BuildPerson("Juan", "Perez", 41, Person.Gender.MALE);
            Assert.IsFalse(service.AreEqual(person1, person2));

            Person person3 = service.BuildPerson("Gonzalo", "Sierro", 42, Person.Gender.MALE);
            Assert.IsFalse(service.AreEqual(person1, person3));

            Person person4 = service.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.FEMALE);
            Assert.IsFalse(service.AreEqual(person1, person4));
        }

        [Test()]
        public void AreNamesakeTest()
        {
            PersonService service = new PersonService();

            Person person1 = service.BuildPerson("Gonzalo", "Sierro", 41, Person.Gender.MALE);
            Person person2 = service.BuildPerson("Juan", "Perez", 41, Person.Gender.MALE);
            Assert.IsFalse(service.AreNamesake(person1, person2));

            Person person3 = service.BuildPerson("Gonzalo", "Perez", 41, Person.Gender.MALE);
            Assert.IsTrue(service.AreNamesake(person1, person3));
        }
    }
}