int number = 36596;
string numberInString = number.ToString();
int[] counts = new int[10];
foreach (char digitchar in numberInString)
{
    if (char.IsDigit(digitchar))
    {
        int digit = (int)char.GetNumericValue(digitchar);
        counts[digit]++;
    }
}
Console.WriteLine("Liczba wystąpień każdej cyfry w podanej liczbie ");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Cyfra {i}: {counts[i]} razy");
}
