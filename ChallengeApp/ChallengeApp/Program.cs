using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowal", 25, new int[] { 8, 9, 7, 8, 1 });
Employee employee2 = new Employee("Anna", "Mucha", 32, new int[] { 6, 6, 9, 8, 7 });
Employee employee3 = new Employee("Damian", "Dąb", 28, new int[] { 9, 9, 8, 7, 8 });

//tablica pracowników
Employee[] employees = { employee1, employee2, employee3 };

//znajdowanie pracownika z najwyższą sumą ocen
Employee employeeWithHigestRatings = employees.OrderByDescending(e => e.CalculateTotalRatings()).First();

//wyświetlenie informacji o pracowniku z najwyższą sum,a ocen
Console.WriteLine("Pracownik z najwyższą sumą ocen: ");
employeeWithHigestRatings.DisplayEmployeeInfo();
int totalRaitings = employeeWithHigestRatings.CalculateTotalRatings();
Console.WriteLine($"Suma ocen: {totalRaitings}");