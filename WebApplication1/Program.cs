//1.

// Console.WriteLine("Podaj liczbę całkowitą:");
// string calkowita = Console.ReadLine();
// if (int.TryParse(calkowita, out int liczba))
// {
//     if (liczba % 2 == 0)
//     {
//         Console.WriteLine($"Liczba jest parzysta.");
//     }
//     else
//     {
//         Console.WriteLine($"Liczba jest nieparzysta.");
//     }
// }

//2.

// Console.Write("Podaj kierunek: polnoc, poludnie, wschod lub zachod:");
// string kierunek = Console.ReadLine()!;

// switch (kierunek)
// {
//     case "polnoc":
//         Console.WriteLine("Wyruszasz w stronę gór.");
//         break;
//     case "poludnie":
//         Console.WriteLine("Wyruszasz w stronę pustyni.");
//         break;
//     case "wschod":
//         Console.WriteLine("Wyruszasz w stronę lasu.");
//         break;
//     case "zachod":
//         Console.WriteLine("Wyruszasz w stronę morza.");
//         break;
//     default:
//         Console.WriteLine("Nieznany kierunek.");
//         break;
// }

//3.

// Console.Write("Podaj wiek: ");
// int wiek = int.Parse(Console.ReadLine()!);

// if (wiek < 0)
// {
//     Console.WriteLine("Wiek nie może być ujemny .");
// }
// else if (wiek < 13)
// {
//     Console.WriteLine("Dziecko.");
// }
// else if (wiek < 18)
// {
//     Console.WriteLine("Nastolatek.");
// }
// else if (wiek < 65)
// {
//     Console.WriteLine("Dorosły.");
// }
// else if (wiek >= 65)
// {
//     Console.WriteLine("Senior.");
// }

//6.

Console.Write("Podaj imię: ");
string imie = Console.ReadLine();

Console.Write("Podaj imię: ");
Console.Clear();
Console.WriteLine("Podaj punkty życa: ");
int punkty = int.Parse(Console.ReadLine());
//Console.Clear();
if (punkty < 0)
{
    Console.WriteLine("Punkty życia nie mogą być ujemne.");
}
Console.WriteLine("Podaj poziom:}");
int poziom = int.Parse(Console.ReadLine());
//Console.Clear();
Console.WriteLine("Podaj ilość złota:");
int zloto = int.Parse(Console.ReadLine());
// Console.Clear();
Console.WriteLine("Czy posiada mapę? (tak/nie):");
string mapa = Console.ReadLine();
// Console.Clear();
if (mapa == "tak" && punkty > 0 && poziom > 0 && zloto > 0)
{
   Console.WriteLine("Bohater może wyruszyć w podróż.");

}
else if (mapa == "nie" && punkty > 0 && poziom > 0 && zloto > 0)
{
    Console.WriteLine("Bohater może wyruszyć w podróż, ale będzie miał utrudnienia.");
}
else if (punkty <= 0 || poziom <= 0 || zloto <= 0)
{
    Console.WriteLine("Bohater nie może wyruszyć w podróż.");
}
else
{
    Console.WriteLine("Niepoprawne dane.");
}
