var name = "Ewa";
var age = 27;
var plec = "Kobieta";


if (plec == "Kobieta" && age < 30)
{
    if (name == "Ewa")
    { Console.WriteLine("Kobieta poniżej 30 lat, Ewa."); }
    else
    {
        Console.WriteLine("Kobieta poniżej 30 lat, ale nie Ewa.");
    }

    Console.WriteLine("Jest to na pewno kobieta poniżej 30 lat.");
}
else
{
    Console.WriteLine("Ktoś inny");
}
