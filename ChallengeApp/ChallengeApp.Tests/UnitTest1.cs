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
    }
}