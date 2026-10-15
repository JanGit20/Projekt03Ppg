
// Console.Write("Podaj imię: ");
// string imie = Console.ReadLine();

// Console.Write("Podaj imię: ");
// Console.Clear();
// Console.WriteLine("Podaj punkty życa: ");
// int punkty = int.Parse(Console.ReadLine());
// Console.Clear();
// if (punkty < 0)
// {
//     Console.WriteLine("Punkty życia nie mogą być ujemne.");
// }
// Console.WriteLine("Podaj poziom:");
// int poziom = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Podaj ilość złota:");
// int zloto = int.Parse(Console.ReadLine());
// Console.Clear();
// Console.WriteLine("Czy posiada mapę? (tak/nie):");
// string mapa = Console.ReadLine();
// Console.Clear();

// Console.WriteLine("+======= Karta postaci =======+");
// Console.WriteLine($"|Imię: {imie}");
// Console.WriteLine($"|Punkty życia: {punkty}");
// Console.WriteLine($"|Poziom: {poziom}");
// Console.WriteLine($"|Złoto: {zloto}");
// Console.WriteLine($"|Mapa: {mapa}");
// Console.WriteLine("+=============================+");
// if (mapa == "tak" && punkty > 0 && poziom > 0 && zloto > 0)
// {
//    Console.WriteLine("Bohater może wyruszyć w podróż.");

// }
// else if (mapa == "nie" && punkty > 30 && poziom > 10 && zloto > 20)
// {
//     Console.WriteLine("Bohater może wyruszyć w podróż, ale będzie miał utrudnienia.");
// }
// else if (punkty <= 0 || poziom <= 5 || zloto <= 10)
// {
//     Console.WriteLine("Bohater nie może wyruszyć w podróż.");
// }
// else
// {
//     Console.WriteLine("Niepoprawne dane.");
// }
// if (punkty < 30)
// {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("Bohater ma mało punktów życia.");
// }
// else if (punkty >= 30 && punkty < 70)
// {
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine("Bohater ma średnią ilość punktów życia.");
// }
// else if (punkty >= 70)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine("Bohater ma dużo punktów życia.");
// }
// Console.ForegroundColor = ConsoleColor.Gray;

// Console.WriteLine("Naciśnij dowolny klawisz, aby wyjść z menu.");
// Console.ReadKey();