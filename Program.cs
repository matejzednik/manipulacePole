/*
1.Přidání prvku
2.Změna hodnoty prvku - pole musí změnit velikost, pokud žádám o zápis mimo jeho aktuální velikost
3.Získání hodnoty prvku - je potřeba vyřešit, co se má stát, pokud požádám o prvek na indexu mimo aktuální velikost pole
4.Odstranění prvku na daném indexu a přesunutí následujících prvků na jeho místo
5.Vložení prvku na určený index a posunutí ostatních prvků tak, aby pro něj vzniklo místo
6.Setřesení pole tak, aby z pole zmizely díry z prázdných prvků
7.Získání velikosti pole
8.Získání počtu nenulových prvků*/

using System;

Console.WriteLine("Hello World!");

//1. Podprogram
int?[] pole = new int?[] { 1, 5, 3, 2, 4, 6, 7, null };
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

Console.WriteLine("------------------");
//3. Podprogram

Console.WriteLine("Zadejte kolikátý chcete prvek ");
string podprogram3Pole = (Console.ReadLine());
int?[] ziskaniHodnotyPrvku(int?[] vysledek3)
{
    if (int.TryParse(podprogram3Pole, out int index))
    {
        
        if (index >= 0 && index < pole.Length)
        {
            
            int element = (int)pole[index];
            Console.WriteLine("Prvek na indexu " + index + " je " + element);
        }
        else
        {
            Console.WriteLine("Index je mimo rozsah");
        }
    }
    else
    {
        Console.WriteLine("Zadejte prosím jiné celé číslo");
    }


    return vysledek3;
}

Console.WriteLine("Kolikátý prvek chcete z pole odstranit?");
int indexToRemove = Convert.ToInt32(Console.ReadLine());
//4. Podprogram
int?[] odstraneniPrvku(int?[] vysledek4)
{
    if (indexToRemove >= 0 && indexToRemove < pole.Length)
    {
        
        int[] newArray = new int[pole.Length - 1];

        // Copy elements before the index
        for (int i = 0; i < indexToRemove; i++)
        {
            newArray[i] = (int)pole[i];
        }

        
        for (int i = indexToRemove; i < newArray.Length; i++)
        {
            newArray[i] = (int)pole[i + 1];
        }

        
        pole = pole;

        
    }

    return vysledek4;
}
odstraneniPrvku(pole);


Console.WriteLine("------------------");
//7. Podprogram

int?[] velikostPole(int?[] vysledek7)
{
    int velikostPole = pole.Length;
    
    return vysledek7;
}
velikostPole(pole);