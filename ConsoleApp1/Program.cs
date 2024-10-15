
// se sono in debug faccio un for da 1 a 10 e stampo i
//se sono in realese faccio il for da 1 a 20 il valore dell indice

Console.ForegroundColor=ConsoleColor.Green;

#region ESERCIZI_15/10/2024

#if DEBUG
Console.WriteLine("Sono in DEBUG");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Il valore dell indice è "+i);
}
#endif

#if RELEASE
Console.WriteLine("Sono in RELEASE");

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine("Il valore dell indice è " + i);
}
#endif

#endregion
