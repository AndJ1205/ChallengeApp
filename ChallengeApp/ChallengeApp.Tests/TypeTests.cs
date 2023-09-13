namespace ChallengeApp.Tests
{
    public class TypeTests

    {
        [Test]
        public void WhenNameLooksTheSame()
        {
            //Arange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            // Act

            // Assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string firstName)
        {
            return new Employee(firstName);
        }
        [Test]
        public void WhenLoginIsTheSame()
        {
            //Arange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");

            // Act

            // Assert
            Assert.AreEqual(employee1.FirstName, employee2.FirstName);
        }
        [Test]
        public void WhenAgeReturn_compareEmployees()
        {
            //Arange
            int age1 = 25;
            int age2 = 32;

            //Assert
            Assert.AreNotEqual(age1, age2);
        }
        
    }
}