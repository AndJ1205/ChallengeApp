string name = "Ewa";
char sex = 'F';//kobieta - F, mężczyzna - M
int age = 28;
if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && sex == 'F' && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Osoba nie spełniająca kryteriów");
}