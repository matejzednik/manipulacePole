/*
1.Přidání prvku
2.Změna hodnoty prvku - pole musí změnit velikost, pokud žádám o zápis mimo jeho aktuální velikost
3.Získání hodnoty prvku - je potřeba vyřešit, co se má stát, pokud požádám o prvek na indexu mimo aktuální velikost pole
4.Odstranění prvku na daném indexu a přesunutí následujících prvků na jeho místo
5.Vložení prvku na určený index a posunutí ostatních prvků tak, aby pro něj vzniklo místo
6.Setřesení pole tak, aby z pole zmizely díry z prázdných prvků
7.Získání velikosti pole
8.Získání počtu nenulových prvků*/

Console.WriteLine("Hello World!");

//1. Podprogram
int?[] pole = new int?[] { 1, 5, 3, 2, 4, 6, 7 };
int?[] pridaniPrvku(int?[]vysledek)
{
    
    pole = pole.Append(100).ToArray();
    foreach (int? i in pole)
    {
        Console.WriteLine(i);
    }
    return pole;

}
pridaniPrvku(pole);

Console.WriteLine("------------------");
//2. Podprogram
int?[] zmenaHodnotyPrvku(int?[] vysledek2)
{
    Array.Resize(ref pole, pole.Length + 1);
    return pole;
}
zmenaHodnotyPrvku(pole);