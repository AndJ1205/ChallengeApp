namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {


        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()

        {
            //Arange
            var employee = new Employee("Adam", "Kowal", 25, new int[] { -8, 0, 5, 7, -4 });

            // Act
            int totalRatings = employee.CalculateTotalRatings();

            // Assert
            Assert.AreEqual(0, totalRatings); // Oczekujemy sumy ocen 0

        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResultA()

        {
            //Arange
            var employee = new Employee("Adam", "Kowal", 25, new int[] { -8, -9, 5, 7, -4 });

            // Act
            int totalRatings = employee.CalculateTotalRatings();

            // Assert
            Assert.AreEqual(-9, totalRatings); // Oczekujemy sumy ocen -9

        }
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResultB()

        {
            //Arange
            var employee = new Employee("Adam", "Kowal", 25, new int[] { 8, 9, 5, 7, 4 });

            // Act
            int totalRatings = employee.CalculateTotalRatings();

            // Assert
            Assert.AreEqual(33, totalRatings); // Oczekujemy sumy ocen 33

        }
    }
}